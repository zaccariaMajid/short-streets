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
    public partial class FormShortStreets : Form
    {
        FormRiderSpace formRiderSpace;
        FormMap formMap;
        public FormShortStreets()
        {
            InitializeComponent();

            formRiderSpace = new FormRiderSpace(this) { TopLevel = false, TopMost = true };
            formRiderSpace.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formRiderSpace);

            formMap = new FormMap(this) { TopLevel = false, TopMost = true };
            formMap.FormBorderStyle = FormBorderStyle.None;
            pnlHome.Controls.Add(formMap);
        }
        private void riderSpaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFormRiderSpace();
        }

        public void ShowFormRiderSpace()
        {
            formMap.Hide();
            formRiderSpace.Show();
        }

        public void ShowFormMap()
        {
            formRiderSpace.Hide();
            formMap.Show();
        }
    }
}
