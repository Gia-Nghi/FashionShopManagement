using System;
using System.Data;
using DAO;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        private ChiTietSanPhamDao dao;

        public ChiTietSanPhamBUS()
        {
            dao = new ChiTietSanPhamDao();
        }

        public DataTable GetChiTietSanPhamByMaSP(string maSP)
        {
            return dao.GetChiTietSanPhamByMaSP(maSP);
        }
    }
}