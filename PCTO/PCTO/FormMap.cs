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
            f.ShowingFormMap += (o, e) => { SetPosition(e.packages); SetMarkers(e.packages); SetConfidenceMessage(e.packages); };
            gMap.ShowCenter = false;
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.MinZoom = 4;
            gMap.MaxZoom = 18;
            gMap.Zoom = 10;
            MarkersOverlay = new GMapOverlay("markers");
        }
        GMapOverlay MarkersOverlay;
        string ConfidenceMessage;
        private void CloseMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShortStreets.ShowFormRiderSpace();
        }
        void SetPosition(IList<Package> packages)
        {
            var p = packages.FirstOrDefault();
            if (p == default)
                gMap.Position = new PointLatLng(45.690494, 9.681876);
            else
                gMap.Position = new PointLatLng(double.Parse(p.Destination.Coordinates.Lat.ToString()),
                                                double.Parse(p.Destination.Coordinates.Lng.ToString()));
        }
        void SetMarkers(IList<Package> packages)
        {

            gMap.Overlays.Clear();
            gMap.Overlays.Add(MarkersOverlay);
            foreach (var p in packages)
                MarkersOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(p.Destination.Coordinates.Lat.ToString()),
                                                                      double.Parse(p.Destination.Coordinates.Lng.ToString())),
                                                                      GMarkerGoogleType.red));
            //var marker1 = new GMarkerGoogle(new PointLatLng(45.690494, 9.681876), GMarkerGoogleType.red);
            //markers.Markers.Add(marker1);
        }
        private void SetConfidenceMessage(IList<Package> packages)
        {
            ConfidenceMessage = string.Empty;
            foreach (var p in packages)
                ConfidenceMessage = ConfidenceMessage + $"{p} - Confidence: {Confidences.List[p.Destination.Coordinates.Confidence]}\n";
            if (string.IsNullOrEmpty(ConfidenceMessage))
                ConfidenceMessage = "No confidences available";

        }
        private void confidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConfidenceMessage);
        }
    }
}
