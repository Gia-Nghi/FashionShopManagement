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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_Ho = new System.Windows.Forms.Label();
            this.label_Ten = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_Cccd = new System.Windows.Forms.Label();
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btn_CapNhat = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Xoa = new ReaLTaiizor.Controls.MaterialButton();
            this.textBox_Ho = new ReaLTaiizor.Controls.CyberTextBox();
            this.textBox_Ten = new ReaLTaiizor.Controls.CyberTextBox();
            this.textBox_DiaChi = new ReaLTaiizor.Controls.CyberTextBox();
            this.textBox_Cccd = new ReaLTaiizor.Controls.CyberTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SVN-Blade Runner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(381, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT KHÁCH HÀNG";
            this.label1.Click += new System.EventHandler(this.dungeonHeaderLabel1_Click);
            // 
            // label_Ho
            // 
            this.label_Ho.AutoSize = true;
            this.label_Ho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ho.Location = new System.Drawing.Point(24, 143);
            this.label_Ho.Name = "label_Ho";
            this.label_Ho.Size = new System.Drawing.Size(42, 23);
            this.label_Ho.TabIndex = 1;
            this.label_Ho.Text = "Họ:";
            this.label_Ho.Click += new System.EventHandler(this.label_Ho_Click);
            // 
            // label_Ten
            // 
            this.label_Ten.AutoSize = true;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Ten.Location = new System.Drawing.Point(24, 201);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(49, 23);
            this.label_Ten.TabIndex = 2;
            this.label_Ten.Text = "Tên:";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_NgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_NgaySinh.Location = new System.Drawing.Point(24, 256);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(99, 23);
            this.label_NgaySinh.TabIndex = 3;
            this.label_NgaySinh.Text = "Ngày sinh:";
            this.label_NgaySinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_DiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_DiaChi.Location = new System.Drawing.Point(24, 319);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(75, 23);
            this.label_DiaChi.TabIndex = 4;
            this.label_DiaChi.Text = "Địa chỉ:";
            // 
            // label_Cccd
            // 
            this.label_Cccd.AutoSize = true;
            this.label_Cccd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label_Cccd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Cccd.Location = new System.Drawing.Point(24, 377);
            this.label_Cccd.Name = "label_Cccd";
            this.label_Cccd.Size = new System.Drawing.Size(73, 23);
            this.label_Cccd.TabIndex = 5;
            this.label_Cccd.Text = "CCCD:";
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.poisonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.poisonDataGridView1.EnableHeadersVisualStyles = false;
            this.poisonDataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.Location = new System.Drawing.Point(388, 137);
            this.poisonDataGridView1.Name = "poisonDataGridView1";
            this.poisonDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.poisonDataGridView1.RowHeadersWidth = 62;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.RowTemplate.Height = 28;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(666, 383);
            this.poisonDataGridView1.TabIndex = 7;
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
            this.btn_CapNhat.Location = new System.Drawing.Point(80, 484);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.btn_Xoa.Location = new System.Drawing.Point(226, 484);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // textBox_Ho
            // 
            this.textBox_Ho.Alpha = 20;
            this.textBox_Ho.BackColor = System.Drawing.Color.Transparent;
            this.textBox_Ho.Background_WidthPen = 3F;
            this.textBox_Ho.BackgroundPen = true;
            this.textBox_Ho.ColorBackground = System.Drawing.Color.White;
            this.textBox_Ho.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ho.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ho.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ho.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_Ho.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_Ho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Ho.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ho.Lighting = false;
            this.textBox_Ho.LinearGradientPen = false;
            this.textBox_Ho.Location = new System.Drawing.Point(114, 137);
            this.textBox_Ho.Name = "textBox_Ho";
            this.textBox_Ho.PenWidth = 15;
            this.textBox_Ho.RGB = false;
            this.textBox_Ho.Rounding = true;
            this.textBox_Ho.RoundingInt = 60;
            this.textBox_Ho.Size = new System.Drawing.Size(268, 40);
            this.textBox_Ho.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_Ho.TabIndex = 10;
            this.textBox_Ho.Tag = "Cyber";
            this.textBox_Ho.TextButton = "";
            this.textBox_Ho.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_Ho.Timer_RGB = 300;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Alpha = 20;
            this.textBox_Ten.BackColor = System.Drawing.Color.Transparent;
            this.textBox_Ten.Background_WidthPen = 3F;
            this.textBox_Ten.BackgroundPen = true;
            this.textBox_Ten.ColorBackground = System.Drawing.Color.White;
            this.textBox_Ten.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ten.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ten.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Ten.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_Ten.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_Ten.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Ten.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ten.Lighting = false;
            this.textBox_Ten.LinearGradientPen = false;
            this.textBox_Ten.Location = new System.Drawing.Point(114, 184);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.PenWidth = 15;
            this.textBox_Ten.RGB = false;
            this.textBox_Ten.Rounding = true;
            this.textBox_Ten.RoundingInt = 60;
            this.textBox_Ten.Size = new System.Drawing.Size(268, 40);
            this.textBox_Ten.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_Ten.TabIndex = 11;
            this.textBox_Ten.Tag = "Cyber";
            this.textBox_Ten.TextButton = "";
            this.textBox_Ten.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_Ten.Timer_RGB = 300;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Alpha = 20;
            this.textBox_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.textBox_DiaChi.Background_WidthPen = 3F;
            this.textBox_DiaChi.BackgroundPen = true;
            this.textBox_DiaChi.ColorBackground = System.Drawing.Color.White;
            this.textBox_DiaChi.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_DiaChi.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_DiaChi.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_DiaChi.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_DiaChi.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_DiaChi.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.textBox_DiaChi.Lighting = false;
            this.textBox_DiaChi.LinearGradientPen = false;
            this.textBox_DiaChi.Location = new System.Drawing.Point(114, 302);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.PenWidth = 15;
            this.textBox_DiaChi.RGB = false;
            this.textBox_DiaChi.Rounding = true;
            this.textBox_DiaChi.RoundingInt = 60;
            this.textBox_DiaChi.Size = new System.Drawing.Size(268, 40);
            this.textBox_DiaChi.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_DiaChi.TabIndex = 12;
            this.textBox_DiaChi.Tag = "Cyber";
            this.textBox_DiaChi.TextButton = "";
            this.textBox_DiaChi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_DiaChi.Timer_RGB = 300;
            // 
            // textBox_Cccd
            // 
            this.textBox_Cccd.Alpha = 20;
            this.textBox_Cccd.BackColor = System.Drawing.Color.Transparent;
            this.textBox_Cccd.Background_WidthPen = 3F;
            this.textBox_Cccd.BackgroundPen = true;
            this.textBox_Cccd.ColorBackground = System.Drawing.Color.White;
            this.textBox_Cccd.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Cccd.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Cccd.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.textBox_Cccd.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.textBox_Cccd.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.textBox_Cccd.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Cccd.ForeColor = System.Drawing.Color.Black;
            this.textBox_Cccd.Lighting = false;
            this.textBox_Cccd.LinearGradientPen = false;
            this.textBox_Cccd.Location = new System.Drawing.Point(114, 360);
            this.textBox_Cccd.Name = "textBox_Cccd";
            this.textBox_Cccd.PenWidth = 15;
            this.textBox_Cccd.RGB = false;
            this.textBox_Cccd.Rounding = true;
            this.textBox_Cccd.RoundingInt = 60;
            this.textBox_Cccd.Size = new System.Drawing.Size(268, 40);
            this.textBox_Cccd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.textBox_Cccd.TabIndex = 13;
            this.textBox_Cccd.Tag = "Cyber";
            this.textBox_Cccd.TextButton = "";
            this.textBox_Cccd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.textBox_Cccd.Timer_RGB = 300;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1066, 621);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Cccd);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.textBox_Ten);
            this.Controls.Add(this.textBox_Ho);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.poisonDataGridView1);
            this.Controls.Add(this.label_Cccd);
            this.Controls.Add(this.label_DiaChi);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.label_Ho);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel label1;
        private System.Windows.Forms.Label label_Ho;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_Cccd;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btn_CapNhat;
        private ReaLTaiizor.Controls.MaterialButton btn_Xoa;
        private ReaLTaiizor.Controls.CyberTextBox textBox_Ho;
        private ReaLTaiizor.Controls.CyberTextBox textBox_Ten;
        private ReaLTaiizor.Controls.CyberTextBox textBox_DiaChi;
        private ReaLTaiizor.Controls.CyberTextBox textBox_Cccd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}