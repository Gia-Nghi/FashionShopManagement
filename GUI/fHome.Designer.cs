namespace GUI
{
    partial class fHome
    {

        private System.ComponentModel.IContainer components = null;


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
            this.MIDPL = new System.Windows.Forms.Panel();
            this.btn_NhanVien = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_PhanCa = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_SanPham = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_BaoCao = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_KhachHang = new ReaLTaiizor.Controls.PoisonTile();
            this.btn_DonHang = new ReaLTaiizor.Controls.PoisonTile();
            this.FILLPL = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.image_Banner = new System.Windows.Forms.PictureBox();
            this.PROTECTLE = new ReaLTaiizor.Controls.LabelEdit();
            this.BOTPL = new System.Windows.Forms.Panel();
            this.CONNECTT = new ReaLTaiizor.Controls.MetroTile();
            this.CONTACTT = new ReaLTaiizor.Controls.MetroTile();
            this.SETTINGT = new ReaLTaiizor.Controls.MetroTile();
            this.MESSAGET = new ReaLTaiizor.Controls.MetroTile();
            this.MAILLLE = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.BOTPLSR = new ReaLTaiizor.Controls.LostSeparator();
            this.STATELLE = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.MIDPL.SuspendLayout();
            this.FILLPL.SuspendLayout();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Banner)).BeginInit();
            this.BOTPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // MIDPL
            // 
            this.MIDPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MIDPL.Controls.Add(this.btn_NhanVien);
            this.MIDPL.Controls.Add(this.btn_PhanCa);
            this.MIDPL.Controls.Add(this.btn_SanPham);
            this.MIDPL.Controls.Add(this.btn_BaoCao);
            this.MIDPL.Controls.Add(this.btn_KhachHang);
            this.MIDPL.Controls.Add(this.btn_DonHang);
            this.MIDPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MIDPL.Location = new System.Drawing.Point(0, 161);
            this.MIDPL.Margin = new System.Windows.Forms.Padding(0);
            this.MIDPL.Name = "MIDPL";
            this.MIDPL.Size = new System.Drawing.Size(776, 347);
            this.MIDPL.TabIndex = 6;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.ActiveControl = null;
            this.btn_NhanVien.BackColor = System.Drawing.Color.White;
            this.btn_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.btn_NhanVien.Location = new System.Drawing.Point(34, 182);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(231, 141);
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
            // btn_PhanCa
            // 
            this.btn_PhanCa.ActiveControl = null;
            this.btn_PhanCa.BackColor = System.Drawing.Color.White;
            this.btn_PhanCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhanCa.ForeColor = System.Drawing.Color.Black;
            this.btn_PhanCa.Location = new System.Drawing.Point(520, 182);
            this.btn_PhanCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_PhanCa.Name = "btn_PhanCa";
            this.btn_PhanCa.Size = new System.Drawing.Size(231, 141);
            this.btn_PhanCa.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.btn_PhanCa.TabIndex = 10;
            this.btn_PhanCa.Text = "Phân ca";
            this.btn_PhanCa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_PhanCa.TileImage = global::GUI.Properties.Resources.working;
            this.btn_PhanCa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PhanCa.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.btn_PhanCa.UseCustomBackColor = true;
            this.btn_PhanCa.UseCustomForeColor = true;
            this.btn_PhanCa.UseSelectable = true;
            this.btn_PhanCa.UseStyleColors = true;
            this.btn_PhanCa.UseTileImage = true;
            this.btn_PhanCa.Click += new System.EventHandler(this.btn_PhanCa_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.ActiveControl = null;
            this.btn_SanPham.BackColor = System.Drawing.Color.White;
            this.btn_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SanPham.ForeColor = System.Drawing.Color.Black;
            this.btn_SanPham.Location = new System.Drawing.Point(34, 30);
            this.btn_SanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(231, 141);
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
            this.btn_BaoCao.Location = new System.Drawing.Point(276, 182);
            this.btn_BaoCao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(231, 141);
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
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.ActiveControl = null;
            this.btn_KhachHang.BackColor = System.Drawing.Color.White;
            this.btn_KhachHang.ForeColor = System.Drawing.Color.Black;
            this.btn_KhachHang.Location = new System.Drawing.Point(520, 30);
            this.btn_KhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(231, 141);
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
            this.btn_DonHang.Location = new System.Drawing.Point(276, 30);
            this.btn_DonHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Size = new System.Drawing.Size(231, 141);
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
            // FILLPL
            // 
            this.FILLPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.FILLPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FILLPL.Controls.Add(this.MIDPL);
            this.FILLPL.Controls.Add(this.panel_Top);
            this.FILLPL.Controls.Add(this.BOTPL);
            this.FILLPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FILLPL.Location = new System.Drawing.Point(0, 0);
            this.FILLPL.Margin = new System.Windows.Forms.Padding(0);
            this.FILLPL.Name = "FILLPL";
            this.FILLPL.Size = new System.Drawing.Size(776, 546);
            this.FILLPL.TabIndex = 5;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.BackgroundImage = global::GUI.Properties.Resources.Home1__2_;
            this.panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Top.Controls.Add(this.image_Banner);
            this.panel_Top.Controls.Add(this.PROTECTLE);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(776, 161);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            // 
            // image_Banner
            // 
            this.image_Banner.BackColor = System.Drawing.Color.Transparent;
            this.image_Banner.BackgroundImage = global::GUI.Properties.Resources._3685416_934__1_;
            this.image_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_Banner.Location = new System.Drawing.Point(20, 10);
            this.image_Banner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.image_Banner.Name = "image_Banner";
            this.image_Banner.Size = new System.Drawing.Size(436, 135);
            this.image_Banner.TabIndex = 9;
            this.image_Banner.TabStop = false;
            this.image_Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            // 
            // PROTECTLE
            // 
            this.PROTECTLE.BackColor = System.Drawing.Color.Transparent;
            this.PROTECTLE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.PROTECTLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PROTECTLE.Location = new System.Drawing.Point(474, 46);
            this.PROTECTLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PROTECTLE.Name = "PROTECTLE";
            this.PROTECTLE.Size = new System.Drawing.Size(277, 62);
            this.PROTECTLE.TabIndex = 8;
            this.PROTECTLE.Text = "Hi ! Chào bạn đến với Fashion Shop";
            this.PROTECTLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BOTPL.Location = new System.Drawing.Point(0, 508);
            this.BOTPL.Margin = new System.Windows.Forms.Padding(0);
            this.BOTPL.Name = "BOTPL";
            this.BOTPL.Size = new System.Drawing.Size(776, 38);
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
            this.CONNECTT.Location = new System.Drawing.Point(178, 10);
            this.CONNECTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CONNECTT.Name = "CONNECTT";
            this.CONNECTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONNECTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONNECTT.NormalTextColor = System.Drawing.Color.White;
            this.CONNECTT.PressBorderColor = System.Drawing.Color.Transparent;
            this.CONNECTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CONNECTT.PressTextColor = System.Drawing.Color.White;
            this.CONNECTT.Size = new System.Drawing.Size(21, 19);
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
            this.CONTACTT.Location = new System.Drawing.Point(107, 10);
            this.CONTACTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CONTACTT.Name = "CONTACTT";
            this.CONTACTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONTACTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CONTACTT.NormalTextColor = System.Drawing.Color.White;
            this.CONTACTT.PressBorderColor = System.Drawing.Color.Transparent;
            this.CONTACTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.CONTACTT.PressTextColor = System.Drawing.Color.White;
            this.CONTACTT.Size = new System.Drawing.Size(20, 19);
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
            this.SETTINGT.Location = new System.Drawing.Point(64, 11);
            this.SETTINGT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SETTINGT.Name = "SETTINGT";
            this.SETTINGT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SETTINGT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SETTINGT.NormalTextColor = System.Drawing.Color.White;
            this.SETTINGT.PressBorderColor = System.Drawing.Color.Transparent;
            this.SETTINGT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.SETTINGT.PressTextColor = System.Drawing.Color.White;
            this.SETTINGT.Size = new System.Drawing.Size(21, 18);
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
            this.MESSAGET.Location = new System.Drawing.Point(20, 12);
            this.MESSAGET.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MESSAGET.Name = "MESSAGET";
            this.MESSAGET.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MESSAGET.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MESSAGET.NormalTextColor = System.Drawing.Color.White;
            this.MESSAGET.PressBorderColor = System.Drawing.Color.Transparent;
            this.MESSAGET.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.MESSAGET.PressTextColor = System.Drawing.Color.White;
            this.MESSAGET.Size = new System.Drawing.Size(21, 16);
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
            this.MAILLLE.Location = new System.Drawing.Point(535, 0);
            this.MAILLLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MAILLLE.Name = "MAILLLE";
            this.MAILLLE.Size = new System.Drawing.Size(168, 38);
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
            this.BOTPLSR.Location = new System.Drawing.Point(148, 5);
            this.BOTPLSR.Margin = new System.Windows.Forms.Padding(0);
            this.BOTPLSR.Name = "BOTPLSR";
            this.BOTPLSR.Size = new System.Drawing.Size(13, 29);
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
            this.STATELLE.Location = new System.Drawing.Point(703, 0);
            this.STATELLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STATELLE.Name = "STATELLE";
            this.STATELLE.Size = new System.Drawing.Size(73, 38);
            this.STATELLE.TabIndex = 5;
            this.STATELLE.TabStop = true;
            this.STATELLE.Text = "Active";
            this.STATELLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.STATELLE.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 546);
            this.Controls.Add(this.FILLPL);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng thời trang";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MOVE_MouseDown);
            this.MIDPL.ResumeLayout(false);
            this.FILLPL.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_Banner)).EndInit();
            this.BOTPL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox image_Banner;
        private ReaLTaiizor.Controls.LabelEdit PROTECTLE;
        private System.Windows.Forms.Panel panel_Top;
        private ReaLTaiizor.Controls.PoisonTile btn_NhanVien;
        private ReaLTaiizor.Controls.PoisonTile btn_PhanCa;
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