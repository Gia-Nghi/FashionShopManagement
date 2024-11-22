using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class fThemSanPham : Form
    {
        public fThemSanPham()
        {
            InitializeComponent();
            productBUS = new ProductBUS();
            LoadComboBoxCategories();
            LoadComboBoxSupplier();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_SanPhamMoi_Click(object sender, EventArgs e)
        {

        }



        private ProductBUS productBUS;
        public event EventHandler ProductAdded;


        public void LoadComboBoxCategories()
        {
            DataTable categories = ProductBUS.Instance.GetAllCategories();
            comboBox_LSP.DataSource = categories;
            comboBox_LSP.DisplayMember = "TenLoaiSP"; // Hiển thị TenLoaiSP trong ComboBox
            comboBox_LSP.ValueMember = "MaLoaiSP";    // Giá trị là MaLoaiSP
        }

        public void LoadComboBoxSupplier()
        {
            DataTable categories = ProductBUS.Instance.GetAllSupplier();
            comboBox_NCC.DataSource = categories;
            comboBox_NCC.DisplayMember = "TenNCC"; // Hiển thị TenLoaiSP trong ComboBox
            comboBox_NCC.ValueMember = "MaNCC";    // Giá trị là MaLoaiSP
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {



            Product pro = new Product
            {
                MaSP = textBox_MaSP.Text,
                TenSP = textBox_TenSP.Text,
                //MaLoaiSP = textBox_MaLSP.Text,
                MaLoaiSP = comboBox_LSP.SelectedValue.ToString(),
                //DonGia = decimal.Parse(textBox_Gia.Text),
                DonGia = Convert.ToDecimal(textBox_Gia.Text),
                Size = textBox_Size.Text,
                SL = int.Parse(textBox_SL.Text),
                //MaNCC = textBox_MaNCC.Text
                MaNCC = comboBox_NCC.SelectedValue.ToString(),


            };

            bool result = productBUS.ThemSanPham(pro);
            if (result)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                ProductAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
                //LoadProduct(); // Tải lại danh sách sau khi thêm
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }


        }



        private void comboBox_LSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LSP.SelectedIndex >= 0)
            {
                string maLoaiSP = comboBox_LSP.SelectedValue.ToString();

            }
        }

        private void comboBox_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_NCC.SelectedIndex >= 0)
            {
                string maNCC = comboBox_NCC.SelectedValue.ToString();

            }
        }
    }
}