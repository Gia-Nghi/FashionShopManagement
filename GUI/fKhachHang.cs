using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class fKhachHang : Form
    {
        private string connectionString = @"Data Source=LAPTOP-MDC7IR39\SA;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";

        public fKhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangData();
        }

        private void LoadKhachHangData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    DataGridViewKH.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message);
                }
            }
        }

        private void DataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewKH.Rows[e.RowIndex];

                textBox_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                textBox_TenKH.Text = row.Cells["TenKH"].Value.ToString();
                TextBox_SDT.Text = row.Cells["SDT"].Value.ToString();
                TextBox_DiemTichLuy.Text = row.Cells["DiemTL"].Value.ToString();
            }
        }
    }
}
