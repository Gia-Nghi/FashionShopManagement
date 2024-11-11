using DTO;
using DAO;

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
            return AccountDAO.Instance.CheckLogin(account);
        }

        public Account GetAccountByMaNV(string maNV)
        {
            return AccountDAO.Instance.GetAccountByMaNV(maNV);
        }
    }

}
