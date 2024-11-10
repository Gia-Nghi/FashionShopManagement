using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

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
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            try
            {
                string maCa = txtMaCa.Text;
                string maNV = txtMaNV.Text;
                DateTime ngayLam = dtpNgayLam.Value;

                TimeSpan gioBatDau = TimeSpan.Zero;
                TimeSpan gioKetThuc = TimeSpan.Zero;

                if (!string.IsNullOrEmpty(txtGioBatDau.Text) && TimeSpan.TryParse(txtGioBatDau.Text, out var startTime))
                {
                    gioBatDau = startTime;
                }

                if (!string.IsNullOrEmpty(txtGioKetThuc.Text) && TimeSpan.TryParse(txtGioKetThuc.Text, out var endTime))
                {
                    gioKetThuc = endTime;
                }

                string hoNV = txtHoNV.Text;
                string tenNV = txtTenNV.Text;

                if (caLamViecBUS.CheckIfCaExists(maCa, ngayLam))
                {
                    MessageBox.Show("Ca làm việc đã tồn tại trong ngày này. Vui lòng chọn ca khác.");
                    return;
                }

                CaLamViecDTO caLamViec = new CaLamViecDTO(maCa, maNV, ngayLam, gioBatDau, gioKetThuc, hoNV, tenNV);

                if (caLamViecBUS.AddCaLamViec(caLamViec))
                {
                    MessageBox.Show("Thêm ca làm việc thành công!");
                    LoadCaLamViec();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm ca làm việc.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            string maCa = txtMaCa.Text;
            string maNV = txtMaNV.Text;
            DateTime ngayLam = dtpNgayLam.Value;
            TimeSpan gioBatDau = TimeSpan.Parse(txtGioBatDau.Text);
            TimeSpan gioKetThuc = TimeSpan.Parse(txtGioKetThuc.Text);
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;

            CaLamViecDTO caLamViec = new CaLamViecDTO(maCa, maNV, ngayLam, gioBatDau, gioKetThuc, hoNV, tenNV);
            if (caLamViecBUS.UpdateCaLamViec(caLamViec))
            {
                MessageBox.Show("Sửa ca làm việc thành công!");
                LoadCaLamViec();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa ca làm việc.");
            }
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            string maCa = txtMaCa.Text;
            DateTime ngayLam = dtpNgayLam.Value;

            if (caLamViecBUS.DeleteCaLamViec(maCa, ngayLam))
            {
                MessageBox.Show("Xóa ca làm việc thành công!");
                LoadCaLamViec();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa ca làm việc.");
            }
        }

    }
}
