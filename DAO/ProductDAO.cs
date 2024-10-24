using DTO;
using System;
using System.Data;

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

        public DataTable GetAllProduct()
        {
            string query = "SELECT MaSP, TenSP, DonGia,Size FROM SanPham";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Thêm phương thức để lấy tất cả loại sản phẩm
        public DataTable GetAllCategories()
        {
            string query = "SELECT DISTINCT TenLoaiSP FROM V_ThongTinSanPham";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetListProductByCategory(string category)
        {
            string query = "SELECT * FROM V_ThongTinSanPham WHERE TenLoaiSP = @Category"; 
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { category });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SearchProductByNameOrCode(string searchText)
        {
            string query = "SELECT * FROM dbo.SanPham WHERE MaSP LIKE '%' + @SearchText + '%' OR TenSP LIKE '%' + @SearchText + '%'"; // Tìm kiếm theo mã hoặc tên sản phẩm
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { searchText });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertProduct(Product newProduct)
        {
            string query = "USP_InsertProduct @Name , @Price, @Category , @Quantity, @Size, @Supplier"; // Bạn cần xác định thủ tục lưu trữ
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                    newProduct.Name,
                    newProduct.Price,
                    newProduct.Size,
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateProduct(Product product)
        {
            string query = "USP_UpdateProduct @Id , @Name , @Price, @Category , @Quantity, @Size, @Supplier"; // Bạn cần xác định thủ tục lưu trữ
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                    product.MaSP,
                    product.Name,
                    product.Price,
                    product.Size,

                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool DeleteProduct(int Id)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteProduct @Id", new object[] { Id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
