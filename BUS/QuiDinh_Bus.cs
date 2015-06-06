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
        public QuiDinh_Bus()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public List<QUIDINH> LoadDuLieuQD()
        {
            return SQLDataContext.SQLData.QUIDINHs.ToList();
        }
    }
}
