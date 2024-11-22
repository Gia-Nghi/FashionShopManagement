using System;
using System.Data;

namespace DTO
{
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenLoaiSP { get; set; }
        public string MaLoaiSP { get; set; }
        public decimal DonGia { get; set; }
        public string Size { get; set; }
        public int SL { get; set; }
        public string TenNCC { get; set; }
        public string MaNCC { get; set; }


        public Product(string maSP, string tenSP, string loaiSP, decimal gia, string size, int soLuong, string tenNCC)
        {
            MaSP = maSP;
            TenSP = tenSP;
            TenLoaiSP = loaiSP;
            DonGia = gia;
            Size = size;
            SL = soLuong;
            TenNCC = tenNCC;
        }

        public Product() { }

        public Product(DataRow row)
        {
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            DonGia = Convert.ToDecimal(row["DonGia"]);
            Size = row["Size"].ToString();
            SL = Convert.ToInt32(row["SL"]);
            TenNCC = row["TenNCC"].ToString();
        }
    }
}