using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuiDinh_Bus
    {
        private SQL_QUANLYTHUVIENDataContext DB = new SQL_QUANLYTHUVIENDataContext();

        public List<QUIDINH> LoadDuLieuQD()
        {
            return DB.QUIDINHs.ToList();
        }
    }
}
