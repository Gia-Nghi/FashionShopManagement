using System;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTuyenDung { get; set; }
        public int SoCa { get; set; }
        public int Thuong { get; set; }
        public string MaCV { get; set; }
        public string SDT { get; set; }
        public string Password { get; set; }

        // Constructor
        public NhanVienDTO(string maNV, string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, DateTime ngayTuyenDung, int soCa, int thuong, string maCV, string sdt, string password)
        {
            MaNV = maNV;
            HoNV = hoNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            NgayTuyenDung = ngayTuyenDung;
            SoCa = soCa;
            Thuong = thuong;
            MaCV = maCV;
            SDT = sdt;
            Password = password;
        }
    }
}
