using BUS;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

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

        private void LoadProducts()
        {
            List<Product> products = ProductBUS.Instance.GetAllProducts();

            data_DSSanPham.DataSource = products;
        }

        private void LoadComboBoxCategories()
        {
            List<string> categories = ProductBUS.Instance.GetAllCategories();
            comboBox.DataSource = categories;
            comboBox.SelectedIndex = -1;
        }

        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                string selectedCategory = comboBox.SelectedItem.ToString();

                try
                {
                    List<Product> filteredProducts = ProductBUS.Instance.GetListProductByCategory(selectedCategory);
                    data_DSSanPham.DataSource = filteredProducts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            fThemSanPham fThemSanPham = new fThemSanPham();
            fThemSanPham.ShowDialog();
            LoadProducts();
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string text = textBox_timkiem.Text;

            try
            {
                List<Product> result = ProductBUS.Instance.SearchProductByNameOrCode(text);
                if (result.Count > 0)
                {
                    this.data_DSSanPham.DataSource = result;
                    MessageBox.Show($"Đã tìm thấy {result.Count} sản phẩm");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi !");
            }
        }
        private void data_DSSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSP = data_DSSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();

                fChiTietSanPham fChiTietSanPham = new fChiTietSanPham(maSP);
                fChiTietSanPham.ShowDialog();
            }
        }

        private void data_DSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSP = data_DSSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                fChiTietSanPham fChiTietSanPham = new fChiTietSanPham(maSP);
                fChiTietSanPham.ShowDialog();
            }
        }
    }
}
