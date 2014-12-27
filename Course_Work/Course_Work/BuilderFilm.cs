using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;


namespace Course_Work
{
    class BuilderFilm
    {
        public SortableBindingList<Film> catalog = new SortableBindingList<Film>();
        public void add(Film f)
        {
            if (f!=null)
            catalog.Add(f);
        }
        public void change(Film f, int index)
        {
            if(f!=null)
            catalog[index] = f;
        }
        public Film index(int index)
        {
            return catalog[index];
        }
        public void delete(int index)
        {
            catalog.RemoveAt(index);
        }
        public void save()
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Файлы DAT(*.dat) | *.dat;";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(svd.FileName, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    serializer.Serialize(stream, catalog);
                }
                catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                stream.Close();
            }
            
        }
        public void open()
        {
            OpenFileDialog svd = new OpenFileDialog();
            svd.Filter = "Файлы DAT(*.dat) | *.dat;";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(svd.FileName, FileMode.Open);
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    catalog = serializer.Deserialize(stream) as SortableBindingList<Film>;
                }
                catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                stream.Close();
                
            }
            
        }
    } 
}
