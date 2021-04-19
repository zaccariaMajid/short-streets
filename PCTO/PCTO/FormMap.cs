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
            f.ShowingFormMap += (o, e) => { SetMarkers(e.packages); };
            gMap.ShowCenter = false;
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.Position = new PointLatLng(45.6982642, 9.6772698);
            gMap.MinZoom = 10;
            gMap.MaxZoom = 17;
            gMap.Zoom = 5;
        }
        private void CloseMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShortStreets.ShowFormRiderSpace();
        }
        void SetMarkers(IList<Package> packages)
        {
            var markers = new GMapOverlay("markers");
            foreach (var p in packages)
                markers.Markers.Add(new GMarkerGoogle
                    (new PointLatLng
                        (double.Parse(p.Destination.Coordinates.Lat.ToString()),
                         double.Parse(p.Destination.Coordinates.Lng.ToString())),
                         GMarkerGoogleType.red));
            var marker1 = new GMarkerGoogle(new PointLatLng(45.690494, 9.681876), GMarkerGoogleType.red);
            markers.Markers.Add(marker1);
            gMap.Overlays.Add(markers);
        }
    }
}
