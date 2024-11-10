using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChiTietSanPham : Form
    {
        public fChiTietSanPham(string maSP)
        {
            InitializeComponent();
            LoadSanPham(maSP);
        }

        private void LoadSanPham(string maSP)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                string query = "SELECT * FROM ChiTietSanPhamView WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label_TenSanPham.Text = reader["TenSP"].ToString();
                            labelGiaSP.Text = $"{reader["DonGia"]:C} VNĐ";
                            labelSoLuong.Text = $"Số lượng: {reader["SL"]}";
                            labelSIZE.Text = $"Kích cỡ: {reader["Size"]}";
                            labelLoaiSP.Text = $"Loại sản phẩm: {reader["TenLoaiSP"]}";
                            labelNhaCungCap.Text = $"Nhà cung cấp: {reader["NhaCungCap"]}";
                        }
                    }
                }
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