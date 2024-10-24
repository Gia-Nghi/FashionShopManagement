using BUS;
using DTO;
using System;
using System.Collections.Generic;
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
            LoadComboBoxCategories(); 
            LoadProducts();
        }

        // Tải dữ liệu sản phẩm vào DataGridView
        private void LoadProducts()
        {
            List<Product> products = ProductBUS.Instance.GetAllProducts();
            data_DSSanPham.DataSource = products; // Giả sử data_DSDonHang là DataGridView
        }

        // Tải các loại sản phẩm vào ComboBox
        private void LoadComboBoxCategories()
        {
            List<string> categories = ProductBUS.Instance.GetAllCategories(); // Phương thức để lấy danh sách loại sản phẩm
            aloneComboBox1.DataSource = categories; // Giả sử aloneComboBox1 là ComboBox
            aloneComboBox1.SelectedIndex = -1; // Không chọn mục nào khi vừa tải ComboBox
        }

        // Khi chọn một loại sản phẩm từ ComboBox, lọc sản phẩm theo loại đó
        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aloneComboBox1.SelectedIndex >= 0)
            {
                string selectedCategory = aloneComboBox1.SelectedItem.ToString();
                List<Product> filteredProducts = ProductBUS.Instance.GetListProductByCategory(selectedCategory);
                data_DSSanPham.DataSource = filteredProducts;
            }
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            fThemSanPham fThemSanPham = new fThemSanPham();
            fThemSanPham.ShowDialog();
            LoadProducts(); // Tải lại sản phẩm sau khi thêm
        }
        private void textBox_TimKiem_Load(object sender, EventArgs e)
        {

        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ textBox_TimKiem.TextButton
            string text = textBox_TimKiem.TextButton;

            try
            {
                // Gọi qua Product BUS để thực hiện tìm kiếm
                List<Product> result = ProductBUS.Instance.SearchProductByNameOrCode(text);
                if (result.Count > 0)
                {
                    this.data_DSSanPham.DataSource = result;
                    foreach (Product product in result)
                    {
                        Console.WriteLine(product.Name);
                    }
                    MessageBox.Show($"Đã tìm thấy {result.Count} sản phẩm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi !");
            }
        }

        private void data_DSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                fChiTietSanPham fChiTietSanPham = new fChiTietSanPham();
                fChiTietSanPham.ShowDialog();
            }
        }

        private void data_DSSanPham_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fChiTietSanPham fChiTietSanPham = new fChiTietSanPham();
                fChiTietSanPham.ShowDialog();
            }
        }
    }
}
