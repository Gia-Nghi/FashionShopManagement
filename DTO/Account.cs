using System.Data;

namespace DTO
{
    public class Account
    {
        public string MaNV { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TypeID { get; set; }

        public Account(string maNV, string password)
        {
            this.MaNV = maNV;
            this.Password = password;
        }

        public Account(string maNV, string displayName, int typeID, string password = null)
        {
            this.MaNV = maNV;
            this.DisplayName = displayName;
            this.TypeID = typeID;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.TypeID = row.Field<int>("TypeID");
            this.Password = row["Password"].ToString();
        }
    }
}
