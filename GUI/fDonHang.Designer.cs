namespace GUI
{
    partial class fDonHang
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TaoDon = new ReaLTaiizor.Controls.MaterialButton();
            this.textBox_TimKiem = new ReaLTaiizor.Controls.CyberTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new ReaLTaiizor.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.data_DSDonHang = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Remove_bg_ai_1729599973417;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 109);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TaoDon
            // 
            this.btn_TaoDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TaoDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_TaoDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TaoDon.Depth = 0;
            this.btn_TaoDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TaoDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TaoDon.HighEmphasis = true;
            this.btn_TaoDon.Icon = null;
            this.btn_TaoDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TaoDon.Location = new System.Drawing.Point(22, 0);
            this.btn_TaoDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_TaoDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TaoDon.Name = "btn_TaoDon";
            this.btn_TaoDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TaoDon.Size = new System.Drawing.Size(149, 44);
            this.btn_TaoDon.TabIndex = 52;
            this.btn_TaoDon.Text = "Tạo đơn";
            this.btn_TaoDon.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TaoDon.UseAccentColor = true;
            this.btn_TaoDon.UseVisualStyleBackColor = true;
            this.btn_TaoDon.Click += new System.EventHandler(this.btn_TaoDon_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Alpha = 20;
            this.textBox_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBox_TimKiem.Background_WidthPen = 3F;
            this.textBox_TimKiem.BackgroundPen = true;
            this.textBox_TimKiem.ColorBackground = System.Drawing.Color.White;
            this.textBox_TimKiem.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TimKiem.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_TimKiem.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.textBox_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBox_TimKiem.Lighting = false;
            this.textBox_TimKiem.LinearGradientPen = false;
            this.textBox_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.PenWidth = 15;
            this.textBox_TimKiem.RGB = false;
            this.textBox_TimKiem.Rounding = true;
            this.textBox_TimKiem.RoundingInt = 60;
            this.textBox_TimKiem.Size = new System.Drawing.Size(503, 44);
            this.textBox_TimKiem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_TimKiem.TabIndex = 49;
            this.textBox_TimKiem.Tag = "Cyber";
            this.textBox_TimKiem.TextButton = "";
            this.textBox_TimKiem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_TimKiem.Timer_RGB = 300;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TaoDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(805, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.panel2.Size = new System.Drawing.Size(193, 44);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(210, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 44);
            this.panel1.TabIndex = 36;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(503, 0);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(18, 6, 4, 6);
            this.btn_TimKiem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TimKiem.Size = new System.Drawing.Size(86, 44);
            this.btn_TimKiem.TabIndex = 53;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TimKiem.UseAccentColor = false;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.aloneComboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1010, 64);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // aloneComboBox1
            // 
            this.aloneComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aloneComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aloneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.aloneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aloneComboBox1.EnabledCalc = true;
            this.aloneComboBox1.FormattingEnabled = true;
            this.aloneComboBox1.ItemHeight = 20;
            this.aloneComboBox1.Location = new System.Drawing.Point(12, 10);
            this.aloneComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aloneComboBox1.Name = "aloneComboBox1";
            this.aloneComboBox1.Size = new System.Drawing.Size(192, 26);
            this.aloneComboBox1.TabIndex = 42;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 113);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(207, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 113);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_DSDonHang
            // 
            this.data_DSDonHang.AllowUserToResizeRows = false;
            this.data_DSDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_DSDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_DSDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_DSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_DSDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_DSDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_DSDonHang.EnableHeadersVisualStyles = false;
            this.data_DSDonHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_DSDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_DSDonHang.Location = new System.Drawing.Point(0, 177);
            this.data_DSDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.data_DSDonHang.Name = "data_DSDonHang";
            this.data_DSDonHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_DSDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_DSDonHang.RowHeadersWidth = 62;
            this.data_DSDonHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_DSDonHang.RowTemplate.Height = 28;
            this.data_DSDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSDonHang.Size = new System.Drawing.Size(1010, 363);
            this.data_DSDonHang.TabIndex = 38;
            this.data_DSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSDonHang_CellClick);
            this.data_DSDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSDonHang_CellContentClick);
            // 
            // fDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1010, 540);
            this.Controls.Add(this.data_DSDonHang);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDonHang";
            this.Text = "Danh sách ";
            this.Load += new System.EventHandler(this.fDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btn_TaoDon;
        private ReaLTaiizor.Controls.CyberTextBox textBox_TimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private ReaLTaiizor.Controls.PoisonDataGridView data_DSDonHang;
        private ReaLTaiizor.Controls.MaterialButton btn_TimKiem;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
    }
}