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
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {

        }

        private void data_DSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fChiTietSanPham fChiTietSanPham = new fChiTietSanPham();
            fChiTietSanPham.ShowDialog();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            fThemSanPham fThemSanPham = new fThemSanPham();
            fThemSanPham.ShowDialog();
        }
    }
}
