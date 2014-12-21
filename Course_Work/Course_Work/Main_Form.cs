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
                Program.film.catalog = functions_of_cataloger.open(openFileDialog1);
                
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
            functions_of_cataloger.search(dataGridView1, comboBoxChoise, Tbsearch);
        }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
                var result = MessageBox.Show("Save?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        functions_of_cataloger.save(saveFileDialog1, Program.film.catalog);
                    }
                }
            
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                functions_of_cataloger.save(saveFileDialog1, Program.film.catalog);
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            new photo(pictureBox1.Image).ShowDialog();
        }
    }
}
