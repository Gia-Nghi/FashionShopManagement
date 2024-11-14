using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO dao = new NhanVienDAO();

        public DataTable GetAllNhanVien()
        {
            return dao.GetAllNhanVien();
        }

        public void AddNhanVien(NhanVienDTO nhanVien)
        {
            dao.AddNhanVien(nhanVien);
        }

        public void UpdateNhanVien(NhanVienDTO nhanVien)
        {
            dao.UpdateNhanVien(nhanVien);
        }
        public void DeleteNhanVien(string maNV)
        {
            dao.DeleteNhanVien(maNV);
        }
        public NhanVienDTO GetNhanVienByMaNV(string maNV)
        {
            return dao.GetNhanVienByMaNV(maNV);
        }
    }
}
