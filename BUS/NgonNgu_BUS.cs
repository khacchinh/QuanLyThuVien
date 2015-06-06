using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NgonNgu_BUS
    {
        public NgonNgu_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        //lay ten ngon ngu
        public string GetTenNgonNgu(string mann)
        {
            try
            {
                return SQLDataContext.SQLData.NGONNGUs.Single(nn => nn.MANGONNGU == mann).TENNGONNGU;
            }
            catch
            {
                return "";
            }
        }
    }
}
