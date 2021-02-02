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

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();

            this.Hide();

            form2.Show();
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
    }
}
