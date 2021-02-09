﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PCTO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            gMapControl1.ShowCenter = false;
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(45.6982642, 9.6772698);
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();

            form1.Show();
        }
    }
}
