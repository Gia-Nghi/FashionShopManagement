using DTO;
using System;
using System.Data;

namespace DAO
{
    public class NhanVienDAO
    {
        public DataTable GetAllNhanVien()
        {
            try
            {
                string query = "SELECT * FROM V_ThongTinNhanVien";
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
        }

        public void AddNhanVien(NhanVienDTO nhanVien)
        {
            try
            {
                string query = "EXEC ThemNhanVien @MaNV, @HoNV, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @NgayTuyenDung, @SoCa, @Thuong, @MaCV, @SDT, @Password";
                object[] parameters = new object[]
                {
                    nhanVien.MaNV,
                    nhanVien.HoNV,
                    nhanVien.TenNV,
                    nhanVien.NgaySinh,
                    nhanVien.GioiTinh,
                    nhanVien.DiaChi,
                    nhanVien.NgayTuyenDung,
                    nhanVien.SoCa,
                    nhanVien.Thuong,
                    nhanVien.MaCV,
                    nhanVien.SDT,
                    nhanVien.Password
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (result <= 0)
                {
                    throw new Exception("Không thể thêm nhân viên.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
        public void UpdateNhanVien(NhanVienDTO nhanVien)
        {
            try
            {
                string query = "EXEC CapNhatNhanVien @MaNV, @HoNV, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @NgayTuyenDung, @SoCa, @Thuong, @MaCV, @SDT, @Password";
                object[] parameters = new object[]
                {
                    nhanVien.MaNV,
                    nhanVien.HoNV,
                    nhanVien.TenNV,
                    nhanVien.NgaySinh,
                    nhanVien.GioiTinh,
                    nhanVien.DiaChi,
                    nhanVien.NgayTuyenDung,
                    nhanVien.SoCa,
                    nhanVien.Thuong,
                    nhanVien.MaCV,
                    nhanVien.SDT,
                    nhanVien.Password
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (result <= 0)
                {
                    throw new Exception("Không thể cập nhật thông tin nhân viên.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
        }

        public void DeleteNhanVien(string maNV)
        {
            try
            {
                string query = "EXEC XoaNhanVien @MaNV";
                object[] parameters = new object[] { maNV };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (result <= 0)
                {
                    throw new Exception("Không thể xóa nhân viên.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
    }
}
