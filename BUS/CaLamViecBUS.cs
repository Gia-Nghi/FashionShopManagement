﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class CaLamViecBUS
    {
        private CaLamViecDAO caLamViecDAO = new CaLamViecDAO();

        public List<CaLamViecDTO> GetAllCaLamViec()
        {
            return caLamViecDAO.GetAll();
        }

        public bool AddCaLamViec(CaLamViecDTO caLamViec)
        {
            return caLamViecDAO.Add(caLamViec);
        }

        public bool UpdateCaLamViec(CaLamViecDTO caLamViec)
        {
            return caLamViecDAO.Update(caLamViec);
        }

        public bool DeleteCaLamViec(string maCa)
        {
            return caLamViecDAO.Delete(maCa);
        }
    }
}