namespace GUI
{
    partial class fSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_DSSanPham = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btn_ThemSanPham = new ReaLTaiizor.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_timkiem = new ReaLTaiizor.Controls.HopeTextBox();
            this.btn_TimKiem = new ReaLTaiizor.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_DSSanPham
            // 
            this.data_DSSanPham.AllowUserToResizeRows = false;
            this.data_DSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_DSSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_DSSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_DSSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_DSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_DSSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_DSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_DSSanPham.EnableHeadersVisualStyles = false;
            this.data_DSSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_DSSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSSanPham.Location = new System.Drawing.Point(0, 174);
            this.data_DSSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_DSSanPham.Name = "data_DSSanPham";
            this.data_DSSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_DSSanPham.RowHeadersWidth = 62;
            this.data_DSSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_DSSanPham.RowTemplate.Height = 28;
            this.data_DSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSSanPham.Size = new System.Drawing.Size(974, 490);
            this.data_DSSanPham.TabIndex = 41;
            this.data_DSSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSSanPham_CellContentClick);
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ThemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ThemSanPham.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ThemSanPham.Depth = 0;
            this.btn_ThemSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemSanPham.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ThemSanPham.HighEmphasis = true;
            this.btn_ThemSanPham.Icon = null;
            this.btn_ThemSanPham.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_ThemSanPham.Location = new System.Drawing.Point(25, 0);
            this.btn_ThemSanPham.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btn_ThemSanPham.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ThemSanPham.Size = new System.Drawing.Size(136, 48);
            this.btn_ThemSanPham.TabIndex = 52;
            this.btn_ThemSanPham.Text = "Thêm";
            this.btn_ThemSanPham.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ThemSanPham.UseAccentColor = true;
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ThemSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(775, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel2.Size = new System.Drawing.Size(186, 48);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_timkiem);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 48);
            this.panel1.TabIndex = 36;
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_timkiem.BackColor = System.Drawing.Color.Snow;
            this.textBox_timkiem.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_timkiem.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_timkiem.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_timkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_timkiem.ForeColor = System.Drawing.Color.Black;
            this.textBox_timkiem.Hint = "";
            this.textBox_timkiem.Location = new System.Drawing.Point(21, -1);
            this.textBox_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_timkiem.MaxLength = 128;
            this.textBox_timkiem.Multiline = false;
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.PasswordChar = '\0';
            this.textBox_timkiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_timkiem.SelectedText = "";
            this.textBox_timkiem.SelectionLength = 0;
            this.textBox_timkiem.SelectionStart = 0;
            this.textBox_timkiem.Size = new System.Drawing.Size(408, 44);
            this.textBox_timkiem.TabIndex = 54;
            this.textBox_timkiem.TabStop = false;
            this.textBox_timkiem.UseSystemPasswordChar = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TimKiem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TimKiem.Depth = 0;
            this.btn_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.HighEmphasis = true;
            this.btn_TimKiem.Icon = null;
            this.btn_TimKiem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TimKiem.Location = new System.Drawing.Point(480, 0);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(20, 8, 4, 8);
            this.btn_TimKiem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TimKiem.Size = new System.Drawing.Size(86, 48);
            this.btn_TimKiem.TabIndex = 53;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TimKiem.UseAccentColor = false;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 72);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(13, 14);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(183, 28);
            this.comboBox.TabIndex = 58;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12712F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.87288F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 102);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 102);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Remove_bg_ai_1729599973417;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(974, 664);
            this.Controls.Add(this.data_DSSanPham);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fSanPham";
            this.Text = "fSanPham";
            this.Load += new System.EventHandler(this.fSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView data_DSSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btn_ThemSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btn_TimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private ReaLTaiizor.Controls.HopeTextBox textBox_timkiem;
        private System.Windows.Forms.ComboBox comboBox;
    }
}