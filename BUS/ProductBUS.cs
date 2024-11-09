using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

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

        public List<Product> GetAllProducts()
        {
            return ProductDAO.Instance.GetAllProducts();
        }

        public List<string> GetAllCategories()
        {
            return ProductDAO.Instance.GetAllCategories();
        }

        public List<Product> GetListProductByCategory(string category)
        {
            return ProductDAO.Instance.GetListProductByCategory(category);
        }

        public List<Product> SearchProductByNameOrCode(string searchText)
        {
            return ProductDAO.Instance.SearchProductByNameOrCode(searchText);
        }
    }
}
