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
            this.labelNhaCungCap = new System.Windows.Forms.Label();
            this.buttonXoa = new ReaLTaiizor.Controls.Button();
            this.buttonChinhSua = new ReaLTaiizor.Controls.Button();
            this.labelSIZE = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelLoaiSP = new System.Windows.Forms.Label();
            this.labelGiaSP = new System.Windows.Forms.Label();
            this.label_TenSanPham = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 499);
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
            this.picture_SanPham.Size = new System.Drawing.Size(356, 495);
            this.picture_SanPham.TabIndex = 0;
            this.picture_SanPham.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.labelNhaCungCap);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonChinhSua);
            this.panel1.Controls.Add(this.labelSIZE);
            this.panel1.Controls.Add(this.labelSoLuong);
            this.panel1.Controls.Add(this.labelLoaiSP);
            this.panel1.Controls.Add(this.labelGiaSP);
            this.panel1.Controls.Add(this.label_TenSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(365, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 495);
            this.panel1.TabIndex = 1;
            // 
            // labelNhaCungCap
            // 
            this.labelNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhaCungCap.ForeColor = System.Drawing.Color.Sienna;
            this.labelNhaCungCap.Location = new System.Drawing.Point(0, 294);
            this.labelNhaCungCap.Name = "labelNhaCungCap";
            this.labelNhaCungCap.Size = new System.Drawing.Size(515, 65);
            this.labelNhaCungCap.TabIndex = 7;
            this.labelNhaCungCap.Text = "Nha cung cap: abc";
            this.labelNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonXoa.Location = new System.Drawing.Point(306, 416);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonXoa.Size = new System.Drawing.Size(167, 47);
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
            this.buttonChinhSua.Location = new System.Drawing.Point(47, 416);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonChinhSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonChinhSua.Size = new System.Drawing.Size(167, 47);
            this.buttonChinhSua.TabIndex = 5;
            this.buttonChinhSua.Text = "Chỉnh sửa";
            this.buttonChinhSua.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // labelSIZE
            // 
            this.labelSIZE.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSIZE.ForeColor = System.Drawing.Color.Sienna;
            this.labelSIZE.Location = new System.Drawing.Point(0, 229);
            this.labelSIZE.Name = "labelSIZE";
            this.labelSIZE.Size = new System.Drawing.Size(515, 65);
            this.labelSIZE.TabIndex = 4;
            this.labelSIZE.Text = "Kích cỡ: M/L/XL";
            this.labelSIZE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.Sienna;
            this.labelSoLuong.Location = new System.Drawing.Point(0, 168);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(515, 61);
            this.labelSoLuong.TabIndex = 3;
            this.labelSoLuong.Text = "Số lượng: 121";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoaiSP
            // 
            this.labelLoaiSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiSP.ForeColor = System.Drawing.Color.Sienna;
            this.labelLoaiSP.Location = new System.Drawing.Point(0, 103);
            this.labelLoaiSP.Name = "labelLoaiSP";
            this.labelLoaiSP.Size = new System.Drawing.Size(515, 65);
            this.labelLoaiSP.TabIndex = 2;
            this.labelLoaiSP.Text = "Loại sản phẩm: Áo len";
            this.labelLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoaiSP.Click += new System.EventHandler(this.labelLoaiSP_Click);
            // 
            // labelGiaSP
            // 
            this.labelGiaSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaSP.ForeColor = System.Drawing.Color.Red;
            this.labelGiaSP.Location = new System.Drawing.Point(0, 65);
            this.labelGiaSP.Name = "labelGiaSP";
            this.labelGiaSP.Size = new System.Drawing.Size(515, 38);
            this.labelGiaSP.TabIndex = 1;
            this.labelGiaSP.Text = "1.000.000 VNĐ";
            this.labelGiaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TenSanPham
            // 
            this.label_TenSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_TenSanPham.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_TenSanPham.Location = new System.Drawing.Point(0, 0);
            this.label_TenSanPham.Name = "label_TenSanPham";
            this.label_TenSanPham.Size = new System.Drawing.Size(515, 65);
            this.label_TenSanPham.TabIndex = 0;
            this.label_TenSanPham.Text = "Áo len";
            this.label_TenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fChiTietSanPham";
            this.Text = "Chi tiết sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TenSanPham;
        private System.Windows.Forms.Label labelGiaSP;
        private System.Windows.Forms.Label labelSIZE;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelLoaiSP;
        private System.Windows.Forms.PictureBox picture_SanPham;
        private ReaLTaiizor.Controls.Button buttonXoa;
        private ReaLTaiizor.Controls.Button buttonChinhSua;
        private System.Windows.Forms.Label labelNhaCungCap;
    }
}