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
    partial class FormRiderSpace : Form
    {
        FormShortStreets fShortStreets;
        public FormRiderSpace(FormShortStreets f)
        {
            InitializeComponent();
            fShortStreets = f;
        }

        Package currentPackage;
        IList<PackDTO> packages = new List<PackDTO>();
        static IApiCaller caller = new ApiCaller();
        CoordinateHelper helper = new CoordinateHelper(caller);

        private void btnConfirmNumPackages_Click(object sender, EventArgs e)
        {
            if ((int)nudPackages.Value < 1)
            {
                MessageBox.Show("Invalid packages quantity");
                return;
            }
            FormsElaboration.SetDgvRows((int)nudPackages.Value, dgvSetPackages, packages, true);
            AvoidToAdd();
            nudPackages.Value = 0;
            btnClearPackages.Enabled = true;
            btnConfirmPackages.Enabled = true;
        }

        private void dgvSetPackages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSetPackages.SelectedRows.Count != 1)
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
                currentPackage.Destination.Street = txbRoad.Text;
                helper.SetCoordinates(currentPackage.Destination);
                if(!CoordinatesRangeManager.IsInRange(fShortStreets.coordinatesRange, currentPackage.Destination.Coordinates))
                {
                    MessageBox.Show($"Packages coordinates are out of range ({fShortStreets.coordinatesRange})");
                    return;
                }
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
            fShortStreets.packages.Clear();
            foreach (var p in packages)
                fShortStreets.packages.Add(p.ToPackage());
            if (fShortStreets.currentAddress == null)
            {
                MessageBox.Show("Set your current position to access to the map (home)");
                return;
            }
            if (fShortStreets.packages.Where(x => x.IsValid == false).ToList().Count != 0)
            {
                MessageBox.Show("Convalid all packages to continue");
                return;
            }
            fShortStreets.ShowFormMap();
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
            txbRoad.Text = currentPackage.Destination.Street;
            txbNumber.Text = currentPackage.Destination.Number;
            btnConfirmPackages.Enabled = false;
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
            btnConfirmPackages.Enabled = true;
        }

        void AvoidToAdd()
        {
            btnConfirmNumPackages.Enabled = false;
            btnGetPresetPackages.Enabled = false;
        }
        private void btnClearPackages_Click(object sender, EventArgs e)
        {
            packages.Clear();
            FormsElaboration.PopulateDgv(dgvSetPackages, packages);
            btnConfirmNumPackages.Enabled = true;
            btnGetPresetPackages.Enabled = true;
            dgvSetPackages.RowHeadersVisible = true;
            btnConfirmPackages.Enabled = false;
            btnClearPackages.Enabled = false;
        }

        private void btnGetPresetPackages_Click(object sender, EventArgs e)
        {
            if ((int)nudPresetQuantity.Value < 1)
            {
                MessageBox.Show("Invalid packages quantity");
                return;
            }
            FormsElaboration.SetDgvRows((int)nudPresetQuantity.Value, dgvSetPackages, packages, false);
            AvoidToAdd();
            dgvSetPackages.RowHeadersVisible = false;
            nudPresetQuantity.Value = 0;
            btnClearPackages.Enabled = true;
            btnConfirmPackages.Enabled = true;
        }
    }
}
