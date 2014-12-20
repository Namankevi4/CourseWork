using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Course_Work
{
    public partial class Change_Form : Form
    {
        public Change_Form(Film obj)
        {
            InitializeComponent();
            textBox1.Text = obj.title.ToString();
            textBox2.Text = obj.year.ToString();
            textBox3.Text = obj.time.ToString();
            comboBox1.Text = obj.genre.ToString();
            textBox4.Text = obj.producer.ToString();
            richTextBox1.Text = obj.description.ToString();
        }
        public Film film;
        public Change_Form()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            bool flag= true;
            try
            {
                foreach (Control obj in this.Controls)
                {
                    if ((obj.GetType() == typeof(TextBox) || obj.GetType() == typeof(RichTextBox) || obj.GetType() == typeof(ComboBox)) && obj.Text.Length ==0)
                    {
                       flag = false;
                    }
                }
                if (flag ==true)
                    film = Program.film.add(textBox1.Text, Convert.ToInt16(textBox2.Text), comboBox1.Text, textBox4.Text, richTextBox1.Text, Convert.ToInt32(textBox3.Text), Image.FromFile(textBox5.Text) );
                else
                { MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            catch 
            {
                MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
                this.Close();
        }
        private void Change_Form_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            textBox5.Text = openFileDialog1.FileName;
        }
    }
}
