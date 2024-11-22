namespace GUI
{
    partial class fThemCa
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Ca Làm Việc";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Làm Việc";

            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Location = new System.Drawing.Point(95, 46);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLam.TabIndex = 2;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ Bắt Đầu";

            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(95, 84);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpGioBatDau.TabIndex = 4;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ Kết Thúc";

            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(95, 122);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtpGioKetThuc.TabIndex = 6;

            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(95, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;

            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(216, 160);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;

            // 
            // fThemCa
            // 
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpGioKetThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGioBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fThemCa";
            this.Text = "Thêm Ca Làm Việc";
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
