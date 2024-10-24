using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        public bool CheckLogin(Account account)
        {
            string connectionString = "Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", account.MaNV); // Đã sửa lại tên tham số
                    command.Parameters.AddWithValue("@Password", account.Password);
                    int result = (int)command.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        public Account GetAccountByMaNV(string maNV)
        {
            string connectionString = "Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account(reader["MaNV"].ToString(), reader["Password"].ToString());
                        }
                    }
                }
            }
            return null;
        }
    }
}
