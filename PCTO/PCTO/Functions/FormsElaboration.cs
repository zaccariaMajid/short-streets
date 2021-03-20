using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO
{
    class FormsElaboration
    {
        /// <summary>
        /// Modifies a package's property with the content of DataGridView cell
        /// </summary>
        public static void ChangePackagePropertyFromDgv(Package currentPackage, DataGridView dgv)
        {
            string value;
            try
            {
                value = dgv.SelectedCells[0].Value.ToString();
            }
            catch (NullReferenceException nullRefEx)
            {
                MessageBox.Show(nullRefEx.Message);
                return;
            }
            switch (dgv.SelectedCells[0].OwningRow.Cells.IndexOf(dgv.SelectedCells[0]))
            {
                case 1:
                    {
                        if (!int.TryParse(value, out int newVolume))
                            MessageBox.Show("Invalid int value inserted");
                        try
                        {
                            currentPackage.Volume = newVolume;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
                case 2:
                    {
                        if (!int.TryParse(value, out int newWeight))
                            MessageBox.Show("Invalid int value inserted");
                        try
                        {
                            currentPackage.Weight = newWeight;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            currentPackage.Destination.Number = value;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            currentPackage.Destination.Road = value;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
                case 5:
                    {
                        try
                        {
                            currentPackage.Destination.Town = value;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            currentPackage.Destination.Province = value;
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Identifies the package by the DataGridView selected row
        /// </summary>
        public static Package GetPackageByDgvRow(DataGridView dgv)
        {
            return Package.GetPackageById(GetIdFromDgvRow(dgv).ToString());
        }


        /// <summary>
        /// Set as many empty PackDTO in the dataGridView as the int paramenter
        /// </summary>
        /// <param name="NewPackages">True to create new packages; False to import preset packages</param>
        public static void SetDgvRows(int n, DataGridView dgv, IList<PackDTO> packages, bool NewPackages)
        {
            if (n < 1)
            {
                MessageBox.Show("Invalid packages quantity");
                return;
            }
            switch (NewPackages)
            {
                case true:
                    {
                        for (int x = 0; x < n; x++)
                            packages.Add(new Package(new Address("", "", "", ""), 0, 0).ToDTO());
                        break;
                    }
                case false:
                    {
                        try
                        {
                            packages = Package.GetPresetDTO(n);
                        }
                        catch (ArgumentException argEx)
                        {
                            MessageBox.Show(argEx.Message);
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Generic error: {ex.Message}");
                            return;
                        }
                        break;
                    }
            }
            PopulateDgv(dgv, packages);
            dgv.Columns[0].ReadOnly = true;
        }

        /// <summary>
        /// Returns package's Id by dataGridView and cell
        /// </summary>
        public static object GetIdFromDgvRow(DataGridView dgv)
        {
            return dgv.SelectedRows[0].Cells[0].Value;
        }

        /// <summary>
        /// Set DataGridView's DataSource by a DTO list
        /// </summary>
        public static void PopulateDgv(DataGridView dgv, IList<PackDTO> packages)
        {
            dgv.DataSource = null;
            dgv.DataSource = packages;
        }
    }
}
