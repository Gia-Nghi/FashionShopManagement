using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class ProductBUS
    {
        private static ProductBUS instance;

        public static ProductBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductBUS();
                return instance;
            }
        }

        private ProductBUS() { }

        public List<Product> GetAllProducts()
        {
            DataTable table = ProductDAO.Instance.GetAllProduct();
            List<Product> products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetListProductByCategory(string category)
        {
            DataTable table = ProductDAO.Instance.GetListProductByCategory(category);
            List<Product> products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                products.Add(product);
            }
            return products;
        }

        // Thêm phương thức để lấy tất cả loại sản phẩm
        public List<string> GetAllCategories()
        {
            DataTable table = ProductDAO.Instance.GetAllCategories(); // Gọi DAO để lấy danh sách loại sản phẩm
            List<string> categories = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                categories.Add(row["TenLoaiSP"].ToString());
            }
            return categories;
        }

        public List<Product> SearchProductByNameOrCode(string searchText)
        {
            DataTable table = ProductDAO.Instance.SearchProductByNameOrCode(searchText); // Gọi đến DAO
            List<Product> products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                products.Add(product);
            }
            return products;
        }

        public bool InsertProduct(Product newProduct)
        {
            return ProductDAO.Instance.InsertProduct(newProduct);
        }

        public bool UpdateProduct(Product product)
        {
            return ProductDAO.Instance.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return ProductDAO.Instance.DeleteProduct(id);
        }
    }
}
