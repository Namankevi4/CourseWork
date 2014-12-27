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
           Program.film.open();
           Main_Grid.DataSource = Program.film.catalog;
        }
                
        private void Main_Form_Load(object sender, EventArgs e)
        {
            Main_Grid.AutoGenerateColumns = true;
            Main_Grid.DataSource = Program.film.catalog;
            List<string> list_for_comboBox = new List<string>();
            foreach (DataGridViewColumn col in Main_Grid.Columns)
            {
                if (col.HeaderText != "Change")
                    list_for_comboBox.Add(col.HeaderText);
            }
            comboBoxChoise.DataSource = list_for_comboBox;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Add_Change_Form add = new Add_Change_Form();
            add.ShowDialog();
            Program.film.add(add.film);
            
            return;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rtb_Description.Text = Program.film.index(e.RowIndex).Description;
                pb_photo.Image = Program.film.index(e.RowIndex).Photo;
            }
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                Add_Change_Form change = new Add_Change_Form(Program.film.index(e.RowIndex));
                change.ShowDialog();
                Program.film.change(change.film, e.RowIndex);
                return;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            pb_photo.Image = null;
            rtb_Description.Text = null;

            foreach (DataGridViewRow row in Main_Grid.SelectedRows)
            {
                Program.film.delete(row.Index);
            }
            
        }
        private void Tbsearch_TextChanged(object sender, EventArgs e)
        {
            functions_of_cataloger.search(Main_Grid, comboBoxChoise, Tbsearch);
        }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
                var result = MessageBox.Show("Save?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.film.save();
                }
            
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Program.film.save();
            
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            new photo(pb_photo.Image).ShowDialog();
        }

        private void b_delete_all_Click(object sender, EventArgs e)
        {
            Program.film.catalog.Clear();
        }
    }
}
