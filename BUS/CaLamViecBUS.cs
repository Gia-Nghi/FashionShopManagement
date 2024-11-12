using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class CaLamViecBUS
    {
        private CaLamViecDAO caLamViecDAO = new CaLamViecDAO();

        public List<CaLamViecDTO> GetAllCaLamViec()
        {
            return caLamViecDAO.GetAll();
        }

        public bool AddCaLamViec(string maCa, DateTime ngayLam, string maNV)
        {
            return caLamViecDAO.AddCaLamViec(maCa, ngayLam, maNV);
        }

        public bool DeleteCaLamViec(string maCa, DateTime ngayLam, string maNV)
        {
            return caLamViecDAO.DeleteCaLamViec(maCa, ngayLam, maNV);
        }

        public bool UpdateCaLamViec(string maCa, DateTime ngayLam, string maNV, string newMaCa, string newMaNV, DateTime newNgayLam)
        {
            return caLamViecDAO.UpdateCaLamViec(maCa, ngayLam, maNV, newMaCa, newMaNV, newNgayLam);
        }

    }
}
