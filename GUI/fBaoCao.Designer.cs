namespace GUI
{
    partial class fBaoCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_PhieuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_PhieuChi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lb_PhieuChi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuChi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_PhieuChi,
            this.Menu_DoanhThu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_PhieuChi
            // 
            this.Menu_PhieuChi.Name = "Menu_PhieuChi";
            this.Menu_PhieuChi.Size = new System.Drawing.Size(92, 24);
            this.Menu_PhieuChi.Text = "PHIẾU CHI";
            this.Menu_PhieuChi.Click += new System.EventHandler(this.Menu_PhieuChi_Click);
            // 
            // Menu_DoanhThu
            // 
            this.Menu_DoanhThu.Name = "Menu_DoanhThu";
            this.Menu_DoanhThu.Size = new System.Drawing.Size(110, 24);
            this.Menu_DoanhThu.Text = "DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 593);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.05565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.94435F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1209, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_PhieuChi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 474);
            this.panel3.TabIndex = 6;
            // 
            // dgv_PhieuChi
            // 
            this.dgv_PhieuChi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv_PhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PhieuChi.GridColor = System.Drawing.Color.MistyRose;
            this.dgv_PhieuChi.Location = new System.Drawing.Point(0, 0);
            this.dgv_PhieuChi.Name = "dgv_PhieuChi";
            this.dgv_PhieuChi.RowHeadersWidth = 51;
            this.dgv_PhieuChi.RowTemplate.Height = 24;
            this.dgv_PhieuChi.Size = new System.Drawing.Size(1203, 474);
            this.dgv_PhieuChi.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuat);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.lb_PhieuChi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 107);
            this.panel2.TabIndex = 0;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(984, 32);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(114, 38);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "XUẤT";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(831, 32);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lb_PhieuChi
            // 
            this.lb_PhieuChi.AutoSize = true;
            this.lb_PhieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhieuChi.Location = new System.Drawing.Point(30, 34);
            this.lb_PhieuChi.Name = "lb_PhieuChi";
            this.lb_PhieuChi.Size = new System.Drawing.Size(164, 36);
            this.lb_PhieuChi.TabIndex = 3;
            this.lb_PhieuChi.Text = "PHIẾU CHI";
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1209, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fBaoCao";
            this.Text = "fBaoCao";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuChi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_PhieuChi;
        private System.Windows.Forms.ToolStripMenuItem Menu_DoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lb_PhieuChi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_PhieuChi;
    }
}