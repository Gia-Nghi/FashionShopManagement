namespace GUI
{
    partial class fHome
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
            this.TOPSR = new ReaLTaiizor.Controls.AirSeparator();
            this.BOTSR = new ReaLTaiizor.Controls.AirSeparator();
            this.MIDPL = new System.Windows.Forms.Panel();
            this.FILLPL = new System.Windows.Forms.Panel();
            this.BOTPL = new System.Windows.Forms.Panel();
            this.CONNECTT = new ReaLTaiizor.Controls.MetroTile();
            this.CONTACTT = new ReaLTaiizor.Controls.MetroTile();
            this.SETTINGT = new ReaLTaiizor.Controls.MetroTile();
            this.MESSAGET = new ReaLTaiizor.Controls.MetroTile();
            this.MAILLLE = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.BOTPLSR = new ReaLTaiizor.Controls.LostSeparator();
            this.STATELLE = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.btn_NhanVien = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_ThongTin = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_CaiDat = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_ThongKe = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_SanPham = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_BaoCao = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_KhachHang = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_DonHang = new ReaLTaiizor.Controls.PoisonTile();
            this.TOPPL = new System.Windows.Forms.Panel();
            this.MINIMIZEB = new ReaLTaiizor.Controls.RoyalButton();
            this.CLOSEB = new ReaLTaiizor.Controls.RoyalButton();
            this.PROTECTPB = new System.Windows.Forms.PictureBox();
            this.PROTECTLE = new ReaLTaiizor.Controls.LabelEdit();
            this.MIDPL.SuspendLayout();
            this.FILLPL.SuspendLayout();
            this.BOTPL.SuspendLayout();
            this.TOPPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PROTECTPB)).BeginInit();
            this.SuspendLayout();
            // 
            // TOPSR
            // 
            this.TOPSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.TOPSR.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.TOPSR.Customization = "";
            this.TOPSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOPSR.Font = new System.Drawing.Font("Verdana", 8F);
            this.TOPSR.Image = null;
            this.TOPSR.Location = new System.Drawing.Point(0, 308);
            this.TOPSR.Margin = new System.Windows.Forms.Padding(0);
            this.TOPSR.Name = "TOPSR";
            this.TOPSR.NoRounding = false;
            this.TOPSR.Size = new System.Drawing.Size(1200, 1);
            this.TOPSR.TabIndex = 5;
            this.TOPSR.Text = "airSeparator1";
            this.TOPSR.Transparent = false;
            // 
            // BOTSR
            // 
            this.BOTSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BOTSR.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.BOTSR.Customization = "";
            this.BOTSR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BOTSR.Font = new System.Drawing.Font("Verdana", 8F);
            this.BOTSR.Image = null;
            this.BOTSR.Location = new System.Drawing.Point(0, 911);
            this.BOTSR.Margin = new System.Windows.Forms.Padding(0);
            this.BOTSR.Name = "BOTSR";
            this.BOTSR.NoRounding = false;
            this.BOTSR.Size = new System.Drawing.Size(1200, 1);
            this.BOTSR.TabIndex = 3;
            this.BOTSR.Text = "BOTSR";
            this.BOTSR.Transparent = false;
            // 
            // MIDPL
            // 
            this.MIDPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MIDPL.Controls.Add(this.btn_NhanVien);
            this.MIDPL.Controls.Add(this.btn_ThongTin);
            this.MIDPL.Controls.Add(this.btn_CaiDat);
            this.MIDPL.Controls.Add(this.btn_ThongKe);
            this.MIDPL.Controls.Add(this.btn_SanPham);
            this.MIDPL.Controls.Add(this.btn_BaoCao);
            this.MIDPL.Controls.Add(this.btn_KhachHang);
            this.MIDPL.Controls.Add(this.btn_DonHang);
            this.MIDPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MIDPL.Location = new System.Drawing.Point(0, 309);
            this.MIDPL.Margin = new System.Windows.Forms.Padding(0);
            this.MIDPL.Name = "MIDPL";
            this.MIDPL.Size = new System.Drawing.Size(1200, 602);
            this.MIDPL.TabIndex = 6;
            // 
            // FILLPL
            // 
            this.FILLPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.FILLPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FILLPL.Controls.Add(this.MIDPL);
            this.FILLPL.Controls.Add(this.TOPSR);
            this.FILLPL.Controls.Add(this.BOTSR);
            this.FILLPL.Controls.Add(this.TOPPL);
            this.FILLPL.Controls.Add(this.BOTPL);
            this.FILLPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FILLPL.Location = new System.Drawing.Point(0, 0);
            this.FILLPL.Margin = new System.Windows.Forms.Padding(0);
            this.FILLPL.Name = "FILLPL";
            this.FILLPL.Size = new System.Drawing.Size(1200, 960);
            this.FILLPL.TabIndex = 5;
            // 
            // BOTPL
            // 
            this.BOTPL.BackColor = System.Drawing.Color.White;
            this.BOTPL.Controls.Add(this.CONNECTT);
            this.BOTPL.Controls.Add(this.CONTACTT);
            this.BOTPL.Controls.Add(this.SETTINGT);
            this.BOTPL.Controls.Add(this.MESSAGET);
            this.BOTPL.Controls.Add(this.MAILLLE);
            this.BOTPL.Controls.Add(this.BOTPLSR);
            this.BOTPL.Controls.Add(this.STATELLE);
            this.BOTPL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BOTPL.Location = new System.Drawing.Point(0, 912);
            this.BOTPL.Margin = new System.Windows.Forms.Padding(0);
            this.BOTPL.Name = "BOTPL";
            this.BOTPL.Size = new System.Drawing.Size(1200, 48);
            this.BOTPL.TabIndex = 0;
            // 
            // CONNECTT
            // 
            this.CONNECTT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CONNECTT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CONNECTT.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.CONNECTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CONNECTT.HoverBorderColor = System.Drawing.Color.Transparent;
            this.CONNECTT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.CONNECTT.HoverTextColor = System.Drawing.Color.White;
            this.CONNECTT.IsDerivedStyle = true;
            this.CONNECTT.Location = new System.Drawing.Point(200, 12);
            this.CONNECTT.Margin = new System.Windows.Forms.Padding(4);
            this.CONNECTT.Name = "CONNECTT";
            this.CONNECTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONNECTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONNECTT.NormalTextColor = System.Drawing.Color.White;
            this.CONNECTT.PressBorderColor = System.Drawing.Color.Transparent;
            this.CONNECTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CONNECTT.PressTextColor = System.Drawing.Color.White;
            this.CONNECTT.Size = new System.Drawing.Size(24, 24);
            this.CONNECTT.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.CONNECTT.StyleManager = null;
            this.CONNECTT.TabIndex = 8;
            this.CONNECTT.ThemeAuthor = "Taiizor";
            this.CONNECTT.ThemeName = "MetroLight";
            this.CONNECTT.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.Topleft;
            // 
            // CONTACTT
            // 
            this.CONTACTT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CONTACTT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CONTACTT.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.CONTACTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CONTACTT.HoverBorderColor = System.Drawing.Color.Transparent;
            this.CONTACTT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.CONTACTT.HoverTextColor = System.Drawing.Color.White;
            this.CONTACTT.IsDerivedStyle = true;
            this.CONTACTT.Location = new System.Drawing.Point(120, 12);
            this.CONTACTT.Margin = new System.Windows.Forms.Padding(4);
            this.CONTACTT.Name = "CONTACTT";
            this.CONTACTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONTACTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONTACTT.NormalTextColor = System.Drawing.Color.White;
            this.CONTACTT.PressBorderColor = System.Drawing.Color.Transparent;
            this.CONTACTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CONTACTT.PressTextColor = System.Drawing.Color.White;
            this.CONTACTT.Size = new System.Drawing.Size(22, 24);
            this.CONTACTT.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.CONTACTT.StyleManager = null;
            this.CONTACTT.TabIndex = 7;
            this.CONTACTT.ThemeAuthor = "Taiizor";
            this.CONTACTT.ThemeName = "MetroLight";
            this.CONTACTT.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.Topleft;
            // 
            // SETTINGT
            // 
            this.SETTINGT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SETTINGT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SETTINGT.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.SETTINGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SETTINGT.HoverBorderColor = System.Drawing.Color.Transparent;
            this.SETTINGT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.SETTINGT.HoverTextColor = System.Drawing.Color.White;
            this.SETTINGT.IsDerivedStyle = true;
            this.SETTINGT.Location = new System.Drawing.Point(72, 14);
            this.SETTINGT.Margin = new System.Windows.Forms.Padding(4);
            this.SETTINGT.Name = "SETTINGT";
            this.SETTINGT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SETTINGT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SETTINGT.NormalTextColor = System.Drawing.Color.White;
            this.SETTINGT.PressBorderColor = System.Drawing.Color.Transparent;
            this.SETTINGT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.SETTINGT.PressTextColor = System.Drawing.Color.White;
            this.SETTINGT.Size = new System.Drawing.Size(24, 22);
            this.SETTINGT.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.SETTINGT.StyleManager = null;
            this.SETTINGT.TabIndex = 6;
            this.SETTINGT.ThemeAuthor = "Taiizor";
            this.SETTINGT.ThemeName = "MetroLight";
            this.SETTINGT.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.Topleft;
            // 
            // MESSAGET
            // 
            this.MESSAGET.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MESSAGET.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.MESSAGET.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.MESSAGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MESSAGET.HoverBorderColor = System.Drawing.Color.Transparent;
            this.MESSAGET.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.MESSAGET.HoverTextColor = System.Drawing.Color.White;
            this.MESSAGET.IsDerivedStyle = true;
            this.MESSAGET.Location = new System.Drawing.Point(22, 15);
            this.MESSAGET.Margin = new System.Windows.Forms.Padding(4);
            this.MESSAGET.Name = "MESSAGET";
            this.MESSAGET.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MESSAGET.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MESSAGET.NormalTextColor = System.Drawing.Color.White;
            this.MESSAGET.PressBorderColor = System.Drawing.Color.Transparent;
            this.MESSAGET.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.MESSAGET.PressTextColor = System.Drawing.Color.White;
            this.MESSAGET.Size = new System.Drawing.Size(24, 20);
            this.MESSAGET.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.MESSAGET.StyleManager = null;
            this.MESSAGET.TabIndex = 1;
            this.MESSAGET.ThemeAuthor = "Taiizor";
            this.MESSAGET.ThemeName = "MetroLight";
            this.MESSAGET.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.Topleft;
            // 
            // MAILLLE
            // 
            this.MAILLLE.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.MAILLLE.BackColor = System.Drawing.Color.Transparent;
            this.MAILLLE.Cursor = System.Windows.Forms.Cursors.Default;
            this.MAILLLE.Dock = System.Windows.Forms.DockStyle.Right;
            this.MAILLLE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MAILLLE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MAILLLE.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.MAILLLE.LinkColor = System.Drawing.Color.SeaGreen;
            this.MAILLLE.Location = new System.Drawing.Point(929, 0);
            this.MAILLLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MAILLLE.Name = "MAILLLE";
            this.MAILLLE.Size = new System.Drawing.Size(189, 48);
            this.MAILLLE.TabIndex = 4;
            this.MAILLLE.TabStop = true;
            this.MAILLLE.Text = "fashion@shop.com";
            this.MAILLLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MAILLLE.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            // 
            // BOTPLSR
            // 
            this.BOTPLSR.BackColor = System.Drawing.Color.White;
            this.BOTPLSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BOTPLSR.Horizontal = false;
            this.BOTPLSR.Location = new System.Drawing.Point(166, 6);
            this.BOTPLSR.Margin = new System.Windows.Forms.Padding(0);
            this.BOTPLSR.Name = "BOTPLSR";
            this.BOTPLSR.Size = new System.Drawing.Size(15, 36);
            this.BOTPLSR.TabIndex = 3;
            this.BOTPLSR.Text = "lostSeparator1";
            // 
            // STATELLE
            // 
            this.STATELLE.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.STATELLE.BackColor = System.Drawing.Color.Transparent;
            this.STATELLE.Cursor = System.Windows.Forms.Cursors.Default;
            this.STATELLE.Dock = System.Windows.Forms.DockStyle.Right;
            this.STATELLE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STATELLE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.STATELLE.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.STATELLE.LinkColor = System.Drawing.Color.SeaGreen;
            this.STATELLE.Location = new System.Drawing.Point(1118, 0);
            this.STATELLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STATELLE.Name = "STATELLE";
            this.STATELLE.Size = new System.Drawing.Size(82, 48);
            this.STATELLE.TabIndex = 5;
            this.STATELLE.TabStop = true;
            this.STATELLE.Text = "Active";
            this.STATELLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.STATELLE.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.ActiveControl = null;
            this.btn_NhanVien.BackColor = System.Drawing.Color.White;
            this.btn_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.btn_NhanVien.Location = new System.Drawing.Point(38, 228);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(260, 176);
            this.btn_NhanVien.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_NhanVien.TabIndex = 12;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_NhanVien.TileImage = global::GUI.Properties.Resources.people;
            this.btn_NhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NhanVien.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_NhanVien.UseCustomBackColor = true;
            this.btn_NhanVien.UseCustomForeColor = true;
            this.btn_NhanVien.UseSelectable = true;
            this.btn_NhanVien.UseStyleColors = true;
            this.btn_NhanVien.UseTileImage = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.ActiveControl = null;
            this.btn_ThongTin.BackColor = System.Drawing.Color.White;
            this.btn_ThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongTin.Location = new System.Drawing.Point(860, 228);
            this.btn_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(260, 176);
            this.btn_ThongTin.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_ThongTin.TabIndex = 11;
            this.btn_ThongTin.Text = "Thông tin";
            this.btn_ThongTin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThongTin.TileImage = global::GUI.Properties.Resources.list;
            this.btn_ThongTin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ThongTin.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_ThongTin.UseCustomBackColor = true;
            this.btn_ThongTin.UseCustomForeColor = true;
            this.btn_ThongTin.UseSelectable = true;
            this.btn_ThongTin.UseStyleColors = true;
            this.btn_ThongTin.UseTileImage = true;
            // 
            // btn_CaiDat
            // 
            this.btn_CaiDat.ActiveControl = null;
            this.btn_CaiDat.BackColor = System.Drawing.Color.White;
            this.btn_CaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CaiDat.ForeColor = System.Drawing.Color.Black;
            this.btn_CaiDat.Location = new System.Drawing.Point(585, 228);
            this.btn_CaiDat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CaiDat.Name = "btn_CaiDat";
            this.btn_CaiDat.Size = new System.Drawing.Size(260, 176);
            this.btn_CaiDat.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_CaiDat.TabIndex = 10;
            this.btn_CaiDat.Text = "Cài đặt";
            this.btn_CaiDat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CaiDat.TileImage = global::GUI.Properties.Resources.cogwheel;
            this.btn_CaiDat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CaiDat.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_CaiDat.UseCustomBackColor = true;
            this.btn_CaiDat.UseCustomForeColor = true;
            this.btn_CaiDat.UseSelectable = true;
            this.btn_CaiDat.UseStyleColors = true;
            this.btn_CaiDat.UseTileImage = true;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.ActiveControl = null;
            this.btn_ThongKe.BackColor = System.Drawing.Color.White;
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongKe.Location = new System.Drawing.Point(310, 228);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(260, 176);
            this.btn_ThongKe.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_ThongKe.TabIndex = 9;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThongKe.TileImage = global::GUI.Properties.Resources.working;
            this.btn_ThongKe.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ThongKe.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_ThongKe.UseCustomBackColor = true;
            this.btn_ThongKe.UseCustomForeColor = true;
            this.btn_ThongKe.UseSelectable = true;
            this.btn_ThongKe.UseStyleColors = true;
            this.btn_ThongKe.UseTileImage = true;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.ActiveControl = null;
            this.btn_SanPham.BackColor = System.Drawing.Color.White;
            this.btn_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SanPham.ForeColor = System.Drawing.Color.Black;
            this.btn_SanPham.Location = new System.Drawing.Point(38, 38);
            this.btn_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(260, 176);
            this.btn_SanPham.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_SanPham.TabIndex = 8;
            this.btn_SanPham.Text = "Sản phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SanPham.TileImage = global::GUI.Properties.Resources.wardrobe;
            this.btn_SanPham.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SanPham.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_SanPham.UseCustomBackColor = true;
            this.btn_SanPham.UseCustomForeColor = true;
            this.btn_SanPham.UseSelectable = true;
            this.btn_SanPham.UseStyleColors = true;
            this.btn_SanPham.UseTileImage = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.ActiveControl = null;
            this.btn_BaoCao.BackColor = System.Drawing.Color.White;
            this.btn_BaoCao.ForeColor = System.Drawing.Color.Black;
            this.btn_BaoCao.Location = new System.Drawing.Point(860, 38);
            this.btn_BaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(260, 176);
            this.btn_BaoCao.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_BaoCao.TabIndex = 7;
            this.btn_BaoCao.Text = "Báo cáo";
            this.btn_BaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_BaoCao.TileImage = global::GUI.Properties.Resources.report1;
            this.btn_BaoCao.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BaoCao.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_BaoCao.UseCustomBackColor = true;
            this.btn_BaoCao.UseCustomForeColor = true;
            this.btn_BaoCao.UseSelectable = true;
            this.btn_BaoCao.UseStyleColors = true;
            this.btn_BaoCao.UseTileImage = true;
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.ActiveControl = null;
            this.btn_KhachHang.BackColor = System.Drawing.Color.White;
            this.btn_KhachHang.ForeColor = System.Drawing.Color.Black;
            this.btn_KhachHang.Location = new System.Drawing.Point(585, 38);
            this.btn_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(260, 176);
            this.btn_KhachHang.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_KhachHang.TabIndex = 6;
            this.btn_KhachHang.Text = "Khách hàng";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_KhachHang.TileImage = global::GUI.Properties.Resources.customer_satisfaction;
            this.btn_KhachHang.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_KhachHang.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_KhachHang.UseCustomBackColor = true;
            this.btn_KhachHang.UseCustomForeColor = true;
            this.btn_KhachHang.UseSelectable = true;
            this.btn_KhachHang.UseStyleColors = true;
            this.btn_KhachHang.UseTileImage = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.ActiveControl = null;
            this.btn_DonHang.BackColor = System.Drawing.Color.White;
            this.btn_DonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DonHang.ForeColor = System.Drawing.Color.Black;
            this.btn_DonHang.Location = new System.Drawing.Point(310, 38);
            this.btn_DonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Size = new System.Drawing.Size(260, 176);
            this.btn_DonHang.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_DonHang.TabIndex = 5;
            this.btn_DonHang.Text = "Đơn hàng";
            this.btn_DonHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DonHang.TileImage = global::GUI.Properties.Resources.trolley;
            this.btn_DonHang.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DonHang.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_DonHang.UseCustomBackColor = true;
            this.btn_DonHang.UseCustomForeColor = true;
            this.btn_DonHang.UseSelectable = true;
            this.btn_DonHang.UseStyleColors = true;
            this.btn_DonHang.UseTileImage = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // TOPPL
            // 
            this.TOPPL.BackColor = System.Drawing.Color.White;
            this.TOPPL.BackgroundImage = global::GUI.Properties.Resources.Home1__2_;
            this.TOPPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TOPPL.Controls.Add(this.MINIMIZEB);
            this.TOPPL.Controls.Add(this.CLOSEB);
            this.TOPPL.Controls.Add(this.PROTECTPB);
            this.TOPPL.Controls.Add(this.PROTECTLE);
            this.TOPPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOPPL.Location = new System.Drawing.Point(0, 0);
            this.TOPPL.Margin = new System.Windows.Forms.Padding(0);
            this.TOPPL.Name = "TOPPL";
            this.TOPPL.Size = new System.Drawing.Size(1200, 308);
            this.TOPPL.TabIndex = 1;
            this.TOPPL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            // 
            // MINIMIZEB
            // 
            this.MINIMIZEB.BackColor = System.Drawing.Color.White;
            this.MINIMIZEB.BackgroundImage = global::GUI.Properties.Resources.Minimize;
            this.MINIMIZEB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MINIMIZEB.BorderThickness = 3;
            this.MINIMIZEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MINIMIZEB.DrawBorder = false;
            this.MINIMIZEB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MINIMIZEB.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.MINIMIZEB.Image = global::GUI.Properties.Resources.Minimize;
            this.MINIMIZEB.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageOnly;
            this.MINIMIZEB.Location = new System.Drawing.Point(1056, 0);
            this.MINIMIZEB.Margin = new System.Windows.Forms.Padding(0);
            this.MINIMIZEB.Name = "MINIMIZEB";
            this.MINIMIZEB.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MINIMIZEB.PressedForeColor = System.Drawing.Color.White;
            this.MINIMIZEB.Size = new System.Drawing.Size(50, 45);
            this.MINIMIZEB.TabIndex = 14;
            this.MINIMIZEB.Click += new System.EventHandler(this.MINIMIZEB_Click);
            // 
            // CLOSEB
            // 
            this.CLOSEB.BackColor = System.Drawing.Color.White;
            this.CLOSEB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CLOSEB.BorderThickness = 3;
            this.CLOSEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLOSEB.DrawBorder = false;
            this.CLOSEB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CLOSEB.HotTrackColor = System.Drawing.Color.Crimson;
            this.CLOSEB.Image = global::GUI.Properties.Resources.Close;
            this.CLOSEB.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageOnly;
            this.CLOSEB.Location = new System.Drawing.Point(1106, 0);
            this.CLOSEB.Margin = new System.Windows.Forms.Padding(0);
            this.CLOSEB.Name = "CLOSEB";
            this.CLOSEB.PressedColor = System.Drawing.Color.Firebrick;
            this.CLOSEB.PressedForeColor = System.Drawing.Color.White;
            this.CLOSEB.Size = new System.Drawing.Size(50, 45);
            this.CLOSEB.TabIndex = 13;
            this.CLOSEB.Text = "royalButton1";
            this.CLOSEB.Click += new System.EventHandler(this.CLOSEB_Click);
            // 
            // PROTECTPB
            // 
            this.PROTECTPB.BackColor = System.Drawing.Color.Transparent;
            this.PROTECTPB.BackgroundImage = global::GUI.Properties.Resources._3685416_934__1_;
            this.PROTECTPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PROTECTPB.Location = new System.Drawing.Point(22, 44);
            this.PROTECTPB.Margin = new System.Windows.Forms.Padding(4);
            this.PROTECTPB.Name = "PROTECTPB";
            this.PROTECTPB.Size = new System.Drawing.Size(563, 238);
            this.PROTECTPB.TabIndex = 9;
            this.PROTECTPB.TabStop = false;
            this.PROTECTPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            // 
            // PROTECTLE
            // 
            this.PROTECTLE.AutoSize = true;
            this.PROTECTLE.BackColor = System.Drawing.Color.Transparent;
            this.PROTECTLE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.PROTECTLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PROTECTLE.Location = new System.Drawing.Point(634, 80);
            this.PROTECTLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PROTECTLE.Name = "PROTECTLE";
            this.PROTECTLE.Size = new System.Drawing.Size(484, 29);
            this.PROTECTLE.TabIndex = 8;
            this.PROTECTLE.Text = "Hi ! Chào bạn đến với Fashion Shop";
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 960);
            this.Controls.Add(this.FILLPL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHome";
            this.Text = "fhome";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            this.MIDPL.ResumeLayout(false);
            this.FILLPL.ResumeLayout(false);
            this.BOTPL.ResumeLayout(false);
            this.TOPPL.ResumeLayout(false);
            this.TOPPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PROTECTPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.RoyalButton MINIMIZEB;
        private ReaLTaiizor.Controls.RoyalButton CLOSEB;
        private System.Windows.Forms.PictureBox PROTECTPB;
        private ReaLTaiizor.Controls.LabelEdit PROTECTLE;
        private ReaLTaiizor.Controls.AirSeparator TOPSR;
        private ReaLTaiizor.Controls.AirSeparator BOTSR;
        private System.Windows.Forms.Panel TOPPL;
        private ReaLTaiizor.Controls.PoisonTile btn_NhanVien;
        private ReaLTaiizor.Controls.PoisonTile btn_ThongTin;
        private ReaLTaiizor.Controls.PoisonTile btn_CaiDat;
        private ReaLTaiizor.Controls.PoisonTile btn_ThongKe;
        private ReaLTaiizor.Controls.PoisonTile btn_SanPham;
        private ReaLTaiizor.Controls.PoisonTile btn_BaoCao;
        private ReaLTaiizor.Controls.PoisonTile btn_KhachHang;
        private System.Windows.Forms.Panel MIDPL;
        private ReaLTaiizor.Controls.PoisonTile btn_DonHang;
        private System.Windows.Forms.Panel FILLPL;
        private System.Windows.Forms.Panel BOTPL;
        private ReaLTaiizor.Controls.MetroTile CONNECTT;
        private ReaLTaiizor.Controls.MetroTile CONTACTT;
        private ReaLTaiizor.Controls.MetroTile SETTINGT;
        private ReaLTaiizor.Controls.MetroTile MESSAGET;
        private ReaLTaiizor.Controls.LinkLabelEdit MAILLLE;
        private ReaLTaiizor.Controls.LostSeparator BOTPLSR;
        private ReaLTaiizor.Controls.LinkLabelEdit STATELLE;
    }
}