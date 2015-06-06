using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ViTri_BUS
    {
        public ViTri_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        //load du lieu kho
        public List<int?> LoadDuLieuKho()
        {
            try
            {
                List<int?> kho = new List<int?>();
                var _kho = SQLDataContext.SQLData.VITRIs.Select(vt => vt.KHO).Distinct();
                foreach (var k in _kho)
                {
                    kho.Add(k);
                }
                return kho;
            }
            catch
            {
                return null;
            }
        }

        //load du lieu ngan
        public List<int?> LoadDuLieuNgan()
        {
            try
            {
                List<int?> kho = new List<int?>();
                var _kho = SQLDataContext.SQLData.VITRIs.Select(vt => vt.NGAN).Distinct();
                foreach (var k in _kho)
                {
                    kho.Add(k);
                }
                return kho;
            }
            catch
            {
                return null;
            }
        }

        //load du lieu ke
       public List<int?> LoadDuLieuKe()
        {
            try
            {
                List<int?> kho = new List<int?>();
                var _kho = SQLDataContext.SQLData.VITRIs.Select(vt => vt.KE).Distinct();
                foreach (var k in _kho)
                {
                    kho.Add(k);
                }
                return kho;
            }
            catch
            {
                return null;
            }
        }

       public string LoadDuLieuViTri(int kho, int ngan, int ke)
       {
           try
           {
               return SQLDataContext.SQLData.VITRIs.Single(vt => vt.KHO == kho && vt.NGAN == ngan && vt.KE == ke).MAVITRI;
           }
           catch
           {
               return "";
           }
       }
        //lay ten kho
       public string LayTenKho(string mavitri)
       {
           try
           {
               return SQLDataContext.SQLData.VITRIs.Single(vt => vt.MAVITRI == mavitri).KHO.ToString();
           }
           catch
           {
               return "1";
           }
       }
        //lay ten ngan
       public string LayTenNgan(string mavitri)
       {
           try
           {
               return SQLDataContext.SQLData.VITRIs.Single(vt => vt.MAVITRI == mavitri).NGAN.ToString();
           }
           catch
           {
               return "1";
           }
       }
        //lay ten ke
       public string LayTenKe(string mavitri)
       {
           try
           {
               return SQLDataContext.SQLData.VITRIs.Single(vt => vt.MAVITRI == mavitri).KE.ToString();
           }
           catch
           {
               return "1";
           }
       }
    }
}
