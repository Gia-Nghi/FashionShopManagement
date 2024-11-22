using System.Data;

namespace DTO
{
    public class Account
    {
        public string MaNV { get; set; }
        public string Password { get; set; }

        public Account(string maNV, string password)
        {
            this.MaNV = maNV;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.Password = row["Password"]?.ToString();
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(MaNV) && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
