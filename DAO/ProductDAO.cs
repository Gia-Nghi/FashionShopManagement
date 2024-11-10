using DTO;
using System.Collections.Generic;
using System.Data;
using System;

namespace DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return instance;
            }
        }

        private ProductDAO() { }

        // Lấy tất cả sản phẩm
        public List<Product> GetAllProducts()
        {
            string query = "SELECT * FROM SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in data.Rows)
            {
                products.Add(new Product(row));
            }

            return products;
        }

        // Lấy tất cả tên loại sản phẩm (TenLoaiSP)
        public List<string> GetAllCategories()
        {
            string query = "SELECT TenLoaiSP FROM LoaiSanPham"; // Truy vấn lấy TenLoaiSP thay vì MaLoaiSP
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<string> categories = new List<string>();

            foreach (DataRow row in data.Rows)
            {
                categories.Add(row["TenLoaiSP"].ToString()); // Thêm TenLoaiSP vào danh sách
            }

            return categories;
        }

        // Thay thế MessageBox bằng việc trả về giá trị hoặc mã lỗi
        public List<Product> GetListProductByCategory(string category)
        {
            try
            {
                string query = "EXEC GetProductsByCategory @CategoryName";
                object[] parameters = new object[] { category };
                DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

                List<Product> products = new List<Product>();
                foreach (DataRow row in data.Rows)
                {
                    products.Add(new Product(row));
                }

                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }
        }



        public List<Product> SearchProductByNameOrCode(string searchText)
        {
            string query = "EXEC sp_TimKiemSanPham @SearchText";
            object[] parameters = new object[] { searchText };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            List<Product> products = new List<Product>();

            foreach (DataRow row in data.Rows)
            {
                products.Add(new Product(row));
            }

            return products;
        }
    }
}
