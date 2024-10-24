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
            Account account = new Account(textBox_Email.Text, textBox_MatKhau.Text);
            try
            {
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Log.WriteLog("----------" + account.MaNV + " log in ----------");

                    Account acc = AccountBUS.Instance.GetAccountByMaNV(account.MaNV);

                    fHome form = new fHome(acc);
                    this.Hide();
                    form.ShowDialog();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Nếu không có logic vẽ gì, bạn có thể để trống hoặc loại bỏ hoàn toàn sự kiện này
        }
    }
}
