using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
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
            XmlSerializer serializer = new XmlSerializer(typeof(SortableBindingList<Film>));
            serializer.Serialize(stream, f);
            stream.Close();

            if (!Directory.Exists("Image"))
            {
                Directory.CreateDirectory("Image");
            }
            foreach (Film obj in f)
            {
                obj.Photo.Save(@"Image\" + obj.title + ".jpeg", ImageFormat.Jpeg);
            }
        }
        static public SortableBindingList<Film> open(OpenFileDialog svd)
        {
            SortableBindingList<Film> f = new SortableBindingList<Film>();
            FileStream stream = new FileStream(svd.FileName, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(SortableBindingList<Film>));
            try
            {
                f = serializer.Deserialize(stream) as SortableBindingList<Film>;
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            stream.Close();
            foreach (Film fm in f)
            {
        
                    fm.Photo = Image.FromFile(@"Image\" + fm.title + ".jpeg");
        
            }
            return f;
        }
    
        
    }
}
