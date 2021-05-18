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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        Stream s;
        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.Show();
            s = LoadFile.GetStream("comune_bergamo.pbf");
            this.Close();
            Application.Run(new FormShortStreets() { stream = s });
        }
    }
}
