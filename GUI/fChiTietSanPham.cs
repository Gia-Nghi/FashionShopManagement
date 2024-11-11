using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class fChiTietSanPham : Form
    {
        private ChiTietSanPhamBUS bll;

        public fChiTietSanPham(string maSP)
        {
            InitializeComponent();
            bll = new ChiTietSanPhamBUS();
            LoadSanPham(maSP);
        }

        private void LoadSanPham(string maSP)
        {
            DataTable sanPhamData = bll.GetChiTietSanPhamByMaSP(maSP);
            if (sanPhamData.Rows.Count > 0)
            {
                DataRow row = sanPhamData.Rows[0];
                label_TenSanPham.Text = row["TenSP"].ToString();
                labelGiaSP.Text = $"{row["DonGia"]:C} VNĐ";
                labelSoLuong.Text = $"Số lượng: {row["SL"]}";
                labelSIZE.Text = $"Kích cỡ: {row["Size"]}";
                labelLoaiSP.Text = $"Loại sản phẩm: {row["TenLoaiSP"]}";
                labelNhaCungCap.Text = $"Nhà cung cấp: {row["NhaCungCap"]}";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
