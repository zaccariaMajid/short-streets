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
    public partial class FormRiderSpace : Form
    {
        FormShortStreets fShortStreets;
        public FormRiderSpace(FormShortStreets f)
        {
            InitializeComponent();
            fShortStreets = f;
        }

        Package currentPackage;
        IList<PackDTO> packages = new List<PackDTO>();

        private void btnConfirmNumPackages_Click(object sender, EventArgs e)
        {
            FormsElaboration.SetDgvRows((int)nudPackages.Value, dgvSetPackages, packages);
            nudPackages.Value = 0;
        }

        private void dgvSetPackages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSetPackages.SelectedRows.Count < 1)
            {
                ClearEditGpb();
                return;
            }
            currentPackage = FormsElaboration.GetPackageByDgvRow(dgvSetPackages);
            BindEditGpb();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbVolume.Text, out int volume))
            {
                MessageBox.Show("Volume must be an int value");
                return;
            }
            if (!int.TryParse(txbWeight.Text, out int weight))
            {
                MessageBox.Show("Weight must be an int value");
                return;
            }
            try
            {
                currentPackage.Volume = volume;
                currentPackage.Weight = weight;
                currentPackage.Destination.Town = txbTown.Text;
                currentPackage.Destination.Province = txbProvince.Text;
                currentPackage.Destination.Number = txbNumber.Text;
                currentPackage.Destination.Road = txbRoad.Text;
                packages[packages.IndexOf(packages
                    .Where(x => x.Id == currentPackage.Id)
                    .Single())] = currentPackage.ToDTO();
                FormsElaboration.PopulateDgv(dgvSetPackages, packages);
                ClearEditGpb();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
        private void btnConfirmPackages_Click(object sender, EventArgs e)
        {
            var fMap = new Form2(fShortStreets) { TopLevel = false, TopMost = true };
            fMap.FormBorderStyle = FormBorderStyle.None;
            fShortStreets.pnlHome.Controls.Add(fMap);
            this.Hide();
            fMap.Show();
        }

        private void dgvSetPackages_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //    try
            //    {
            //        FormElaboration.ChangePackagePropertyFromDgv(currentPackage, dgvSetPackages);
            //    }
            //    catch(ArgumentException argEx)
            //    {
            //        MessageBox.Show(argEx.Message);
            //        return;
            //    }
        }

        private void dgvSetPackages_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //    if (dgvSetPackages.SelectedCells.Count < 1)
            //        return;
            //    currentPackage = FormElaboration.GetPackageByDgvCell(dgvSetPackages);
        }
        void BindEditGpb()
        {
            gpbEdit.Enabled = true;
            lblId.Text = $"Id: {currentPackage.Id}";
            txbVolume.Text = currentPackage.Volume.ToString();
            txbWeight.Text = currentPackage.Weight.ToString();
            txbTown.Text = currentPackage.Destination.Town;
            txbProvince.Text = currentPackage.Destination.Province;
            txbRoad.Text = currentPackage.Destination.Road;
            txbNumber.Text = currentPackage.Destination.Number;
        }
        void ClearEditGpb()
        {
            gpbEdit.Enabled = false;
            lblId.Text = "Id:";
            txbVolume.Text = string.Empty;
            txbWeight.Text = string.Empty;
            txbTown.Text = string.Empty;
            txbProvince.Text = string.Empty;
            txbRoad.Text = string.Empty;
            txbNumber.Text = string.Empty;
        }
    }
}
