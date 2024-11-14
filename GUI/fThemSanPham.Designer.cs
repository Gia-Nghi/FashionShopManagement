namespace GUI
{
    partial class fThemSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ChonHinh = new ReaLTaiizor.Controls.MaterialButton();
            this.picture_SanPham = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_ChiTietSanPham = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.textBox_SL = new System.Windows.Forms.TextBox();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_TenSP = new System.Windows.Forms.TextBox();
            this.textBox_MaSP = new System.Windows.Forms.TextBox();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.labelSIZE = new System.Windows.Forms.Label();
            this.labelDonGIa = new System.Windows.Forms.Label();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.btn_Luu = new ReaLTaiizor.Controls.MaterialButton();
            this.label_SanPhamMoi = new System.Windows.Forms.Label();
            this.comboBox_LSP = new System.Windows.Forms.ComboBox();
            this.comboBox_NCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38756F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 858);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ChonHinh);
            this.panel2.Controls.Add(this.picture_SanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 854);
            this.panel2.TabIndex = 1;
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ChonHinh.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ChonHinh.Depth = 0;
            this.btn_ChonHinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ChonHinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ChonHinh.HighEmphasis = true;
            this.btn_ChonHinh.Icon = null;
            this.btn_ChonHinh.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_ChonHinh.Location = new System.Drawing.Point(0, 818);
            this.btn_ChonHinh.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btn_ChonHinh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ChonHinh.Size = new System.Drawing.Size(297, 36);
            this.btn_ChonHinh.TabIndex = 84;
            this.btn_ChonHinh.Text = "Chọn hình";
            this.btn_ChonHinh.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ChonHinh.UseAccentColor = false;
            this.btn_ChonHinh.UseVisualStyleBackColor = true;
            // 
            // picture_SanPham
            // 
            this.picture_SanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_SanPham.BackgroundImage = global::GUI.Properties.Resources.ao_len_1;
            this.picture_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_SanPham.Location = new System.Drawing.Point(0, 0);
            this.picture_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_SanPham.Name = "picture_SanPham";
            this.picture_SanPham.Size = new System.Drawing.Size(297, 854);
            this.picture_SanPham.TabIndex = 1;
            this.picture_SanPham.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label_SanPhamMoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(306, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 854);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.btn_Luu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 786);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06658F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93342F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.53333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(751, 750);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.textBox_ChiTietSanPham);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 591);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 157);
            this.panel4.TabIndex = 0;
            // 
            // textBox_ChiTietSanPham
            // 
            this.textBox_ChiTietSanPham.Alpha = 20;
            this.textBox_ChiTietSanPham.BackColor = System.Drawing.Color.Transparent;
            this.textBox_ChiTietSanPham.Background_WidthPen = 4F;
            this.textBox_ChiTietSanPham.BackgroundPen = true;
            this.textBox_ChiTietSanPham.ColorBackground = System.Drawing.Color.MistyRose;
            this.textBox_ChiTietSanPham.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox_ChiTietSanPham.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_ChiTietSanPham.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_ChiTietSanPham.ColorPen_2 = System.Drawing.Color.White;
            this.textBox_ChiTietSanPham.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_ChiTietSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ChiTietSanPham.Font = new System.Drawing.Font("Arial", 11F);
            this.textBox_ChiTietSanPham.ForeColor = System.Drawing.Color.Black;
            this.textBox_ChiTietSanPham.Lighting = false;
            this.textBox_ChiTietSanPham.LinearGradientPen = false;
            this.textBox_ChiTietSanPham.Location = new System.Drawing.Point(0, 57);
            this.textBox_ChiTietSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ChiTietSanPham.Name = "textBox_ChiTietSanPham";
            this.textBox_ChiTietSanPham.PenWidth = 10;
            this.textBox_ChiTietSanPham.RGB = false;
            this.textBox_ChiTietSanPham.Rounding = true;
            this.textBox_ChiTietSanPham.RoundingInt = 10;
            this.textBox_ChiTietSanPham.Size = new System.Drawing.Size(745, 100);
            this.textBox_ChiTietSanPham.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_ChiTietSanPham.TabIndex = 7;
            this.textBox_ChiTietSanPham.Tag = "Cyber";
            this.textBox_ChiTietSanPham.TextButton = "Vải chính 100% len";
            this.textBox_ChiTietSanPham.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_ChiTietSanPham.Timer_RGB = 300;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(745, 57);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chi tiết sản phẩm:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.comboBox_NCC);
            this.panel5.Controls.Add(this.comboBox_LSP);
            this.panel5.Controls.Add(this.textBox_Size);
            this.panel5.Controls.Add(this.textBox_SL);
            this.panel5.Controls.Add(this.textBox_Gia);
            this.panel5.Controls.Add(this.textBox_TenSP);
            this.panel5.Controls.Add(this.textBox_MaSP);
            this.panel5.Controls.Add(this.lbMaSP);
            this.panel5.Controls.Add(this.labelSL);
            this.panel5.Controls.Add(this.labelSIZE);
            this.panel5.Controls.Add(this.labelDonGIa);
            this.panel5.Controls.Add(this.labelTenSP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 585);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(313, 269);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(100, 26);
            this.textBox_Size.TabIndex = 154;
            // 
            // textBox_SL
            // 
            this.textBox_SL.Location = new System.Drawing.Point(313, 203);
            this.textBox_SL.Name = "textBox_SL";
            this.textBox_SL.Size = new System.Drawing.Size(100, 26);
            this.textBox_SL.TabIndex = 153;
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(313, 142);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(100, 26);
            this.textBox_Gia.TabIndex = 152;
            // 
            // textBox_TenSP
            // 
            this.textBox_TenSP.Location = new System.Drawing.Point(313, 88);
            this.textBox_TenSP.Name = "textBox_TenSP";
            this.textBox_TenSP.Size = new System.Drawing.Size(100, 26);
            this.textBox_TenSP.TabIndex = 151;
            // 
            // textBox_MaSP
            // 
            this.textBox_MaSP.Location = new System.Drawing.Point(313, 29);
            this.textBox_MaSP.Name = "textBox_MaSP";
            this.textBox_MaSP.Size = new System.Drawing.Size(100, 26);
            this.textBox_MaSP.TabIndex = 150;
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbMaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaSP.Location = new System.Drawing.Point(86, 29);
            this.lbMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(128, 23);
            this.lbMaSP.TabIndex = 146;
            this.lbMaSP.Text = "Mã sản phẩm:";
            this.lbMaSP.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSL.Location = new System.Drawing.Point(86, 206);
            this.labelSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(91, 23);
            this.labelSL.TabIndex = 142;
            this.labelSL.Text = "Số lượng:";
            // 
            // labelSIZE
            // 
            this.labelSIZE.AutoSize = true;
            this.labelSIZE.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelSIZE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSIZE.Location = new System.Drawing.Point(86, 270);
            this.labelSIZE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSIZE.Name = "labelSIZE";
            this.labelSIZE.Size = new System.Drawing.Size(81, 23);
            this.labelSIZE.TabIndex = 140;
            this.labelSIZE.Text = "Kích cỡ:";
            // 
            // labelDonGIa
            // 
            this.labelDonGIa.AutoSize = true;
            this.labelDonGIa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGIa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDonGIa.Location = new System.Drawing.Point(86, 145);
            this.labelDonGIa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDonGIa.Name = "labelDonGIa";
            this.labelDonGIa.Size = new System.Drawing.Size(131, 23);
            this.labelDonGIa.TabIndex = 138;
            this.labelDonGIa.Text = "Giá sản phẩm:";
            // 
            // labelTenSP
            // 
            this.labelTenSP.AutoSize = true;
            this.labelTenSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTenSP.Location = new System.Drawing.Point(86, 89);
            this.labelTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(132, 23);
            this.labelTenSP.TabIndex = 134;
            this.labelTenSP.Text = "Tên sản phẩm:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Luu.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Luu.Depth = 0;
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.HighEmphasis = true;
            this.btn_Luu.Icon = null;
            this.btn_Luu.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Luu.Location = new System.Drawing.Point(0, 750);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btn_Luu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Luu.Size = new System.Drawing.Size(751, 36);
            this.btn_Luu.TabIndex = 85;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Luu.UseAccentColor = true;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label_SanPhamMoi
            // 
            this.label_SanPhamMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_SanPhamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_SanPhamMoi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_SanPhamMoi.Location = new System.Drawing.Point(0, 0);
            this.label_SanPhamMoi.Name = "label_SanPhamMoi";
            this.label_SanPhamMoi.Size = new System.Drawing.Size(751, 68);
            this.label_SanPhamMoi.TabIndex = 0;
            this.label_SanPhamMoi.Text = "Sản phẩm mới";
            this.label_SanPhamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SanPhamMoi.Click += new System.EventHandler(this.label_SanPhamMoi_Click);
            // 
            // comboBox_LSP
            // 
            this.comboBox_LSP.FormattingEnabled = true;
            this.comboBox_LSP.Location = new System.Drawing.Point(313, 323);
            this.comboBox_LSP.Name = "comboBox_LSP";
            this.comboBox_LSP.Size = new System.Drawing.Size(121, 28);
            this.comboBox_LSP.TabIndex = 157;
            this.comboBox_LSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_LSP_SelectedIndexChanged);
            // 
            // comboBox_NCC
            // 
            this.comboBox_NCC.FormattingEnabled = true;
            this.comboBox_NCC.Location = new System.Drawing.Point(313, 383);
            this.comboBox_NCC.Name = "comboBox_NCC";
            this.comboBox_NCC.Size = new System.Drawing.Size(121, 28);
            this.comboBox_NCC.TabIndex = 158;
            this.comboBox_NCC.SelectedIndexChanged += new System.EventHandler(this.comboBox_NCC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(86, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 159;
            this.label1.Text = "Loại sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(86, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 160;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // fThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 858);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_SanPhamMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture_SanPham;
        private ReaLTaiizor.Controls.MaterialButton btn_ChonHinh;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.MaterialButton btn_Luu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.CyberRichTextBox textBox_ChiTietSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label labelSIZE;
        private System.Windows.Forms.Label labelDonGIa;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.TextBox textBox_SL;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.TextBox textBox_TenSP;
        private System.Windows.Forms.TextBox textBox_MaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NCC;
        private System.Windows.Forms.ComboBox comboBox_LSP;
    }
}