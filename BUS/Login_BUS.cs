using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class Login_BUS
    {
        public Login_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }
        public bool Login(string id, string pass,ref NHANVIEN nhanvien)
        {
            try
            {
                SQLDataContext.CreateDataContext();
                nhanvien = SQLDataContext.SQLData.NHANVIENs.Where(nv => nv.MANV == id && nv.PASS == pass).FirstOrDefault();
                if (nhanvien == null)
                    return false;
                return true;
            }
            catch
            {
                return true;
            }
        }
    }
}
