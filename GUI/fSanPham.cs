using BUS;
using DTO;
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ textBox_TimKiem.TextButton
            string text = textBox_TimKiem.TextButton;
            // Gọi qua Product BUS để thực hiện tìm kiếm
            List<Product> result = ProductBUS.Instance.SearchProductByName(text);
            if (result.Count > 0)
            {
                foreach (Product product in result)
                {
                    Console.WriteLine(product.Name);
                }
                MessageBox.Show($"Đã tìm thấy {result.Count} sản phẩm");
            }
        }
    }
}
