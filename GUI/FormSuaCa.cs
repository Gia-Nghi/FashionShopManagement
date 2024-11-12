using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSuaCa : Form
    {
        public string NewMaCa { get; private set; }
        public string NewMaNV { get; private set; }
        public DateTime NewNgayLam { get; private set; }

        public FormSuaCa(string maCa, DateTime ngayLam, string maNV = "")
        {
            InitializeComponent();
            txtMaCa.Text = maCa;
            txtMaNV.Text = maNV;
            dtpNgayLam.Value = ngayLam;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewMaCa = txtMaCa.Text;
            NewMaNV = txtMaNV.Text;
            NewNgayLam = dtpNgayLam.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }


}
