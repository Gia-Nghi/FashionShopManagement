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
            string maCa = txtMaCa.Text;
            string maNV = txtMaNV.Text;
            DateTime ngayLam = dtpNgayLam.Value;
            TimeSpan gioBatDau = TimeSpan.Parse(txtGioBatDau.Text);
            TimeSpan gioKetThuc = TimeSpan.Parse(txtGioKetThuc.Text);
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;

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

            if (caLamViecBUS.DeleteCaLamViec(maCa))
            {
                MessageBox.Show("Xóa ca làm việc thành công!");
                LoadCaLamViec();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa ca làm việc.");
            }
        }

        private void fPhanCa_Load(object sender, EventArgs e)
        {

        }
    }
}
