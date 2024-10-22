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
                return ProductBUS.instance;
            }
        }

        private ProductBUS() { }

        public DataTable GetAllProduct()
        {
            try
            {
                return ProductDAO.Instance.GetAllProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetListProductByCategory(string category)
        {
            try
            {
                return ProductDAO.Instance.GetListProductByCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> SearchProductByName(string name)
        {
            DataTable table;
            try
            {
                table = ProductDAO.Instance.SearchProductByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct;
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