using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Itinero;
using Itinero.Osm.Vehicles;
using System.IO;
using Itinero.IO.Osm;

namespace PCTO
{
    partial class FormMap : Form
    {
        FormShortStreets fShortStreets;
        public FormMap(FormShortStreets f)
        {
            InitializeComponent();

            fShortStreets = f;
            fShortStreets.StreamRead += (o, e) =>
            {
                RouterDb = new RouterDb();
                RouterDb.LoadOsmData(f.stream, Vehicle.Pedestrian);
            };
            fShortStreets.ShowingFormMap += (o, e) =>
            {
                MarkersOverlay = new GMapOverlay("markers");
                RoutesOverlay = new GMapOverlay("routes");
                SetPosition(e.CurrentAddress);
                SetMarkers(e.Packages);
                SetPackagesRoutingDictionary(e.CurrentAddress, e.Packages);
                SetConfidenceMessage(e.CurrentAddress, e.Packages);
                SetRoute(e.CurrentAddress, e.Packages);
            };
            gMap.ShowCenter = false;
            gMap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.MinZoom = 4;
            gMap.MaxZoom = 18;
            gMap.Zoom = 13;
        }



        GMapOverlay MarkersOverlay;
        GMapOverlay RoutesOverlay;
        RouterDb RouterDb;
        PackagesRoutingDictionary Prd;
        string ConfidenceMessage;

        private void CloseMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShortStreets.ShowFormRiderSpace();
        }

        void SetPosition(Address address)
        {
            gMap.Position = new PointLatLng(double.Parse(address.Coordinates.Lat.ToString()),
                                        double.Parse(address.Coordinates.Lng.ToString()));
        }

        void SetMarkers(IList<Package> packages)
        {
            gMap.Overlays.Clear();
            gMap.Overlays.Add(MarkersOverlay);
            MarkersOverlay.Markers.Add(new GMarkerGoogle(gMap.Position, GMarkerGoogleType.red));
            foreach (var p in packages)
                MarkersOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(p.Destination.Coordinates.Lat.ToString()),
                                                                      double.Parse(p.Destination.Coordinates.Lng.ToString())),
                                                                      GMarkerGoogleType.arrow));
        }

        void SetPackagesRoutingDictionary(Address address, IList<Package> packages)
        {
            Prd = new PackagesRoutingDictionary();

            Prd.Dictionary.Add(1, new Package(address, 0, 0));
            int count = 2;
            foreach (var p in packages)
            {
                Prd.Dictionary.Add(count, p);
                count++;
            }
        }

        private void SetConfidenceMessage(Address address, IList<Package> packages)
        {
            ConfidenceMessage = $"START) {address} - Confidence: {Confidences.List[address.Coordinates.Confidence]}\n";
            int num = 1;
            foreach (var p in packages)
            {
                ConfidenceMessage = ConfidenceMessage + $"{num}) {p} - Confidence: {Confidences.List[p.Destination.Coordinates.Confidence]}\n";
                num++;
            }
            if (string.IsNullOrEmpty(ConfidenceMessage))
                ConfidenceMessage = "No confidences available";

        }

        private void confidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConfidenceMessage);
        }

        void SetRoute(Address startPosition, IList<Package> list)
        {
            GetRoutingPoints(GetAllCoordinates(startPosition, list.ToList()));
            GetPath();
            SetPath();
        }

        IList<Coordinates> GetAllCoordinates(Address startPosition, IList<Package> list)
        {
            IList<Coordinates> coordinates = new List<Coordinates>() { startPosition.Coordinates };
            foreach (var p in list)
                coordinates.Add(p.Destination.Coordinates);
            return coordinates;
        }
        IList<RoutingPoint> GetRoutingPoints(IList<Coordinates> coordinates)
        {
            IList<Coordinates> tCoordinates;
            IList<RoutingPoint> routingPoints = new List<RoutingPoint>();
            foreach (var c in coordinates)
            {
                tCoordinates = coordinates.ToList();
                tCoordinates.Remove(c);
                var coordinatesVertices = CoordinatesVerticesMaker.NewCoordinatesvertices(c, tCoordinates, RouterDb);
                IList<Vertex> vertices = new List<Vertex>();
                foreach (var dict in coordinatesVertices.Coordinates)
                {
                    Vertex v = default;
                    v.Id = Prd.Dictionary.Where(x => x.Value.Destination.Coordinates == dict.Key).First().Key;
                    v.Distance = dict.Value;
                    vertices.Add(v);
                }
                var routingPoint = new RoutingPoint() { Id = Prd.Dictionary.Where(x => x.Value.Destination.Coordinates == c).First().Key };
                routingPoint.Volume = Prd.Dictionary[routingPoint.Id].Volume;
                routingPoint.Weight = Prd.Dictionary[routingPoint.Id].Weight;
                routingPoint.Vertices = vertices;
            }
            return routingPoints;
        }


        void GetPath()
        {

        }

        void SetPath()
        {
            gMap.Overlays.Add(RoutesOverlay);
            IList<PointLatLng> points = list.Select(x => new PointLatLng(double.Parse(x.Destination.Coordinates.Lat.ToString()), double.Parse(x.Destination.Coordinates.Lng.ToString())))
                                            .ToList();
            points.Insert(0, new PointLatLng(double.Parse(startPosition.Coordinates.Lat.ToString()), double.Parse(startPosition.Coordinates.Lng.ToString())));
            points.Add(new PointLatLng(double.Parse(startPosition.Coordinates.Lat.ToString()), double.Parse(startPosition.Coordinates.Lng.ToString())));

            try
            {
                for (int x = 0; x < points.Count; x++)
                {
                    if (x + 1 < points.Count)
                    {
                        var router = new Router(RouterDb);
                        var profile = Vehicle.Pedestrian.Fastest();
                        var start = router.Resolve(profile, float.Parse(points[x].Lat.ToString()), float.Parse(points[x].Lng.ToString()));
                        var end = router.Resolve(profile, float.Parse(points[x + 1].Lat.ToString()), float.Parse(points[x + 1].Lng.ToString()));
                        var route = router.Calculate(profile, start, end);
                        IList<PointLatLng> allPoints = route.Shape.Select(s => new PointLatLng() { Lat = double.Parse(s.Latitude.ToString()), Lng = double.Parse(s.Longitude.ToString()) })
                                                                  .ToList();
                        var r = new GMapRoute(allPoints, "route");
                        r.Stroke.Color = Color.Red;
                        r.Stroke.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        RoutesOverlay.Routes.Add(r);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
