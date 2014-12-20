using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

using System.Drawing.Imaging;
namespace Course_Work
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(SortableBindingList<Film>));
                Program.film.catalog = serializer.Deserialize(stream) as SortableBindingList<Film>;
                stream.Close();
                foreach (Film f in Program.film.catalog)
                {
                    try
                    {
                        f.Photo = Image.FromFile(@"Image\" + f.title + ".jpeg");
                    }
                    catch { };
                }
                dataGridView1.DataSource = Program.film.catalog;
            }
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Program.film.catalog;
            List<string> list_for_comboBox = new List<string>();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.HeaderText != "Change")
                    list_for_comboBox.Add(col.HeaderText);
            }
            comboBoxChoise.DataSource = list_for_comboBox;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Change_Form add = new Change_Form();
            add.ShowDialog();
            if (add.film != null)
            Program.film.catalog.Add(add.film);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                richTextBox1.Text = Program.film.catalog[e.RowIndex].description;
                pictureBox1.Image = Program.film.catalog[e.RowIndex].Photo;
            }
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                Change_Form change = new Change_Form(Program.film.catalog[e.RowIndex]);
                change.ShowDialog();
                if (change.film != null)
                {
                    Program.film.catalog[e.RowIndex] = change.film;
                }
                return;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            foreach (DataGridViewRow obj in dataGridView1.SelectedRows)
            {
                Program.film.catalog.RemoveAt(obj.Index);
            }
            
        }
        private void Tbsearch_TextChanged(object sender, EventArgs e)
        {
            string value = Tbsearch.Text.Trim();
            dataGridView1.CurrentCell = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[comboBoxChoise.Text].Value.ToString().ToLower().Contains(value) || Tbsearch.Text.Length == 0)
                { dataGridView1.Rows[i].Visible = true; }
                else dataGridView1.Rows[i].Visible = false;
            }
        }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Save?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
            }       
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(this.saveFileDialog1.FileName, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(SortableBindingList<Film>));//ошибка
                serializer.Serialize(stream, Program.film.catalog);
                stream.Close();

                if (Directory.Exists("Image"))
                {
                    Directory.Delete("Image", true);
                }
                Directory.CreateDirectory("Image");

                foreach (Film obj in Program.film.catalog)
                {
                    obj.Photo.Save(@"Image\" + obj.title + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            new photo(pictureBox1.Image).ShowDialog();
        }
    }
}
