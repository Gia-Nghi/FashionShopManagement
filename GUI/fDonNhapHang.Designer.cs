namespace GUI
{
    partial class fDonNhapHang
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
            this.lb_PhieuChi = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dgv_PhieuChi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_PhieuChi
            // 
            this.lb_PhieuChi.AutoSize = true;
            this.lb_PhieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhieuChi.Location = new System.Drawing.Point(22, 25);
            this.lb_PhieuChi.Name = "lb_PhieuChi";
            this.lb_PhieuChi.Size = new System.Drawing.Size(164, 36);
            this.lb_PhieuChi.TabIndex = 0;
            this.lb_PhieuChi.Text = "PHIẾU CHI";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1037, 25);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 38);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(1166, 25);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(114, 38);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "XUẤT";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dgv_PhieuChi
            // 
            this.dgv_PhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuChi.Location = new System.Drawing.Point(28, 89);
            this.dgv_PhieuChi.Name = "dgv_PhieuChi";
            this.dgv_PhieuChi.RowHeadersWidth = 51;
            this.dgv_PhieuChi.RowTemplate.Height = 24;
            this.dgv_PhieuChi.Size = new System.Drawing.Size(1252, 413);
            this.dgv_PhieuChi.TabIndex = 3;
            this.dgv_PhieuChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuChi_CellContentClick);
            // 
            // fDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 538);
            this.Controls.Add(this.dgv_PhieuChi);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lb_PhieuChi);
            this.Name = "fDonNhapHang";
            this.Text = "fDonNhapHang";
            this.Load += new System.EventHandler(this.fDonNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PhieuChi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridView dgv_PhieuChi;
    }
}