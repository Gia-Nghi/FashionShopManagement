﻿namespace GUI
{
    partial class fLogin
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
            this.parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            this.parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangNhap = new ReaLTaiizor.Controls.MaterialButton();
            this.label_QuenMatKhau = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.textBox_MatKhau = new ReaLTaiizor.Controls.HopeTextBox();
            this.textBox_Email = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotFormEllipse1
            // 
            this.parrotFormEllipse1.CornerRadius = 10;
            this.parrotFormEllipse1.EffectedForm = this;
            // 
            // parrotFormHandle1
            // 
            this.parrotFormHandle1.DockAtTop = true;
            this.parrotFormHandle1.HandleControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.Login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(373, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 467);
            this.panel1.TabIndex = 2;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(464, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 6;
            // 
            // parrotFormHandle2
            // 
            this.parrotFormHandle2.DockAtTop = true;
            this.parrotFormHandle2.HandleControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.skyLabel2);
            this.panel2.Controls.Add(this.skyLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_DangNhap);
            this.panel2.Controls.Add(this.label_QuenMatKhau);
            this.panel2.Controls.Add(this.textBox_MatKhau);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 467);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(11, 269);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(67, 14);
            this.skyLabel2.TabIndex = 24;
            this.skyLabel2.Text = "Mật khẩu";
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(11, 195);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(103, 14);
            this.skyLabel1.TabIndex = 23;
            this.skyLabel1.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.end_user1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 142);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangNhap.AutoSize = false;
            this.btn_DangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DangNhap.BackColor = System.Drawing.Color.Crimson;
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangNhap.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DangNhap.Depth = 0;
            this.btn_DangNhap.HighEmphasis = true;
            this.btn_DangNhap.Icon = null;
            this.btn_DangNhap.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_DangNhap.Location = new System.Drawing.Point(105, 388);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_DangNhap.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DangNhap.Size = new System.Drawing.Size(144, 43);
            this.btn_DangNhap.TabIndex = 20;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DangNhap.UseAccentColor = true;
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label_QuenMatKhau
            // 
            this.label_QuenMatKhau.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.label_QuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_QuenMatKhau.AutoSize = true;
            this.label_QuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.label_QuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_QuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.label_QuenMatKhau.LinkColor = System.Drawing.Color.Black;
            this.label_QuenMatKhau.Location = new System.Drawing.Point(100, 338);
            this.label_QuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_QuenMatKhau.Name = "label_QuenMatKhau";
            this.label_QuenMatKhau.Size = new System.Drawing.Size(150, 25);
            this.label_QuenMatKhau.TabIndex = 18;
            this.label_QuenMatKhau.TabStop = true;
            this.label_QuenMatKhau.Text = "Quên mật khẩu?";
            this.label_QuenMatKhau.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MatKhau.BackColor = System.Drawing.Color.White;
            this.textBox_MatKhau.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_MatKhau.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_MatKhau.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.textBox_MatKhau.Hint = "";
            this.textBox_MatKhau.Location = new System.Drawing.Point(13, 286);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MatKhau.MaxLength = 128;
            this.textBox_MatKhau.Multiline = false;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '\0';
            this.textBox_MatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_MatKhau.SelectedText = "";
            this.textBox_MatKhau.SelectionLength = 0;
            this.textBox_MatKhau.SelectionStart = 0;
            this.textBox_MatKhau.Size = new System.Drawing.Size(347, 43);
            this.textBox_MatKhau.TabIndex = 8;
            this.textBox_MatKhau.TabStop = false;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            this.textBox_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MatKhau_KeyDown);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.BackColor = System.Drawing.Color.Snow;
            this.textBox_Email.BaseColor = System.Drawing.Color.Transparent;
            this.textBox_Email.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.textBox_Email.BorderColorB = System.Drawing.Color.DarkGray;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Email.ForeColor = System.Drawing.Color.Black;
            this.textBox_Email.Hint = "";
            this.textBox_Email.Location = new System.Drawing.Point(12, 212);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Email.MaxLength = 128;
            this.textBox_Email.Multiline = false;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.PasswordChar = '\0';
            this.textBox_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Email.SelectedText = "";
            this.textBox_Email.SelectionLength = 0;
            this.textBox_Email.SelectionStart = 0;
            this.textBox_Email.Size = new System.Drawing.Size(347, 43);
            this.textBox_Email.TabIndex = 7;
            this.textBox_Email.TabStop = false;
            this.textBox_Email.UseSystemPasswordChar = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton btn_DangNhap;
        private ReaLTaiizor.Controls.DungeonLinkLabel label_QuenMatKhau;
        private ReaLTaiizor.Controls.HopeTextBox textBox_MatKhau;
        private ReaLTaiizor.Controls.HopeTextBox textBox_Email;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
    }
}