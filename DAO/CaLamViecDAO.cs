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
                string query = "SELECT * FROM ViewBangPhanCa";
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
                SqlCommand cmd = new SqlCommand("sp_ThemCaLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", caLamViec.MaCa);
                cmd.Parameters.AddWithValue("@NgayLam", caLamViec.NgayLam);
                cmd.Parameters.AddWithValue("@MaNV", caLamViec.MaNV);
                cmd.Parameters.AddWithValue("@GioBatDau", caLamViec.GioBatDau);
                cmd.Parameters.AddWithValue("@GioKetThuc", caLamViec.GioKetThuc);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool CheckIfCaExists(string maCa, DateTime ngayLam)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM CaLamViec WHERE MaCa = @MaCa AND NgayLam = @NgayLam";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@NgayLam", ngayLam);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }




        public bool Update(CaLamViecDTO caLamViec)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaCaLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", caLamViec.MaCa);
                cmd.Parameters.AddWithValue("@NgayLam", caLamViec.NgayLam);
                cmd.Parameters.AddWithValue("@GioBatDau", caLamViec.GioBatDau);
                cmd.Parameters.AddWithValue("@GioKetThuc", caLamViec.GioKetThuc);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maCa, DateTime ngayLam)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaCaLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@NgayLam", ngayLam);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
