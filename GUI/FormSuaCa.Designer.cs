namespace GUI
{
    partial class FormSuaCa
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

        private void InitializeComponent()
        {
            this.lblMaCa = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblNgayLam = new System.Windows.Forms.Label();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Location = new System.Drawing.Point(20, 23);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(49, 16);
            this.lblMaCa.TabIndex = 0;
            this.lblMaCa.Text = "Mã Ca:";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(139, 17);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(200, 22);
            this.txtMaCa.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(20, 81);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(94, 16);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(139, 64);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 33);
            this.txtMaNV.TabIndex = 3;
            // 
            // lblNgayLam
            // 
            this.lblNgayLam.AutoSize = true;
            this.lblNgayLam.Location = new System.Drawing.Point(20, 141);
            this.lblNgayLam.Name = "lblNgayLam";
            this.lblNgayLam.Size = new System.Drawing.Size(72, 16);
            this.lblNgayLam.TabIndex = 4;
            this.lblNgayLam.Text = "Ngày Làm:";
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLam.Location = new System.Drawing.Point(139, 135);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLam.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(23, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(225, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSuaCa
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(363, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.lblNgayLam);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMaCa);
            this.Controls.Add(this.lblMaCa);
            this.Name = "FormSuaCa";
            this.Text = "Sửa Ca Làm Việc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblNgayLam;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
