namespace GUI
{
    partial class fSuaCa
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa Ca Làm Việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Làm Việc";
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Location = new System.Drawing.Point(220, 58);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ Bắt Đầu";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(220, 108);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpGioBatDau.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ Kết Thúc";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(220, 165);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpGioKetThuc.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(99, 213);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(220, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // fSuaCa
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpGioKetThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGioBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fSuaCa";
            this.Text = "Sửa Ca Làm Việc";
            this.Load += new System.EventHandler(this.fSuaCa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
