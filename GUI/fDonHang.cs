using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fDonHang : Form
    {
        public fDonHang()
        {
            InitializeComponent();
        }

        private void fDonHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_TaoDon_Click(object sender, EventArgs e)
        {
            fTaoDonHang fTaoDonHang = new fTaoDonHang();
            fTaoDonHang.ShowDialog();
        }

        private void data_DSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin row được chọn
            //var selectedRow = (sender as DataGridViewRow).Selected;

            fChiTietHoaDon fChiTietHoaDon = new fChiTietHoaDon();
            fChiTietHoaDon.ShowDialog();
        }

        private void data_DSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin row được chọn
            //var selectedRow = (sender as DataGridViewRow).Selected;

            fChiTietHoaDon fChiTietHoaDon = new fChiTietHoaDon();
            fChiTietHoaDon.ShowDialog();
        }
    }
}
