using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDetailDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SL { get; set; }
        public string Size { get; set; }
        public string TenLoaiSP { get; set; }
        public string TenNCC { get; set; }

        public ProductDetailDTO(string maSP, string tenSP, decimal donGia, int sl, string size, string tenLoaiSP, string tenNCC)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SL = sl;
            Size = size;
            TenLoaiSP = tenLoaiSP;
            TenNCC = tenNCC;
        }
    }
}
