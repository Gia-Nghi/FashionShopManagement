using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuChiBUS
    {
        private PhieuChiDAO dao;

        public PhieuChiBUS()
        {
            dao = new PhieuChiDAO();
        }

        public DataTable GetPhieuChiNhapHang()
        {
            return dao.GetPhieuChi();
        }
    }
}
