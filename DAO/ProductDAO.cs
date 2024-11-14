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
            string query = @"SELECT SanPham.MaSP,SanPham.TenSP, SanPham.DonGia, SanPham.SL, SanPham.Size,
                            LoaiSanPham.TenLoaiSP,
                            NhaCungCap.TenNCC
                            FROM SanPham
                            JOIN LoaiSanPham On SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP
                            JOIN NhaCungCap On SanPham.MaNCC = NhaCungCap.MaNCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in data.Rows)
            {
                products.Add(new Product(row));
            }

            return products;
        }

        // Lấy tất cả tên loại sản phẩm (TenLoaiSP)
        public DataTable GetAllCategories()
        {
            string query = "SELECT TenLoaiSP, MaLoaiSP FROM LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetAllSupplier()
        {
            string query = "SELECT TenNCC, MaNCC FROM NhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
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

        /////////////////////

        // Thêm sản phẩm
        public bool ThemSanPham(Product sanPham)
        {
            string query = "sp_ThemSanPham @MaSP , @TenSP , @DonGia , @SL , @Size , @MaLoaiSP , @MaNCC";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { sanPham.MaSP, sanPham.TenSP, sanPham.DonGia, sanPham.SL, sanPham.Size, sanPham.MaLoaiSP, sanPham.MaNCC });
            return result > 0;
        }

        // Lấy chi tiết sản phẩm theo Mã SP
        public DataTable GetChiTietSanPhamByMaSP(string maSP)
        {
            string query = "SELECT SP.MaSP, SP.TenSP, SP.DonGia, SP.SL, SP.Size, LSP.TenLoaiSP, NCC.TenNCC " +
                           "FROM SanPham SP " +
                           "JOIN LoaiSanPham LSP ON SP.MaLoaiSP = LSP.MaLoaiSP " +
                           "JOIN NhaCungCap NCC ON SP.MaNCC = NCC.MaNCC " +
                           "WHERE SP.MaSP = @MaSP";
            object[] parameters = new object[] { maSP };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        // Xóa sản phẩm
        public bool XoaSanPham(string maSP)
        {
            string query = "sp_XoaSanPham @MaSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSP });
            return result>0;
        }

        // Chinh sua sản phẩm
        public bool ChinhSuaSanPham(Product sanPham)
        {
            string query = "sp_ChinhSuaSanPham @MaSP , @TenSP , @DonGia , @SL , @Size , @MaLoaiSP , @MaNCC";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
            new object[] { sanPham.MaSP, sanPham.TenSP, sanPham.DonGia, sanPham.SL, sanPham.Size, sanPham.MaLoaiSP, sanPham.MaNCC });
            return result > 0;
        }

        // Lọc sản phẩm theo loại
        public List<Product> LocSanPhamTheoLoai(string maLoaiSP)
        {
            string query = "sp_LocSanPhamTheoLoai @MaLoaiSP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maLoaiSP });
            List<Product> sanPhamList = new List<Product>();
            foreach (DataRow row in data.Rows)
            {
                Product sanPham = new Product(row);
                sanPhamList.Add(sanPham);
            }
            return sanPhamList;
        }
    }
}
