namespace Course_Work
{
    partial class Add_Change_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Change_Form));
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.tb_Producer = new System.Windows.Forms.TextBox();
            this.bn_Add_to_catalog = new System.Windows.Forms.Button();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ll_Description = new System.Windows.Forms.Label();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bn_search = new System.Windows.Forms.Button();
            this.tb_path_of_image = new System.Windows.Forms.TextBox();
            this.open_image_dialog = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.cb_Format = new System.Windows.Forms.ComboBox();
            this.ll_Format = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(33, 55);
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(209, 20);
            this.tb_Text.TabIndex = 0;
            // 
            // tb_Year
            // 
            this.tb_Year.Location = new System.Drawing.Point(33, 108);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(209, 20);
            this.tb_Year.TabIndex = 1;
            // 
            // tb_Producer
            // 
            this.tb_Producer.Location = new System.Drawing.Point(33, 210);
            this.tb_Producer.Name = "tb_Producer";
            this.tb_Producer.Size = new System.Drawing.Size(209, 20);
            this.tb_Producer.TabIndex = 3;
            // 
            // bn_Add_to_catalog
            // 
            this.bn_Add_to_catalog.Location = new System.Drawing.Point(346, 297);
            this.bn_Add_to_catalog.Name = "bn_Add_to_catalog";
            this.bn_Add_to_catalog.Size = new System.Drawing.Size(135, 45);
            this.bn_Add_to_catalog.TabIndex = 4;
            this.bn_Add_to_catalog.Text = "Add to catalog";
            this.bn_Add_to_catalog.UseVisualStyleBackColor = true;
            this.bn_Add_to_catalog.Click += new System.EventHandler(this.Add_to_catalog_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(299, 75);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(245, 154);
            this.rtb_Description.TabIndex = 5;
            this.rtb_Description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(30, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Producer:";
            // 
            // ll_Description
            // 
            this.ll_Description.AutoSize = true;
            this.ll_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ll_Description.Location = new System.Drawing.Point(296, 54);
            this.ll_Description.Name = "ll_Description";
            this.ll_Description.Size = new System.Drawing.Size(87, 18);
            this.ll_Description.TabIndex = 10;
            this.ll_Description.Text = "Description:";
            // 
            // cb_Genre
            // 
            this.cb_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Melodrama",
            "Musical",
            "Science fiction",
            "Thriller",
            "Western"});
            this.cb_Genre.Location = new System.Drawing.Point(33, 158);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(209, 21);
            this.cb_Genre.Sorted = true;
            this.cb_Genre.TabIndex = 11;
            // 
            // tb_Time
            // 
            this.tb_Time.Location = new System.Drawing.Point(33, 256);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(209, 20);
            this.tb_Time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time:";
            // 
            // bn_search
            // 
            this.bn_search.Location = new System.Drawing.Point(787, 297);
            this.bn_search.Name = "bn_search";
            this.bn_search.Size = new System.Drawing.Size(98, 45);
            this.bn_search.TabIndex = 14;
            this.bn_search.Text = "Search\r\n";
            this.bn_search.UseVisualStyleBackColor = true;
            this.bn_search.Click += new System.EventHandler(this.bn_search_Click);
            // 
            // tb_path_of_image
            // 
            this.tb_path_of_image.Location = new System.Drawing.Point(588, 318);
            this.tb_path_of_image.Name = "tb_path_of_image";
            this.tb_path_of_image.ReadOnly = true;
            this.tb_path_of_image.Size = new System.Drawing.Size(141, 20);
            this.tb_path_of_image.TabIndex = 15;
            // 
            // open_image_dialog
            // 
            this.open_image_dialog.FileName = "image";
            this.open_image_dialog.Filter = "Изображения  (*.jpeg, *.jpg) | *.jpeg,; *.jpg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(585, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "The path of image:";
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.SystemColors.Window;
            this.pb_Image.Location = new System.Drawing.Point(664, 34);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(221, 229);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 17;
            this.pb_Image.TabStop = false;
            // 
            // cb_Format
            // 
            this.cb_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Format.FormattingEnabled = true;
            this.cb_Format.Items.AddRange(new object[] {
            "AVI",
            "OGG ",
            "MKV",
            "MP4",
            "Quick Time",
            "DivX",
            "Xvid "});
            this.cb_Format.Location = new System.Drawing.Point(33, 298);
            this.cb_Format.Name = "cb_Format";
            this.cb_Format.Size = new System.Drawing.Size(209, 21);
            this.cb_Format.TabIndex = 18;
            // 
            // ll_Format
            // 
            this.ll_Format.AutoSize = true;
            this.ll_Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ll_Format.Location = new System.Drawing.Point(30, 277);
            this.ll_Format.Name = "ll_Format";
            this.ll_Format.Size = new System.Drawing.Size(60, 18);
            this.ll_Format.TabIndex = 19;
            this.ll_Format.Text = "Format:";
            // 
            // Add_Change_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(947, 395);
            this.Controls.Add(this.ll_Format);
            this.Controls.Add(this.cb_Format);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_path_of_image);
            this.Controls.Add(this.bn_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Time);
            this.Controls.Add(this.cb_Genre);
            this.Controls.Add(this.ll_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.bn_Add_to_catalog);
            this.Controls.Add(this.tb_Producer);
            this.Controls.Add(this.tb_Year);
            this.Controls.Add(this.tb_Text);
            this.Name = "Add_Change_Form";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Change_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.TextBox tb_Year;
        private System.Windows.Forms.TextBox tb_Producer;
        private System.Windows.Forms.Button bn_Add_to_catalog;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ll_Description;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bn_search;
        private System.Windows.Forms.TextBox tb_path_of_image;
        private System.Windows.Forms.OpenFileDialog open_image_dialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.ComboBox cb_Format;
        private System.Windows.Forms.Label ll_Format;
    }
}