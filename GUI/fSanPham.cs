using BUS;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Data;

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
            foreach (DataGridViewColumn column in data_DSSanPham.Columns)
            {
                bool hasData = false;

                // Kiểm tra nếu cột có bất kỳ dòng dữ liệu nào
                foreach (DataGridViewRow row in data_DSSanPham.Rows)
                {
                    if (row.Cells[column.Name].Value != DBNull.Value && row.Cells[column.Name].Value != null)
                    {
                        hasData = true;
                        break;
                    }
                }

                // Nếu cột không có dữ liệu, ẩn cột đó
                column.Visible = hasData;
            }
        }

        public void LoadComboBoxCategories()
        {
            DataTable categories = ProductBUS.Instance.GetAllCategories();
            comboBox.DataSource = categories;
            comboBox.DisplayMember = "TenLoaiSP"; // Hiển thị TenLoaiSP trong ComboBox
            comboBox.ValueMember = "MaLoaiSP";    // Giá trị là MaLoaiSP
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

        private void fThemSanPham_ProductAdded(object sender, EventArgs e)
        {
            // Sau khi thêm sản phẩm, gọi lại LoadProducts để làm mới danh sách
            LoadProducts();
        }

        private void fChiTietSanPham_ProductDeleted(object sender, EventArgs e)
        {
            // Sau khi xoasản phẩm, gọi lại LoadProducts để làm mới danh sách
            LoadProducts();
        }


        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            fThemSanPham fThemSanPham = new fThemSanPham();
            fThemSanPham.ProductAdded += fThemSanPham_ProductAdded;
            fThemSanPham.ShowDialog();

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
                fChiTietSanPham.ProductDeleted += fChiTietSanPham_ProductDeleted;
                fChiTietSanPham.ShowDialog();
            }
        }

        private void data_DSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSP = data_DSSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                fChiTietSanPham fChiTietSanPham = new fChiTietSanPham(maSP);
                fChiTietSanPham.ProductDeleted += fChiTietSanPham_ProductDeleted;
                fChiTietSanPham.ShowDialog();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                string maLoaiSP = comboBox.SelectedValue.ToString();

                try
                {
                    List<Product> filteredProducts = ProductBUS.Instance.LocSanPhamTheoLoai(maLoaiSP);
                    data_DSSanPham.DataSource = filteredProducts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}