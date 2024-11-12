using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fPhanCa : Form
    {
        private CaLamViecBUS caLamViecBUS = new CaLamViecBUS();

        public fPhanCa()
        {
            InitializeComponent();
            LoadCaLamViec();
        }

        private void LoadCaLamViec()
        {
            List<CaLamViecDTO> list = caLamViecBUS.GetAllCaLamViec();
            dgvCaLamViec.DataSource = list;

            dgvCaLamViec.Columns["HoTenNV"].Width = 200;
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            try
            {
                string maCa = txtMaCa.Text;
                string maNV = txtMaNV.Text;
                DateTime ngayLam = dtpNgayLam.Value;
                if (caLamViecBUS.AddCaLamViec(maCa, ngayLam, maNV))
                {
                    MessageBox.Show("Thêm ca làm việc thành công!");
                    LoadCaLamViec();
                }
                else
                {
                    MessageBox.Show("Thêm ca làm việc không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            try
            {
                string maCa = txtMaCa.Text;
                string maNV = txtMaNV.Text;
                DateTime ngayLam = dtpNgayLam.Value;

                if (string.IsNullOrEmpty(maCa) || string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để xóa ca.");
                    return;
                }

                if (caLamViecBUS.DeleteCaLamViec(maCa, ngayLam, maNV))
                {
                    MessageBox.Show("Xóa ca làm việc thành công!");
                    LoadCaLamViec();
                }
                else
                {
                    MessageBox.Show("Xóa ca làm việc không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            try
            {
                string maCa = txtMaCa.Text;
                DateTime ngayLam = dtpNgayLam.Value;
                string maNV = txtMaNV.Text;
                FormSuaCa formSuaCa = new FormSuaCa(maCa, ngayLam, maNV);

                if (formSuaCa.ShowDialog() == DialogResult.OK)
                {
                    string newMaCa = formSuaCa.NewMaCa;
                    string newMaNV = formSuaCa.NewMaNV;
                    DateTime newNgayLam = formSuaCa.NewNgayLam;

                    if (caLamViecBUS.UpdateCaLamViec(maCa, ngayLam, maNV, newMaCa, newMaNV, newNgayLam))
                    {
                        MessageBox.Show("Cập nhật ca làm việc thành công!");
                        LoadCaLamViec();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật ca làm việc không thành công.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


    }
}
