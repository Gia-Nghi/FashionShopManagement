using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fNhanVien : Form
    {
        private string connectionString = @"Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";

        public fNhanVien()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM V_ThongTinNhanVien";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    poisonDataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNV.Text) ||
                string.IsNullOrWhiteSpace(textBox_Ho.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Ten.Text) ||
                string.IsNullOrWhiteSpace(cyberTextBoxSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ThemNhanVien", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
                    cmd.Parameters.AddWithValue("@HoNV", textBox_Ho.Text);
                    cmd.Parameters.AddWithValue("@TenNV", TextBox_Ten.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", TextBox_DiaChi.Text);
                    cmd.Parameters.AddWithValue("@NgayTuyenDung", dateTimeNgayTuyenDung.Value);
                    cmd.Parameters.AddWithValue("@SoCa",0);
                    cmd.Parameters.AddWithValue("@Thuong", 0);
                    cmd.Parameters.AddWithValue("@MaCV", textBox_MaCV.Text);
                    cmd.Parameters.AddWithValue("@SDT", cyberTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Password", cybelPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadData();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để cập nhật.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("CapNhatNhanVien", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
                    cmd.Parameters.AddWithValue("@HoNV", textBox_Ho.Text);
                    cmd.Parameters.AddWithValue("@TenNV", TextBox_Ten.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", TextBox_DiaChi.Text);
                    cmd.Parameters.AddWithValue("@NgayTuyenDung", dateTimeNgayTuyenDung.Value);
                    cmd.Parameters.AddWithValue("@SoCa", TextBoxSoCa.Text);
                    cmd.Parameters.AddWithValue("@MaCV", textBox_MaCV.Text);
                    cmd.Parameters.AddWithValue("@SDT", cyberTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Password", cybelPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadData();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xóa.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("XoaNhanVien", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số @MaNV vào câu lệnh
                    cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadData(); // Cập nhật lại dữ liệu sau khi xóa
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cyberTextBoxMaNV_Load(object sender, EventArgs e)
        {

        }
    }
}
