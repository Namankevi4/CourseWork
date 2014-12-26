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
    public partial class  Add_Change_Form : Form
    {
        public Film film;
        public Add_Change_Form(Film obj)
        {
            InitializeComponent();
            this.Text = "Change";
            tb_path_of_image.Text = "Path...";
            tb_Text.Text = obj.Title.ToString();
            tb_Year.Text = obj.Year.ToString();
            tb_Time.Text = obj.Time.ToString();
            cb_Genre.Text = obj.Genre.ToString();
            tb_Producer.Text = obj.Producer.ToString();
            rtb_Description.Text = obj.Description.ToString();
            cb_Format.Text = obj.Format.ToString();
            
            pb_Image.Image = obj.Photo;
            
        }
        public Add_Change_Form()
        {
            InitializeComponent();
        }
        
        private void bn_search_Click(object sender, EventArgs e)
        {
            if (open_image_dialog.ShowDialog() == DialogResult.OK)
            {
                tb_path_of_image.Text = open_image_dialog.FileName;
            }
            try
            {
                pb_Image.Image = Image.FromFile(tb_path_of_image.Text);
            }
            catch { }
        }
        private void Add_to_catalog_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control obj in this.Controls)
                {
                    if ((obj.GetType() == typeof(TextBox) || obj.GetType() == typeof(RichTextBox) || obj.GetType() == typeof(ComboBox)) && obj.Text.Length == 0)
                    {
                        throw new Exception();
                    }
                }
                 film = new Film(tb_Text.Text, Convert.ToInt16(tb_Year.Text), cb_Genre.Text, tb_Producer.Text, rtb_Description.Text, Convert.ToInt32(tb_Time.Text), pb_Image.Image, cb_Format.Text);
                
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                else
                    MessageBox.Show("Not all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            this.Close();
        }

        private void Add_Change_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
