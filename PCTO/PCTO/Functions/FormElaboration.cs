using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO
{
    class FormElaboration
    {
        /// <summary>
        /// Modifies a package's property with the content of DataGridView cell
        /// </summary>
        /// <param name="currentPackage"></param>
        /// <param name="dgv"></param>
        public static void ChangePackagePropertyFromDgv(Package currentPackage, DataGridView dgv)
        {
            string value;
            try
            {
                value = dgv.SelectedCells[0].Value.ToString();
            }
            catch(NullReferenceException nullRefEx)
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
                        catch(ArgumentException argEx)
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
                        catch(ArgumentException argEx)
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
        /// Identifies the package by the DataGridView selected cell
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static Package GetPackageByDgvCell(DataGridView dgv)
        {
            return Package.GetPackageById((int)dgv.SelectedCells[0].OwningRow.Cells[0].Value);
        }

        /// <summary>
        /// Identifies the package by the DataGridView selected row
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static Package GetPackageByDgvRow(DataGridView dgv)
        {
            return Package.GetPackageById((int)GetIdFromDgvRow(dgv));
        }

        /// <summary>
        /// Set as many empty PackDTO in the dataGridView as the int paramenter
        /// </summary>
        /// <param name="n"></param>
        /// <param name="dgv"></param>
        public static void SetDgvRows(int n, DataGridView dgv, IList<PackDTO> packages)
        {
            if (n < 1)
            { 
                MessageBox.Show("Invalid packages quantity");
                return;
            }
            for (int x = 0; x < n; x++)
                packages.Add(new Package(new Place("", "", "", ""), 0, 0).ToDTO());
            PopulateDgv(dgv, packages);
            dgv.Columns[0].ReadOnly = true;
        }

        /// <summary>
        /// Set labelId's text
        /// </summary>
        /// <param name="l"></param>
        /// <param name="dgv"></param>
        public static object GetIdFromDgvRow(DataGridView dgv)
        {
            return dgv.SelectedRows[0].Cells[0].Value;
        }

        /// <summary>
        /// Set DataGridView's DataSource by a DTO list
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="packages"></param>
        public static void PopulateDgv(DataGridView dgv, IList<PackDTO> packages)
        {
            dgv.DataSource = null;
            dgv.DataSource = packages;
        }
    }
}
