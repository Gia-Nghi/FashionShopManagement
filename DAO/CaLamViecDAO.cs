using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                string query = "SELECT * FROM ViewBangPhanCa"; // Truy vấn từ view
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
                    string hoNV = reader["HoNV"].ToString();
                    string tenNV = reader["TenNV"].ToString();

                    list.Add(new CaLamViecDTO(maCa, maNV, ngayLam, gioBatDau, gioKetThuc, hoNV, tenNV));
                }
            }
            return list;
        }

        public bool Add(CaLamViecDTO caLamViec)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BangPhanCa (MaCa, MaNV, NgayLam) VALUES (@MaCa, @MaNV, @NgayLam)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCa", caLamViec.MaCa);
                cmd.Parameters.AddWithValue("@MaNV", caLamViec.MaNV);
                cmd.Parameters.AddWithValue("@NgayLam", caLamViec.NgayLam);  // Thêm tham số cho NgayLam

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(CaLamViecDTO caLamViec)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE BangPhanCa SET MaNV = @MaNV WHERE MaCa = @MaCa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCa", caLamViec.MaCa);
                cmd.Parameters.AddWithValue("@MaNV", caLamViec.MaNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maCa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM BangPhanCa WHERE MaCa = @MaCa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
