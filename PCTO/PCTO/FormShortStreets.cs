using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PCTO
{
    partial class FormShortStreets : Form
    {
        FormHome formHome;
        FormRiderSpace formRiderSpace;
        FormMap formMap;
        public Stream stream;
        public Address currentAddress;
        public IList<Package> packages = new List<Package>();
        public CoordinatesRange coordinatesRange = new CoordinatesRange()
        {
            MinCoordinates = new Coordinates() { Lat = 45.672642M, Lng = 9.655701M },
            MaxCoordinates = new Coordinates() { Lat = 45.710610M, Lng = 9.687639M }
        };
        public FormShortStreets()
        {
            InitializeComponent();
            Startup();
            ShowFormHome();
        }

        void Startup()
        {
            //loadingForm = new LoadingForm() { TopLevel = true, TopMost = true };
            //this.Hide();
            //loadingForm.Show();
            stream = LoadFile.GetStream("comune_bergamo.pbf");
            //loadingForm.Hide();
            //this.Show();
            formHome = new FormHome(this) { TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formHome);

            formRiderSpace = new FormRiderSpace(this) { TopLevel = false, TopMost = true };
            formRiderSpace.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formRiderSpace);

            formMap = new FormMap(this) { TopLevel = false, TopMost = true };
            formMap.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formMap);
            OnStreamRead();
        }
        public event EventHandler StreamRead;
        protected virtual void OnStreamRead() => StreamRead?.Invoke(this, new EventArgs());

        private void riderSpaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFormRiderSpace();
        }

        public void ShowFormHome()
        {
            formRiderSpace.Hide();
            formMap.Hide();
            formHome.Show();
        }
        public void ShowFormRiderSpace()
        {
            formHome.Hide();
            formMap.Hide();
            formRiderSpace.Show();
        }

        public void ShowFormMap()
        {
            formHome.Hide();
            formRiderSpace.Hide();
            formMap.Show();
            OnShowingFormMap(currentAddress, packages);
        }
        public event EventHandler<ShowingFormMapEventArgs> ShowingFormMap;
        protected virtual void OnShowingFormMap(Address address, IList<Package> packages) => ShowingFormMap?.Invoke(this, new ShowingFormMapEventArgs(address, packages));

        private void shortestStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormHome();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentAddress != null)
                ShowFormMap();
            else
                MessageBox.Show("Set your current position to access to the map (home)");
        }
    }
}
