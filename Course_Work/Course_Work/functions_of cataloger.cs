using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Drawing.Imaging;
using System.Drawing;

namespace Course_Work
{
    static class functions_of_cataloger
    {
        static public void search(DataGridView dgv, ComboBox cb, TextBox t)
        {
            string value = t.Text.Trim();
            dgv.CurrentCell = null;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[cb.Text].Value.ToString().ToLower().Contains(value) || t.Text.Length == 0)
                { dgv.Rows[i].Visible = true; }
                else dgv.Rows[i].Visible = false;
            }
        }
    }
}
