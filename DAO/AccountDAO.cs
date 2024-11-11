using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System;

public class AccountDAO
{
    private static AccountDAO instance;
    public static AccountDAO Instance
    {
        get
        {
            if (instance == null)
                instance = new AccountDAO();
            return instance;
        }
    }

    public bool CheckLogin(Account account)
    {
        string storedProcedure = "sp_CheckLogin";

        object result = DataProvider.Instance.ExecuteScalar(
            storedProcedure,
            new object[] {
                account.MaNV,
                account.Password
            }
        );

        return result != null && Convert.ToInt32(result) == 1;
    }

    public Account GetAccountByMaNV(string maNV)
    {
        string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";

        DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });

        if (dt.Rows.Count > 0)
        {
            DataRow row = dt.Rows[0];
            return new Account(row["MaNV"].ToString(), row["Password"].ToString());
        }

        return null;
    }
}

