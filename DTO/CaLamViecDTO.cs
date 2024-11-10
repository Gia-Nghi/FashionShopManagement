using System;

namespace DTO
{
    public class CaLamViecDTO
    {
        public string MaCa { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLam { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }

        public CaLamViecDTO(string maCa, string maNV, DateTime ngayLam, TimeSpan gioBatDau, TimeSpan gioKetThuc, string hoNV, string tenNV)
        {
            MaCa = maCa;
            MaNV = maNV;
            NgayLam = ngayLam;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            HoNV = hoNV;
            TenNV = tenNV;
        }
    }
}
