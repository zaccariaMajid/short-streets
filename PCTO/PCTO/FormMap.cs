using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PCTO
{
    partial class FormMap : Form
    {
        FormShortStreets fShortStreets;
        public FormMap(FormShortStreets f)
        {
            InitializeComponent();

            fShortStreets = f;
            f.ShowingFormMap += (o, e) => { MarkersOverlay = new GMapOverlay("markers"); ;
                SetPosition(e.CurrentAddress); SetMarkers(e.Packages); 
                SetConfidenceMessage(e.CurrentAddress, e.Packages); SetRoute(e.CurrentAddress, e.Packages);
            };
            gMap.ShowCenter = false;
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.MinZoom = 4;
            gMap.MaxZoom = 18;
            gMap.Zoom = 13;
        }
        GMapOverlay MarkersOverlay;
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
            MarkersOverlay.Markers.Add(new GMarkerGoogle(gMap.Position, GMarkerGoogleType.blue));
            foreach (var p in packages)
                MarkersOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(p.Destination.Coordinates.Lat.ToString()),
                                                                      double.Parse(p.Destination.Coordinates.Lng.ToString())),
                                                                      GMarkerGoogleType.red));
            //var marker1 = new GMarkerGoogle(new PointLatLng(45.690494, 9.681876), GMarkerGoogleType.red);
            //markers.Markers.Add(marker1);
        }
        private void SetConfidenceMessage(Address address, IList<Package> packages)
        {
            ConfidenceMessage = $"{address} - Confidence: {Confidences.List[address.Coordinates.Confidence]}\n";
            foreach (var p in packages)
                ConfidenceMessage = ConfidenceMessage + $"{p} - Confidence: {Confidences.List[p.Destination.Coordinates.Confidence]}\n";
            if (string.IsNullOrEmpty(ConfidenceMessage))
                ConfidenceMessage = "No confidences available";

        }
        private void confidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConfidenceMessage);
        }
        void SetRoute(Address startPosition, IList<Package> list)
        {
            IList<PointLatLng> points = list.Select(x => new PointLatLng(double.Parse(x.Destination.Coordinates.Lat.ToString()), 
                                                                         double.Parse(x.Destination.Coordinates.Lng.ToString())))
                                            .ToList();

            GMapProviders.GoogleMap.ApiKey = "";
            var route = GMapProviders.GoogleMap.GetDirections(out GDirections myDirections, points[0], points[1], false, false, true, false, false);
            //MapRoute route = GoogleMapProvider.Instance.GetRoute(new PointLatLng(double.Parse(startPosition.Coordinates.Lat.ToString()), double.Parse(startPosition.Coordinates.Lng.ToString())),
            //                                                new PointLatLng(double.Parse(list[0].Destination.Coordinates.Lat.ToString()), double.Parse(list[0].Destination.Coordinates.Lng.ToString())),
            //                                                false, true, 14);
            var r = new GMapRoute(myDirections.Route, "Route");
            var RoutesOverlay = new GMapOverlay("Routes");
            RoutesOverlay.Routes.Add(r);
            gMap.Overlays.Add(RoutesOverlay);

        }
    }
}
