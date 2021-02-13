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
        public static void ChangePackageProperties(Package currentPackage, DataGridView dgv)
        {
            switch (dgv.SelectedCells[0].OwningRow.Cells.IndexOf(dgv.SelectedCells[0]))
            {
                case 1:
                    {
                        if (!int.TryParse(dgv.SelectedCells[0].Value.ToString(), out int newVolume))
                            MessageBox.Show("Invalid int value inserted");
                        currentPackage.Volume = newVolume;
                        break;
                    }
                case 2:
                    {
                        if (!int.TryParse(dgv.SelectedCells[0].Value.ToString(), out int newWeight))
                            MessageBox.Show("Invalid int value inserted");
                        currentPackage.Weight = newWeight;
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            }
        }
    }
}
