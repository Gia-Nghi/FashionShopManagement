using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class fNhanVien : Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public fNhanVien()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            DataTable dataTable = nhanVienBUS.GetAllNhanVien();
            poisonDataGridView1.DataSource = dataTable;
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

            try
            {
                NhanVienDTO newNhanVien = new NhanVienDTO(
                    textBoxMaNV.Text,
                    textBox_Ho.Text,
                    TextBox_Ten.Text,
                    dateTimeNgaySinh.Value,
                    comboBoxGioiTinh.SelectedItem.ToString(),
                    TextBox_DiaChi.Text,
                    dateTimeNgayTuyenDung.Value,
                    0,
                    0,
                    textBox_MaCV.Text,
                    cyberTextBoxSDT.Text,
                    cybelPassword.Text
                );

                nhanVienBUS.AddNhanVien(newNhanVien);
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để cập nhật.");
                return;
            }

            try
            {
                NhanVienDTO updatedNhanVien = new NhanVienDTO(
                    textBoxMaNV.Text,
                    textBox_Ho.Text,
                    TextBox_Ten.Text,
                    dateTimeNgaySinh.Value,
                    comboBoxGioiTinh.SelectedItem.ToString(),
                    TextBox_DiaChi.Text,
                    dateTimeNgayTuyenDung.Value,
                    int.Parse(TextBoxSoCa.Text),
                    0,
                    textBox_MaCV.Text,
                    cyberTextBoxSDT.Text,
                    cybelPassword.Text
                );

                nhanVienBUS.UpdateNhanVien(updatedNhanVien);
                MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên để xóa.");
                    return;
                }

                nhanVienBUS.DeleteNhanVien(textBoxMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
