using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHome : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fHome(Account loginAccount)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.LoginAccount = loginAccount;
            lbMaNV.Text = "Mã NV: " + this.LoginAccount.MaNV;
        }

        private void MOVE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SCANT_Click(object sender, EventArgs e)
        {

        }

        private void MINIMIZEB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CLOSEB_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }


        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            fSanPham fSanPham = new fSanPham(); 
            fSanPham.Show();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            fDonHang fDonHang = new fDonHang();
            fDonHang.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            fKhachHang.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien fNhanVien = new fNhanVien();
            fNhanVien.Show();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btn_PhanCa_Click(object sender, EventArgs e)
        {
            fPhanCa fPhanCa = new fPhanCa();
            fPhanCa.Show();
        }
    }
}
