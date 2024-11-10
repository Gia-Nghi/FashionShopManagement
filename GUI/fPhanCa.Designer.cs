namespace GUI
{
    partial class fPhanCa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvCaLamViec = new System.Windows.Forms.DataGridView();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.btnThemCa = new System.Windows.Forms.Button();
            this.btnSuaCa = new System.Windows.Forms.Button();
            this.btnXoaCa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaCa = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.labelNgayLam = new System.Windows.Forms.Label();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.labelGioBatDau = new System.Windows.Forms.Label();
            this.labelGioKetThuc = new System.Windows.Forms.Label();
            this.labelHoNV = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaLamViec
            // 
            this.dgvCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaLamViec.Location = new System.Drawing.Point(12, 59);
            this.dgvCaLamViec.Name = "dgvCaLamViec";
            this.dgvCaLamViec.ReadOnly = true;
            this.dgvCaLamViec.RowHeadersVisible = false;
            this.dgvCaLamViec.RowHeadersWidth = 51;
            this.dgvCaLamViec.Size = new System.Drawing.Size(776, 300);
            this.dgvCaLamViec.TabIndex = 0;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(18, 408);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(100, 22);
            this.txtMaCa.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 408);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Location = new System.Drawing.Point(258, 408);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLam.TabIndex = 3;
            // 
            // btnThemCa
            // 
            this.btnThemCa.BackColor = System.Drawing.Color.Blue;
            this.btnThemCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemCa.Location = new System.Drawing.Point(570, 383);
            this.btnThemCa.Name = "btnThemCa";
            this.btnThemCa.Size = new System.Drawing.Size(109, 47);
            this.btnThemCa.TabIndex = 4;
            this.btnThemCa.Text = "Thêm Ca";
            this.btnThemCa.UseVisualStyleBackColor = false;
            this.btnThemCa.Click += new System.EventHandler(this.btnThemCa_Click);
            // 
            // btnSuaCa
            // 
            this.btnSuaCa.BackColor = System.Drawing.Color.Blue;
            this.btnSuaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuaCa.Location = new System.Drawing.Point(570, 443);
            this.btnSuaCa.Name = "btnSuaCa";
            this.btnSuaCa.Size = new System.Drawing.Size(109, 47);
            this.btnSuaCa.TabIndex = 5;
            this.btnSuaCa.Text = "Sửa Ca";
            this.btnSuaCa.UseVisualStyleBackColor = false;
            this.btnSuaCa.Click += new System.EventHandler(this.btnSuaCa_Click);
            // 
            // btnXoaCa
            // 
            this.btnXoaCa.BackColor = System.Drawing.Color.Blue;
            this.btnXoaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoaCa.Location = new System.Drawing.Point(570, 496);
            this.btnXoaCa.Name = "btnXoaCa";
            this.btnXoaCa.Size = new System.Drawing.Size(109, 47);
            this.btnXoaCa.TabIndex = 6;
            this.btnXoaCa.Text = "Xóa Ca";
            this.btnXoaCa.UseVisualStyleBackColor = false;
            this.btnXoaCa.Click += new System.EventHandler(this.btnXoaCa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Ca Làm Việc";
            // 
            // labelMaCa
            // 
            this.labelMaCa.AutoSize = true;
            this.labelMaCa.Location = new System.Drawing.Point(46, 379);
            this.labelMaCa.Name = "labelMaCa";
            this.labelMaCa.Size = new System.Drawing.Size(46, 16);
            this.labelMaCa.TabIndex = 8;
            this.labelMaCa.Text = "Mã Ca";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(166, 379);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(48, 16);
            this.labelMaNV.TabIndex = 9;
            this.labelMaNV.Text = "Mã NV";
            // 
            // labelNgayLam
            // 
            this.labelNgayLam.AutoSize = true;
            this.labelNgayLam.Location = new System.Drawing.Point(326, 379);
            this.labelNgayLam.Name = "labelNgayLam";
            this.labelNgayLam.Size = new System.Drawing.Size(65, 16);
            this.labelNgayLam.TabIndex = 10;
            this.labelNgayLam.Text = "Ngày làm";
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Location = new System.Drawing.Point(12, 507);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(100, 22);
            this.txtGioBatDau.TabIndex = 11;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(132, 507);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(100, 22);
            this.txtGioKetThuc.TabIndex = 12;
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(252, 507);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(100, 22);
            this.txtHoNV.TabIndex = 13;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(372, 507);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 22);
            this.txtTenNV.TabIndex = 14;
            // 
            // labelGioBatDau
            // 
            this.labelGioBatDau.AutoSize = true;
            this.labelGioBatDau.Location = new System.Drawing.Point(25, 474);
            this.labelGioBatDau.Name = "labelGioBatDau";
            this.labelGioBatDau.Size = new System.Drawing.Size(76, 16);
            this.labelGioBatDau.TabIndex = 15;
            this.labelGioBatDau.Text = "Giờ bắt đầu";
            // 
            // labelGioKetThuc
            // 
            this.labelGioKetThuc.AutoSize = true;
            this.labelGioKetThuc.Location = new System.Drawing.Point(156, 474);
            this.labelGioKetThuc.Name = "labelGioKetThuc";
            this.labelGioKetThuc.Size = new System.Drawing.Size(76, 16);
            this.labelGioKetThuc.TabIndex = 16;
            this.labelGioKetThuc.Text = "Giờ kết thúc";
            // 
            // labelHoNV
            // 
            this.labelHoNV.AutoSize = true;
            this.labelHoNV.Location = new System.Drawing.Point(259, 474);
            this.labelHoNV.Name = "labelHoNV";
            this.labelHoNV.Size = new System.Drawing.Size(47, 16);
            this.labelHoNV.TabIndex = 17;
            this.labelHoNV.Text = "Họ NV";
            // 
            // labelTenNV
            // 
            this.labelTenNV.AutoSize = true;
            this.labelTenNV.Location = new System.Drawing.Point(379, 474);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(53, 16);
            this.labelTenNV.TabIndex = 18;
            this.labelTenNV.Text = "Tên NV";
            // 
            // fPhanCa
            // 
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.labelTenNV);
            this.Controls.Add(this.labelHoNV);
            this.Controls.Add(this.labelGioKetThuc);
            this.Controls.Add(this.labelGioBatDau);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHoNV);
            this.Controls.Add(this.txtGioKetThuc);
            this.Controls.Add(this.txtGioBatDau);
            this.Controls.Add(this.labelNgayLam);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.labelMaCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaCa);
            this.Controls.Add(this.btnSuaCa);
            this.Controls.Add(this.btnThemCa);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaCa);
            this.Controls.Add(this.dgvCaLamViec);
            this.Name = "fPhanCa";
            this.Load += new System.EventHandler(this.fPhanCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaLamViec;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Button btnThemCa;
        private System.Windows.Forms.Button btnSuaCa;
        private System.Windows.Forms.Button btnXoaCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaCa;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelNgayLam;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label labelGioBatDau;
        private System.Windows.Forms.Label labelGioKetThuc;
        private System.Windows.Forms.Label labelHoNV;
        private System.Windows.Forms.Label labelTenNV;
    }
}
