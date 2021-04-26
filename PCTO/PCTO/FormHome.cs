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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        Address currentAddress;
        static ApiCaller caller = new ApiCaller();
        CoordinateHelper helper = new CoordinateHelper(caller);
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbCurNumber.Text)||
                string.IsNullOrEmpty(txbCurStreet.Text) ||
                string.IsNullOrEmpty(txbCurStreet.Text) ||
                string.IsNullOrEmpty(txbCurProvince.Text))
            {
                MessageBox.Show("Empty string");
                return;
            }
            try
            {
                currentAddress = new Address(txbCurNumber.Text, txbCurStreet.Text, txbCurStreet.Text, txbCurProvince.Text);
                helper.SetCoordinates(currentAddress);
            }
            catch(ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Generic error: {ex.Message}");
                return;
            }
        }
    }
}
