using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produktverwaltung.Controllers
{
    /// <summary>Controller class <c>WinFormTools</c>
    /// allows selection of lines in products table.</summary>
    public static class WinFormTools
    {
        internal static void GridViewZeileAuswaehlen(DataGridView dgw, int spaltenNr, string id)
        {
            dgw.ClearSelection();
            for (int zeileNr = 0; zeileNr < dgw.Rows.Count; zeileNr++)
            {
                DataGridViewRow akuelleZeile = dgw.Rows[zeileNr];
                if (akuelleZeile.Cells[spaltenNr].Value.ToString() == id)
                {
                    akuelleZeile.Selected = true;
                    akuelleZeile.Cells[0].Selected = true;
                    dgw.CurrentCell = dgw[0, zeileNr]; // Set Fokus
                }

            }
        }
    }
}
