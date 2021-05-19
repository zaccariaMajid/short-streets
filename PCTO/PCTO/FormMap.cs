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

            markersImg = new MarkersImg();
            pathColor = new PathColor();
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
                SetPackagesRoutingDictionary(e.CurrentAddress, e.Packages);
                SetConfidenceMessage(e.CurrentAddress, e.Packages);
                SetRoute(e.CurrentAddress, e.Packages);
            };
            gMap.ShowCenter = false;
            gMap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.DragButton = MouseButtons.Left;
            gMap.MinZoom = 4;
            gMap.MaxZoom = 19;
            gMap.Zoom = 13;
        }

        GMapOverlay MarkersOverlay;
        GMapOverlay RoutesOverlay;
        RouterDb RouterDb;
        MarkersImg markersImg;
        PathColor pathColor;
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
            MarkersOverlay.Markers.Add(new GMarkerGoogle(gMap.Position, markersImg.Images[0]));
            int count = 1;
            foreach (var p in packages)
            {
                MarkersOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(p.Destination.Coordinates.Lat.ToString()),
                                                                      double.Parse(p.Destination.Coordinates.Lng.ToString())),
                                                                      markersImg.Images[count]));
                count++;
            }

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
            ConfidenceMessage = $"HOME) {address} - Confidence: {Confidences.List[address.Coordinates.Confidence]}\n";
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
            try
            {
                SetPath
                    (GetRoutingPoints
                        (GetAllCoordinates
                            (startPosition, list.ToList())));

            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Generic error: {ex.Message}");
                return;
            }

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
                IList<int> connected = new List<int>();
                IList<int> costs = new List<int>();
                foreach (var dict in coordinatesVertices.Coordinates)
                {
                    int id = Prd.Dictionary.Where(x => x.Value.Destination.Coordinates == dict.Key).First().Key;
                    connected.Add(id);
                    int cost = dict.Value;
                    costs.Add(cost);
                }
                var routingPoint = new RoutingPoint() { Id = Prd.Dictionary.Where(x => x.Value.Destination.Coordinates == c).First().Key };
                routingPoint.Volume = Prd.Dictionary[routingPoint.Id].Volume;
                routingPoint.Weight = Prd.Dictionary[routingPoint.Id].Weight;
                routingPoint.Connected = connected;
                routingPoint.Costs = costs;
                routingPoints.Add(routingPoint);
            }
            return routingPoints;
        }

        void SetPath(IList<RoutingPoint> points)
        {
            IList<Trip> trips = RoutingAlgorithm.GetViaggio(points);
            int count = 0;
            foreach (var t in trips)
            {
                IList<int> sequence = new List<int>();
                foreach (var v in t.viaggioSingolo)
                    sequence.Add(v.Id);
                IList<Package> packages = new List<Package>();
                foreach (int cod in sequence)
                    packages.Add(Prd.Dictionary[cod]);
                SetPath(packages, pathColor.Colors[count]);
                SetMarkers(packages);
                count++;
            }
        }

        void SetPath(IList<Package> list, Color color)
        {
            gMap.Overlays.Add(RoutesOverlay);
            IList<PointLatLng> points = list.Select(x => new PointLatLng(double.Parse(x.Destination.Coordinates.Lat.ToString()), double.Parse(x.Destination.Coordinates.Lng.ToString())))
                                            .ToList();
            //points.Insert(0, new PointLatLng(double.Parse(startPosition.Coordinates.Lat.ToString()), double.Parse(startPosition.Coordinates.Lng.ToString())));
            //points.Add(new PointLatLng(double.Parse(startPosition.Coordinates.Lat.ToString()), double.Parse(startPosition.Coordinates.Lng.ToString())));

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
                        r.Stroke.Color = color;
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
