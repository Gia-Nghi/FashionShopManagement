using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CaLamViecDAO
    {
        private string connectionString = @"Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";

        public List<CaLamViecDTO> GetAll()
        {
            List<CaLamViecDTO> list = new List<CaLamViecDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ViewBangPhanCa ORDER BY NgayLam DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maCa = reader["MaCa"].ToString();
                    string maNV = reader["MaNV"].ToString();
                    DateTime ngayLam = Convert.ToDateTime(reader["NgayLam"]);
                    TimeSpan gioBatDau = TimeSpan.Parse(reader["GioBatDau"].ToString());
                    TimeSpan gioKetThuc = TimeSpan.Parse(reader["GioKetThuc"].ToString());
                    string hoTenNV = reader["HoNV"].ToString() + " " + reader["TenNV"].ToString();

                    list.Add(new CaLamViecDTO(maCa, maNV, ngayLam, gioBatDau, gioKetThuc, hoTenNV));
                }
            }
            return list;
        }


        public bool AddCaLamViec(string maCa, DateTime ngayLam, string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemCaLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@NgayLam", ngayLam);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCaLamViec(string maCa, DateTime ngayLam, string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaCaLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@NgayLam", ngayLam);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateCaLamViec(string maCa, DateTime ngayLam, string maNV, string newMaCa, string newMaNV, DateTime newNgayLam)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "sp_SuaCaLamViec";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCa", maCa);
                    cmd.Parameters.AddWithValue("@NgayLam", ngayLam);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@NewMaCa", newMaCa);
                    cmd.Parameters.AddWithValue("@NewMaNV", newMaNV);
                    cmd.Parameters.AddWithValue("@NewNgayLam", newNgayLam);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
        }


    }
}
