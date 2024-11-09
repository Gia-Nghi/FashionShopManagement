using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTaoDonHang : Form
    {
        private string connectionString = @"Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";
        public fTaoDonHang()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MaSP, TenSP FROM SanPham", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maSP = reader["MaSP"].ToString();
                    string tenSP = reader["TenSP"].ToString();
                    comboBox_SanPham.Items.Add(new ComboBoxItem(maSP, tenSP));
                }
                reader.Close();
            }
        }

        private void comboBox_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SanPham.SelectedItem is ComboBoxItem selectedItem)
            {
                string maSP = selectedItem.MaSP;


            }
        }
            private void btn_Them_Click(object sender, EventArgs e)
        {
            int soLuong;
            if (!int.TryParse(TextBoxSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            if (comboBox_SanPham.SelectedItem is ComboBoxItem selectedItem)
            {
                string maSP = selectedItem.MaSP;
                string tenSP = selectedItem.TenSP;
                decimal donGia;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT DonGia FROM SanPham WHERE MaSP = @MaSP", connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    donGia = (decimal)command.ExecuteScalar();
                }

                decimal thanhTien = soLuong * donGia;
                data_DSSanPham.Rows.Add(maSP, tenSP, donGia, soLuong, thanhTien);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (data_DSSanPham.SelectedRows.Count > 0)
            {
                data_DSSanPham.Rows.RemoveAt(data_DSSanPham.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maKhachHang = textBox_MaKhachHang.Text.Trim();
            string tenKhachHang = TextBoxTenKH.Text.Trim();
            string sdtKhachHang = TextBox_SDT.Text.Trim();
     
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand commandKH = new SqlCommand("IF NOT EXISTS (SELECT * FROM KhachHang WHERE SDT = @SDT) " +
                                                       "INSERT INTO KhachHang (MaKH, TenKH, SDT) VALUES (@MaKH, @TenKH, @SDT) " +
                                                       "ELSE UPDATE KhachHang SET TenKH = @TenKH, WHERE SDT = @SDT", connection);
                commandKH.Parameters.AddWithValue("@MaKH", maKhachHang);
                commandKH.Parameters.AddWithValue("@TenKH", tenKhachHang);
                commandKH.Parameters.AddWithValue("@SDT", sdtKhachHang);
                commandKH.ExecuteNonQuery();
                string maHD = TextBoxMaHD.Text; 
                string maNV = textBox_MaNV.Text;
                decimal triGiaHD = 0;

                foreach (DataGridViewRow row in data_DSSanPham.Rows)
                {
                    triGiaHD += Convert.ToDecimal(row.Cells["Thành tiền"].Value);
                }

                SqlCommand commandHD = new SqlCommand("INSERT INTO HoaDon (MaHD, Ngay, MaKH, MaNV, TriGiaHD) VALUES (@MaHD, @Ngay, @MaKH, @MaNV, @TriGiaHD)", connection);
                commandHD.Parameters.AddWithValue("@MaHD", maHD);
                commandHD.Parameters.AddWithValue("@Ngay", DateTime.Now);
                commandHD.Parameters.AddWithValue("@MaKH", maKhachHang);
                commandHD.Parameters.AddWithValue("@MaNV", maNV);
                commandHD.Parameters.AddWithValue("@TriGiaHD", triGiaHD);
                commandHD.ExecuteNonQuery();


                foreach (DataGridViewRow row in data_DSSanPham.Rows)
                {
                    string maSP = row.Cells["Mã SP"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["Số lượng"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["Đơn giá"].Value);
                    decimal tongTien = Convert.ToDecimal(row.Cells["Thành tiền"].Value);

                    SqlCommand commandCTHD = new SqlCommand("INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia, TongTien) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia, @TongTien)", connection);
                    commandCTHD.Parameters.AddWithValue("@MaHD", maHD);
                    commandCTHD.Parameters.AddWithValue("@MaSP", maSP);
                    commandCTHD.Parameters.AddWithValue("@SoLuong", soLuong);
                    commandCTHD.Parameters.AddWithValue("@DonGia", donGia);
                    commandCTHD.Parameters.AddWithValue("@TongTien", tongTien);
                    commandCTHD.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in data_DSSanPham.Rows)
                {
                    string maSP = row.Cells["Mã SP"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["Số lượng"].Value);

                    SqlCommand commandUpdateSP = new SqlCommand("UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE MaSP = @MaSP", connection);
                    commandUpdateSP.Parameters.AddWithValue("@SoLuong", soLuong);
                    commandUpdateSP.Parameters.AddWithValue("@MaSP", maSP);
                    commandUpdateSP.ExecuteNonQuery();
                }

                MessageBox.Show("Lưu hóa đơn thành công!");
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void btn_TraCuuSDT_Click(object sender, EventArgs e)
        {
            string sdt = TextBox_SDT.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MaKH, TenKH FROM KhachHang WHERE SDT = @SDT", connection);
                command.Parameters.AddWithValue("@SDT", sdt);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox_MaKhachHang.Text = reader["MaKH"].ToString();
                    TextBoxTenKH.Text = reader["TenKH"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
                }
                reader.Close();
            }
        }

        private void data_DSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_DSSanPham.Rows[e.RowIndex];
                string maSP = selectedRow.Cells["Mã SP"].Value.ToString();
                string tenSP = selectedRow.Cells["Tên SP"].Value.ToString();
                string donGia = selectedRow.Cells["Đơn giá"].Value.ToString();
                string soLuong = selectedRow.Cells["Số lượng"].Value.ToString();
                string thanhTien = selectedRow.Cells["Thành tiền"].Value.ToString();

                MessageBox.Show($"Mã SP: {maSP}\nTên SP: {tenSP}\nĐơn giá: {donGia}\nSố lượng: {soLuong}\nThành tiền: {thanhTien}");
            }
        }

    }

    public class ComboBoxItem
    {
        public string MaSP { get; }
        public string TenSP { get; }

        public ComboBoxItem(string maSP, string tenSP)
        {
            MaSP = maSP;
            TenSP = tenSP;
        }

        public override string ToString()
        {
            return $"{MaSP} - {TenSP}";
        }
    }
}
