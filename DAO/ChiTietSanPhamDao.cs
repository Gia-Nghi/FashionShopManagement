using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ChiTietSanPhamDao
    {
        private static ChiTietSanPhamDao instance;

        public static ChiTietSanPhamDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietSanPhamDao();
                return instance;
            }
        }

        // Phương thức lấy chi tiết sản phẩm theo mã sản phẩm
        public DataTable GetChiTietSanPhamByMaSP(string maSP)
        {
            string query = "SELECT * FROM ChiTietSanPhamView WHERE MaSP = @MaSP";
            object[] parameters = new object[] { maSP };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
