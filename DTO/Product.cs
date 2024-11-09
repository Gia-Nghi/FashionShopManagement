using System;
using System.Data;

namespace DTO
{
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; } 
        public string MaLoaiSP { get; set; } 
        public int DonGia { get; set; }
        public string Size { get; set; } 
        public int SL { get; set; }

  
        public Product(string maSP, string tenSP, string loaiSP, int gia, string size, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaLoaiSP = loaiSP;
            DonGia = DonGia;       
            Size = size;        
            SL = SL;       
        }

        public Product(DataRow row)
        {
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            MaLoaiSP = row["MaLoaiSP"].ToString();
            DonGia = row["DonGia"] != DBNull.Value ? Convert.ToInt32(row["DonGia"]) : 0;
            Size = row["Size"].ToString();
            SL = row.Field<int>("SL");
        }
    }
}
