using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuChiDAO
    {
        public DataTable GetPhieuChi()
        {
            string query = "SELECT * FROM DonNhapHangView";
            object[] parameters = new object[] { };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
