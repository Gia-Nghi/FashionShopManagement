namespace GUI
{
    partial class fChiTietSanPham
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picture_SanPham = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.textBox_SL = new System.Windows.Forms.TextBox();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.buttonXoa = new ReaLTaiizor.Controls.Button();
            this.buttonChinhSua = new ReaLTaiizor.Controls.Button();
            this.label_TenSanPham = new System.Windows.Forms.Label();
            this.comboBox_LSP = new System.Windows.Forms.ComboBox();
            this.comboBox_NCC = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.08761F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.91239F));
            this.tableLayoutPanel1.Controls.Add(this.picture_SanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picture_SanPham
            // 
            this.picture_SanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_SanPham.BackgroundImage = global::GUI.Properties.Resources.ao_len_1;
            this.picture_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_SanPham.Location = new System.Drawing.Point(3, 2);
            this.picture_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_SanPham.Name = "picture_SanPham";
            this.picture_SanPham.Size = new System.Drawing.Size(401, 620);
            this.picture_SanPham.TabIndex = 0;
            this.picture_SanPham.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.comboBox_NCC);
            this.panel1.Controls.Add(this.comboBox_LSP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Size);
            this.panel1.Controls.Add(this.textBox_SL);
            this.panel1.Controls.Add(this.textBox_Gia);
            this.panel1.Controls.Add(this.textBox_Ten);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonChinhSua);
            this.panel1.Controls.Add(this.label_TenSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(410, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 620);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kích cỡ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giá cả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(238, 220);
            this.textBox_Size.Multiline = true;
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(294, 40);
            this.textBox_Size.TabIndex = 12;
            // 
            // textBox_SL
            // 
            this.textBox_SL.Location = new System.Drawing.Point(238, 280);
            this.textBox_SL.Multiline = true;
            this.textBox_SL.Name = "textBox_SL";
            this.textBox_SL.Size = new System.Drawing.Size(294, 40);
            this.textBox_SL.TabIndex = 11;
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(238, 160);
            this.textBox_Gia.Multiline = true;
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(294, 40);
            this.textBox_Gia.TabIndex = 9;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(238, 100);
            this.textBox_Ten.Multiline = true;
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(294, 40);
            this.textBox_Ten.TabIndex = 8;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.MistyRose;
            this.buttonXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoa.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonXoa.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonXoa.Image = null;
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.InactiveColor = System.Drawing.Color.Red;
            this.buttonXoa.Location = new System.Drawing.Point(344, 520);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonXoa.Size = new System.Drawing.Size(188, 59);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa sản phẩm";
            this.buttonXoa.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChinhSua.BorderColor = System.Drawing.Color.Blue;
            this.buttonChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChinhSua.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonChinhSua.EnteredColor = System.Drawing.Color.Blue;
            this.buttonChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonChinhSua.Image = null;
            this.buttonChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChinhSua.InactiveColor = System.Drawing.Color.Blue;
            this.buttonChinhSua.Location = new System.Drawing.Point(53, 520);
            this.buttonChinhSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonChinhSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonChinhSua.Size = new System.Drawing.Size(188, 59);
            this.buttonChinhSua.TabIndex = 5;
            this.buttonChinhSua.Text = "Chỉnh sửa";
            this.buttonChinhSua.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // label_TenSanPham
            // 
            this.label_TenSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_TenSanPham.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_TenSanPham.Location = new System.Drawing.Point(0, 0);
            this.label_TenSanPham.Name = "label_TenSanPham";
            this.label_TenSanPham.Size = new System.Drawing.Size(580, 79);
            this.label_TenSanPham.TabIndex = 0;
            this.label_TenSanPham.Text = "Áo len";
            this.label_TenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_LSP
            // 
            this.comboBox_LSP.FormattingEnabled = true;
            this.comboBox_LSP.Location = new System.Drawing.Point(238, 352);
            this.comboBox_LSP.Name = "comboBox_LSP";
            this.comboBox_LSP.Size = new System.Drawing.Size(294, 28);
            this.comboBox_LSP.TabIndex = 20;
            this.comboBox_LSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_LSP_SelectedIndexChanged);
            this.comboBox_LSP.Click += new System.EventHandler(this.comboBox_LSP_Click);
            // 
            // comboBox_NCC
            // 
            this.comboBox_NCC.FormattingEnabled = true;
            this.comboBox_NCC.Location = new System.Drawing.Point(238, 412);
            this.comboBox_NCC.Name = "comboBox_NCC";
            this.comboBox_NCC.Size = new System.Drawing.Size(294, 28);
            this.comboBox_NCC.TabIndex = 21;
            this.comboBox_NCC.SelectedIndexChanged += new System.EventHandler(this.comboBox_NCC_SelectedIndexChanged);
            this.comboBox_NCC.Click += new System.EventHandler(this.comboBox_NCC_Click);
            // 
            // fChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fChiTietSanPham";
            this.Text = "Chi tiết sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TenSanPham;
        private System.Windows.Forms.PictureBox picture_SanPham;
        private ReaLTaiizor.Controls.Button buttonXoa;
        private ReaLTaiizor.Controls.Button buttonChinhSua;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.TextBox textBox_SL;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.ComboBox comboBox_NCC;
        private System.Windows.Forms.ComboBox comboBox_LSP;
    }
}