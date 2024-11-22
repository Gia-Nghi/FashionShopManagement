using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void DangNhap()
        {
            if (string.IsNullOrWhiteSpace(textBox_Email.Text) || string.IsNullOrWhiteSpace(textBox_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên và mật khẩu.");
                return;
            }

            // Tạo đối tượng Account với thông tin mã nhân viên và mật khẩu người dùng nhập
            Account account = new Account(textBox_Email.Text, textBox_MatKhau.Text);

            try
            {
                // Kiểm tra đăng nhập
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Log.WriteLog("----------" + account.MaNV + " log in ----------");

                    // Lấy thông tin đầy đủ của tài khoản từ cơ sở dữ liệu
                    Account acc = AccountBUS.Instance.GetAccountByMaNV(account.MaNV);

                    // Truyền đối tượng Account vào fHome
                    fHome form = new fHome(acc);

                    // Ẩn form đăng nhập và mở form fHome
                    this.Hide();
                    form.ShowDialog();

                    // Sau khi fHome đóng, hiện lại fLogin
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mã nhân viên hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void textBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
    }
}
