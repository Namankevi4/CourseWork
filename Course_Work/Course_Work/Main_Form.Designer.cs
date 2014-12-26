namespace Course_Work
{
    partial class Main_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Add = new System.Windows.Forms.Button();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.ll_Description = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.comboBoxChoise = new System.Windows.Forms.ComboBox();
            this.Tbsearch = new System.Windows.Forms.TextBox();
            this.ll_search_by = new System.Windows.Forms.Label();
            this.ll_what_searching = new System.Windows.Forms.Label();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.save_dialog = new System.Windows.Forms.SaveFileDialog();
            this.Main_Menu = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_dialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.Main_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Grid
            // 
            this.Main_Grid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Main_Grid.AllowUserToAddRows = false;
            this.Main_Grid.AllowUserToDeleteRows = false;
            this.Main_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Main_Grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Change});
            this.Main_Grid.Location = new System.Drawing.Point(13, 134);
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Main_Grid.RowHeadersVisible = false;
            this.Main_Grid.RowHeadersWidth = 45;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Main_Grid.RowTemplate.DividerHeight = 1;
            this.Main_Grid.RowTemplate.Height = 32;
            this.Main_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Main_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Main_Grid.Size = new System.Drawing.Size(627, 402);
            this.Main_Grid.TabIndex = 0;
            this.Main_Grid.VirtualMode = true;
            this.Main_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Change
            // 
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Text = "Change";
            this.Change.UseColumnTextForButtonValue = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(686, 171);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 57);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Description.Location = new System.Drawing.Point(859, 360);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.ReadOnly = true;
            this.rtb_Description.Size = new System.Drawing.Size(306, 171);
            this.rtb_Description.TabIndex = 2;
            this.rtb_Description.Text = "";
            // 
            // ll_Description
            // 
            this.ll_Description.AutoSize = true;
            this.ll_Description.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_Description.Location = new System.Drawing.Point(855, 337);
            this.ll_Description.Name = "ll_Description";
            this.ll_Description.Size = new System.Drawing.Size(88, 20);
            this.ll_Description.TabIndex = 3;
            this.ll_Description.Text = "Description:";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(686, 280);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 58);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // comboBoxChoise
            // 
            this.comboBoxChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoise.FormattingEnabled = true;
            this.comboBoxChoise.Location = new System.Drawing.Point(13, 89);
            this.comboBoxChoise.Name = "comboBoxChoise";
            this.comboBoxChoise.Size = new System.Drawing.Size(148, 21);
            this.comboBoxChoise.TabIndex = 6;
            this.comboBoxChoise.SelectedIndexChanged += new System.EventHandler(this.Tbsearch_TextChanged);
            // 
            // Tbsearch
            // 
            this.Tbsearch.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbsearch.Location = new System.Drawing.Point(230, 90);
            this.Tbsearch.Name = "Tbsearch";
            this.Tbsearch.Size = new System.Drawing.Size(228, 24);
            this.Tbsearch.TabIndex = 7;
            this.Tbsearch.TextChanged += new System.EventHandler(this.Tbsearch_TextChanged);
            // 
            // ll_search_by
            // 
            this.ll_search_by.AutoSize = true;
            this.ll_search_by.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_search_by.Location = new System.Drawing.Point(12, 68);
            this.ll_search_by.Name = "ll_search_by";
            this.ll_search_by.Size = new System.Drawing.Size(76, 20);
            this.ll_search_by.TabIndex = 8;
            this.ll_search_by.Text = "Search by:";
            // 
            // ll_what_searching
            // 
            this.ll_what_searching.AutoSize = true;
            this.ll_what_searching.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_what_searching.Location = new System.Drawing.Point(226, 67);
            this.ll_what_searching.Name = "ll_what_searching";
            this.ll_what_searching.Size = new System.Drawing.Size(115, 20);
            this.ll_what_searching.TabIndex = 9;
            this.ll_what_searching.Text = "What searching:";
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.SystemColors.Window;
            this.pb_photo.Location = new System.Drawing.Point(859, 30);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(255, 274);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 10;
            this.pb_photo.TabStop = false;
            this.pb_photo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // save_dialog
            // 
            this.save_dialog.FileName = "catalog";
            this.save_dialog.Filter = "Файлы DAT (*.dat) | *.dat";
            // 
            // Main_Menu
            // 
            this.Main_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.Main_Menu.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu.Name = "Main_Menu";
            this.Main_Menu.Size = new System.Drawing.Size(1237, 27);
            this.Main_Menu.TabIndex = 12;
            this.Main_Menu.Text = "Main_Menu";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 12F);
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.открытьToolStripMenuItem.Text = "Open";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 12F);
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.сохранитьToolStripMenuItem.Text = "Save";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // open_dialog
            // 
            this.open_dialog.FileName = "cataloger";
            this.open_dialog.Filter = "Файлы DAT (*.dat) | *.dat";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1237, 569);
            this.Controls.Add(this.pb_photo);
            this.Controls.Add(this.ll_what_searching);
            this.Controls.Add(this.ll_search_by);
            this.Controls.Add(this.Tbsearch);
            this.Controls.Add(this.comboBoxChoise);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ll_Description);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.Main_Menu);
            this.Name = "Main_Form";
            this.Text = "Cataloger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.Main_Menu.ResumeLayout(false);
            this.Main_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label ll_Description;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox comboBoxChoise;
        private System.Windows.Forms.TextBox Tbsearch;
        private System.Windows.Forms.Label ll_search_by;
        private System.Windows.Forms.Label ll_what_searching;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.SaveFileDialog save_dialog;
        private System.Windows.Forms.MenuStrip Main_Menu;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog open_dialog;
    }
}

