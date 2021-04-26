using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO
{
    partial class FormShortStreets : Form
    {
        FormHome formHome;
        FormRiderSpace formRiderSpace;
        FormMap formMap;
        public FormShortStreets()
        {
            InitializeComponent();

            formHome = new FormHome() { TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formHome);

            formRiderSpace = new FormRiderSpace(this) { TopLevel = false, TopMost = true };
            formRiderSpace.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formRiderSpace);

            formMap = new FormMap(this) { TopLevel = false, TopMost = true };
            formMap.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formMap);

            ShowFormHome();
        }
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

        public void ShowFormMap(IList<Package> packages)
        {
            formHome.Hide();
            formRiderSpace.Hide();
            formMap.Show();
            OnShowingFormMap(packages);
        }
        public event EventHandler<ShowingFormMapEventArgs> ShowingFormMap;
        protected virtual void OnShowingFormMap(IList<Package> packages) => ShowingFormMap?.Invoke(this, new ShowingFormMapEventArgs(packages));

        private void shortestStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormHome();
        }
    }
}
