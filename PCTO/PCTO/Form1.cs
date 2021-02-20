using System;
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
using IronPython.Hosting; 


namespace PCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Package currentPackage;
        private void btnConfirmNumPackages_Click(object sender, EventArgs e)
        {
            var numPackages = nudPackages.Value;
            if (numPackages < 1)
            {
                MessageBox.Show("Invalid packages quantity");
                return;
            } 
            //var form2 = new Form2();
            //this.Hide();
            //form2.Show();

            var packages = new List<PackDTO>();
            for (int x = 0; x < numPackages; x++)
                packages.Add(new Package(new Place()).ToDTO());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = packages;
            nudPackages.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p1 = Python.CreateEngine();
            try
            {
                p1.ExecuteFile("C:\\Users\\zacca\\source\\repos\\PCTO\\PCTO\\bin\\Debug");

            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.SelectedCells.Count < 1)
            //    return;
            //currentPackage = Package.GetPackages()
            //    .Where(x => x.Id.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString())
            //    .SingleOrDefault();
            //MessageBox.Show($"{currentPackage.Id}, {currentPackage.Volume}, {currentPackage.Weight}");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //FormsElaboration.ChangePackageProperties(currentPackage, dataGridView1);
        }

        
    }
}
