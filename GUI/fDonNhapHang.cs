﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GUI
{
    public partial class fDonNhapHang : Form
    {
        private PhieuChiBUS pcb;
        public fDonNhapHang()
        {
            InitializeComponent();
            pcb = new PhieuChiBUS();
        }

        private void dgv_PhieuChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fDonNhapHang_Load(object sender, EventArgs e)
        {
            load_dgv_PhieuChi();
        }
        private void load_dgv_PhieuChi()
        {
            DataTable dataTable = pcb.GetPhieuChiNhapHang();

            dgv_PhieuChi.DataSource = dataTable;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_dgv_PhieuChi();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Đường dẫn file PDF xuất ra
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "PhieuChi.pdf");

            // Tạo tài liệu PDF
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            try
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                // Tạo bảng PDF có số cột bằng với số cột trong DataGridView
                PdfPTable pdfTable = new PdfPTable(dgv_PhieuChi.ColumnCount);
                pdfTable.WidthPercentage = 100;

                // Thêm tiêu đề cột vào bảng PDF
                foreach (DataGridViewColumn column in dgv_PhieuChi.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                // Thêm dữ liệu hàng vào bảng PDF
                foreach (DataGridViewRow row in dgv_PhieuChi.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                // Thêm bảng vào tài liệu PDF
                pdfDoc.Add(pdfTable);
                MessageBox.Show("Dữ liệu đã được xuất thành công vào file PDF!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pdfDoc.Close();
            }
        }
    }
}