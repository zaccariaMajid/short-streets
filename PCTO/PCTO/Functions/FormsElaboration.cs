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
                            packages.Add(new Package(new Address("", "", "", ""), default, 0, 0).ToDTO());
                        break;
                    }
                case false:
                    {
                        try
                        {
                            var presetPackages = Package.GetPresetDTO(n);
                            foreach(var p in presetPackages)
                            packages.Add(p);
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

        /// <summary>
        /// Returns an address that is in a ComboBox
        /// </summary>
        /// <param name="cmb">ComboBox to analyze</param>
        /// <param name="list">List that contains the wanted address</param>
        /// <returns></returns>
        public static Address GetAddressFromCmb(ComboBox cmb, IList<Address> list)
        {
            return list.Single(x => x.ToString() == cmb.SelectedItem.ToString());
        }
    }
}
