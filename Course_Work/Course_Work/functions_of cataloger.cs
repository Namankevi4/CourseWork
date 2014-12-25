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
        static public void save(SaveFileDialog svd, SortableBindingList<Film> f)
        {
            FileStream stream = new FileStream(svd.FileName, FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                serializer.Serialize(stream, f);
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            stream.Close();
        }
        static public SortableBindingList<Film> open(OpenFileDialog svd)
        {
            SortableBindingList<Film> f = new SortableBindingList<Film>();
            FileStream stream = new FileStream(svd.FileName, FileMode.Open);
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                f = serializer.Deserialize(stream) as SortableBindingList<Film>;
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            stream.Close();
            return f;
        }
        static public void Add(SortableBindingList<Film> l, Film f)
        {
            if (f != null)
            l.Add(f);
        }
        static public void Change(SortableBindingList<Film> l, Film f, int i)
        {
            if (f != null)
            {
                Program.film.catalog[i] = f;
            }
        }
        public static void Delete(DataGridView dgv, SortableBindingList<Film> l)
        {
            foreach (DataGridViewRow obj in dgv.SelectedRows)
            {
                l.RemoveAt(obj.Index);
            }
        }
    }
}
