using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fChiTietSanPham : Form
    {
        private ChiTietSanPhamBUS bll;
        private ProductBUS productBUS;
        private string maSP;
        public event EventHandler ProductDeleted;


        public fChiTietSanPham(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
            bll = new ChiTietSanPhamBUS();
            productBUS = new ProductBUS();
            LoadSanPham(maSP);
            
        }


        private void LoadSanPham(string maSP)
        {
            DataTable sanPhamData = bll.GetChiTietSanPhamByMaSP(maSP);
            if (sanPhamData.Rows.Count > 0)
            {
                DataRow row = sanPhamData.Rows[0];
                //label_TenSanPham.Text = row["TenSP"].ToString();
                textBox_Ten.Text = row["TenSP"].ToString();
                textBox_Gia.Text = row["DonGia"].ToString();
                textBox_SL.Text = row["SL"].ToString();
                textBox_Size.Text = row["Size"].ToString();
                comboBox_LSP.Text = row["TenLoaiSP"].ToString();
                comboBox_NCC.Text = row["NhaCungCap"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadComboBoxCategories()
        {
            DataTable categories = ProductBUS.Instance.GetAllCategories();
            comboBox_LSP.DataSource = categories;
            comboBox_LSP.DisplayMember = "TenLoaiSP"; // Hiển thị TenLoaiSP trong ComboBox
            comboBox_LSP.ValueMember = "MaLoaiSP";    // Giá trị là MaLoaiSP
        }

        public void LoadComboBoxSupplier()
        {
            DataTable categories = ProductBUS.Instance.GetAllSupplier();
            comboBox_NCC.DataSource = categories;
            comboBox_NCC.DisplayMember = "TenNCC"; // Hiển thị TenLoaiSP trong ComboBox
            comboBox_NCC.ValueMember = "MaNCC";    // Giá trị là MaLoaiSP
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                Product sanPham = new Product()
                {
                    MaSP = maSP,
                    TenSP = textBox_Ten.Text,
                    DonGia = decimal.Parse(textBox_Gia.Text),
                    SL = int.Parse(textBox_SL.Text),
                    Size = textBox_Size.Text,
                    //MaLoaiSP = textBox_LSP.Text, // Giả sử bạn đã có mã loại sản phẩm tại đây
                    //MaNCC = textBox_NCC.Text // Giả sử bạn đã có mã nhà cung cấp tại đây
                    MaLoaiSP = comboBox_LSP.SelectedValue.ToString(),
                    MaNCC = comboBox_NCC.SelectedValue.ToString(),
                };

                // Gọi phương thức cập nhật từ ProductBUS
                if (productBUS.ChinhSuaSanPham(sanPham))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã sản phẩm có phải là null hoặc rỗng không
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Thoát nếu mã sản phẩm không hợp lệ
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức xóa sản phẩm
                if (productBUS.XoaSanPham(maSP))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    ProductDeleted?.Invoke(this, EventArgs.Empty);
                    this.Close(); // Đóng form chi tiết
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
        }

        private void comboBox_LSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LSP.SelectedIndex >= 0)
            {
                string maLoaiSP = comboBox_LSP.SelectedValue.ToString();

            }
        }

        private void comboBox_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_NCC.SelectedIndex >= 0)
            {
                string maNCC = comboBox_NCC.SelectedValue.ToString();

            }
        }

        private void comboBox_LSP_Click(object sender, EventArgs e)
        {
            LoadComboBoxCategories();
        }

        private void comboBox_NCC_Click(object sender, EventArgs e)
        {
            LoadComboBoxSupplier();
        }
    }
}
