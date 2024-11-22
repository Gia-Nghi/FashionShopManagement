using System;
using System.Data;
using DAO;

namespace DAO
{
    public class ChiTietSanPhamDao
    {
        public DataTable GetChiTietSanPhamByMaSP(string maSP)
        {
            string query = "SELECT * FROM ChiTietSanPhamView WHERE MaSP = @MaSP";
            object[] parameters = new object[] { maSP };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}