namespace GUI
{
    partial class fKhachHang
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
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_Ho = new System.Windows.Forms.Label();
            this.label_Ten = new System.Windows.Forms.Label();
            this.DataGridViewKH = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btn_CapNhat = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Xoa = new ReaLTaiizor.Controls.MaterialButton();
            this.textBox_MaKH = new ReaLTaiizor.Controls.CyberTextBox();
            this.textBox_TenKH = new ReaLTaiizor.Controls.CyberTextBox();
            this.TextBox_SDT = new ReaLTaiizor.Controls.CyberTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_DiemTichLuy = new ReaLTaiizor.Controls.CyberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(339, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT KHÁCH HÀNG";
            // 
            // label_Ho
            // 
            this.label_Ho.AutoSize = true;
            this.label_Ho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ho.Location = new System.Drawing.Point(17, 158);
            this.label_Ho.Name = "label_Ho";
            this.label_Ho.Size = new System.Drawing.Size(64, 19);
            this.label_Ho.TabIndex = 1;
            this.label_Ho.Text = "MãKH:";
            // 
            // label_Ten
            // 
            this.label_Ten.AutoSize = true;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ten.Location = new System.Drawing.Point(17, 211);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(42, 19);
            this.label_Ten.TabIndex = 2;
            this.label_Ten.Text = "Tên:";
            // 
            // DataGridViewKH
            // 
            this.DataGridViewKH.AllowUserToResizeRows = false;
            this.DataGridViewKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewKH.EnableHeadersVisualStyles = false;
            this.DataGridViewKH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewKH.Location = new System.Drawing.Point(331, 119);
            this.DataGridViewKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewKH.Name = "DataGridViewKH";
            this.DataGridViewKH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewKH.RowHeadersWidth = 62;
            this.DataGridViewKH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewKH.RowTemplate.Height = 28;
            this.DataGridViewKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewKH.Size = new System.Drawing.Size(539, 306);
            this.DataGridViewKH.TabIndex = 7;
            this.DataGridViewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKH_CellContentClick);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CapNhat.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_CapNhat.Depth = 0;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.HighEmphasis = true;
            this.btn_CapNhat.Icon = null;
            this.btn_CapNhat.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_CapNhat.Location = new System.Drawing.Point(69, 359);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CapNhat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_CapNhat.Size = new System.Drawing.Size(93, 36);
            this.btn_CapNhat.TabIndex = 8;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_CapNhat.UseAccentColor = false;
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Xoa.Location = new System.Drawing.Point(199, 359);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Size = new System.Drawing.Size(64, 36);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Xoa.UseAccentColor = false;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // textBox_MaKH
            // 
            this.textBox_MaKH.Alpha = 20;
            this.textBox_MaKH.BackColor = System.Drawing.Color.Transparent;
            this.textBox_MaKH.Background_WidthPen = 3F;
            this.textBox_MaKH.BackgroundPen = true;
            this.textBox_MaKH.ColorBackground = System.Drawing.Color.White;
            this.textBox_MaKH.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_MaKH.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_MaKH.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_MaKH.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_MaKH.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_MaKH.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.textBox_MaKH.ForeColor = System.Drawing.Color.Black;
            this.textBox_MaKH.Lighting = false;
            this.textBox_MaKH.LinearGradientPen = false;
            this.textBox_MaKH.Location = new System.Drawing.Point(87, 145);
            this.textBox_MaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MaKH.Name = "textBox_MaKH";
            this.textBox_MaKH.PenWidth = 15;
            this.textBox_MaKH.RGB = false;
            this.textBox_MaKH.Rounding = true;
            this.textBox_MaKH.RoundingInt = 60;
            this.textBox_MaKH.Size = new System.Drawing.Size(238, 32);
            this.textBox_MaKH.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_MaKH.TabIndex = 10;
            this.textBox_MaKH.Tag = "Cyber";
            this.textBox_MaKH.TextButton = "";
            this.textBox_MaKH.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_MaKH.Timer_RGB = 300;
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Alpha = 20;
            this.textBox_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.textBox_TenKH.Background_WidthPen = 3F;
            this.textBox_TenKH.BackgroundPen = true;
            this.textBox_TenKH.ColorBackground = System.Drawing.Color.White;
            this.textBox_TenKH.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TenKH.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TenKH.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_TenKH.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_TenKH.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_TenKH.Font = new System.Drawing.Font("Arial", 8F);
            this.textBox_TenKH.ForeColor = System.Drawing.Color.Black;
            this.textBox_TenKH.Lighting = false;
            this.textBox_TenKH.LinearGradientPen = false;
            this.textBox_TenKH.Location = new System.Drawing.Point(87, 198);
            this.textBox_TenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.PenWidth = 15;
            this.textBox_TenKH.RGB = false;
            this.textBox_TenKH.Rounding = true;
            this.textBox_TenKH.RoundingInt = 60;
            this.textBox_TenKH.Size = new System.Drawing.Size(238, 32);
            this.textBox_TenKH.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_TenKH.TabIndex = 11;
            this.textBox_TenKH.Tag = "Cyber";
            this.textBox_TenKH.TextButton = "";
            this.textBox_TenKH.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_TenKH.Timer_RGB = 300;
            // 
            // TextBox_SDT
            // 
            this.TextBox_SDT.Alpha = 20;
            this.TextBox_SDT.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_SDT.Background_WidthPen = 3F;
            this.TextBox_SDT.BackgroundPen = true;
            this.TextBox_SDT.ColorBackground = System.Drawing.Color.White;
            this.TextBox_SDT.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_SDT.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_SDT.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_SDT.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TextBox_SDT.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TextBox_SDT.Font = new System.Drawing.Font("Arial", 8F);
            this.TextBox_SDT.ForeColor = System.Drawing.Color.Black;
            this.TextBox_SDT.Lighting = false;
            this.TextBox_SDT.LinearGradientPen = false;
            this.TextBox_SDT.Location = new System.Drawing.Point(87, 253);
            this.TextBox_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_SDT.Name = "TextBox_SDT";
            this.TextBox_SDT.PenWidth = 15;
            this.TextBox_SDT.RGB = false;
            this.TextBox_SDT.Rounding = true;
            this.TextBox_SDT.RoundingInt = 60;
            this.TextBox_SDT.Size = new System.Drawing.Size(238, 32);
            this.TextBox_SDT.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TextBox_SDT.TabIndex = 13;
            this.TextBox_SDT.Tag = "Cyber";
            this.TextBox_SDT.TextButton = "";
            this.TextBox_SDT.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox_SDT.Timer_RGB = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "SDT:";
            // 
            // TextBox_DiemTichLuy
            // 
            this.TextBox_DiemTichLuy.Alpha = 20;
            this.TextBox_DiemTichLuy.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_DiemTichLuy.Background_WidthPen = 3F;
            this.TextBox_DiemTichLuy.BackgroundPen = true;
            this.TextBox_DiemTichLuy.ColorBackground = System.Drawing.Color.White;
            this.TextBox_DiemTichLuy.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_DiemTichLuy.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_DiemTichLuy.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TextBox_DiemTichLuy.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TextBox_DiemTichLuy.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TextBox_DiemTichLuy.Font = new System.Drawing.Font("Arial", 8F);
            this.TextBox_DiemTichLuy.ForeColor = System.Drawing.Color.Black;
            this.TextBox_DiemTichLuy.Lighting = false;
            this.TextBox_DiemTichLuy.LinearGradientPen = false;
            this.TextBox_DiemTichLuy.Location = new System.Drawing.Point(146, 307);
            this.TextBox_DiemTichLuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_DiemTichLuy.Name = "TextBox_DiemTichLuy";
            this.TextBox_DiemTichLuy.PenWidth = 15;
            this.TextBox_DiemTichLuy.RGB = false;
            this.TextBox_DiemTichLuy.Rounding = true;
            this.TextBox_DiemTichLuy.RoundingInt = 60;
            this.TextBox_DiemTichLuy.Size = new System.Drawing.Size(179, 32);
            this.TextBox_DiemTichLuy.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TextBox_DiemTichLuy.TabIndex = 15;
            this.TextBox_DiemTichLuy.Tag = "Cyber";
            this.TextBox_DiemTichLuy.TextButton = "";
            this.TextBox_DiemTichLuy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox_DiemTichLuy.Timer_RGB = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Điểm tích lũy:";
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.TextBox_DiemTichLuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenKH);
            this.Controls.Add(this.textBox_MaKH);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.DataGridViewKH);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.label_Ho);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private System.Windows.Forms.Label label_Ho;
        private System.Windows.Forms.Label label_Ten;
        private ReaLTaiizor.Controls.PoisonDataGridView DataGridViewKH;
        private ReaLTaiizor.Controls.MaterialButton btn_CapNhat;
        private ReaLTaiizor.Controls.MaterialButton btn_Xoa;
        private ReaLTaiizor.Controls.CyberTextBox textBox_MaKH;
        private ReaLTaiizor.Controls.CyberTextBox textBox_TenKH;
        private ReaLTaiizor.Controls.CyberTextBox TextBox_SDT;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.CyberTextBox TextBox_DiemTichLuy;
        private System.Windows.Forms.Label label3;
    }
}