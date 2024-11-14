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

        
        public DataTable GetAllCategories()
        {
            return ProductDAO.Instance.GetAllCategories();
        }

        public DataTable GetAllSupplier()
        {
            return ProductDAO.Instance.GetAllSupplier();
        }

        public List<Product> GetListProductByCategory(string category)
        {
            return ProductDAO.Instance.GetListProductByCategory(category);
        }


        public List<Product> SearchProductByNameOrCode(string searchText)
        {
            return ProductDAO.Instance.SearchProductByNameOrCode(searchText);
        }

        public bool ThemSanPham(Product sanPham)
        {
            return ProductDAO.Instance.ThemSanPham(sanPham);
        }

        public bool XoaSanPham(string maSP)
        {
            return ProductDAO.Instance.XoaSanPham(maSP);
        }

        public bool ChinhSuaSanPham(Product sanPham)
        {
            return ProductDAO.Instance.ChinhSuaSanPham(sanPham);
        }

        public List<Product> LocSanPhamTheoLoai(string maLoaiSP)
        {
            return ProductDAO.Instance.LocSanPhamTheoLoai(maLoaiSP);
        }

        public DataTable GetChiTietSanPhamByMaSP(string maSP)
        {
            return ProductDAO.Instance.GetChiTietSanPhamByMaSP(maSP);
        }
    }
}
