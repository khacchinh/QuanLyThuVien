using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NXB_BUS
    {
        public NXB_BUS()
        {
            if (SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public DataTable LayDuLieuNXB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MANXB", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("FAX", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("WEBSITE", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));

            var tem = from nxb in SQLDataContext.SQLData.NXBs
                      select nxb;

            foreach (var i in tem)
            {
                DataRow r = dt.NewRow();

                r["MANXB"] = i.MANXB;
                r["TENNXB"] = i.TENNXB;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["FAX"] = i.FAX;
                r["EMAIL"] = i.EMAIL;
                r["WEBSITE"] = i.WEBSITE;
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemNXB(NXB nxb)
        {
            try
            {
                SuaNXB(nxb);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNXB(NXB nxb)
        {
            try
            {
                var sua_nxb = SQLDataContext.SQLData.NXBs.Single(xb => xb.MANXB == nxb.MANXB);
                sua_nxb.TENNXB = nxb.TENNXB;
                sua_nxb.DIACHI = nxb.DIACHI;
                sua_nxb.DIENTHOAI = nxb.DIENTHOAI;
                sua_nxb.FAX = nxb.FAX;
                sua_nxb.EMAIL = nxb.EMAIL;
                sua_nxb.WEBSITE = nxb.WEBSITE;
                sua_nxb.GHICHU = nxb.GHICHU;
                SQLDataContext.SQLData.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaNXB(NXB nxb)
        {
            try
            {
                SQLDataContext.SQLData.SP_XOANXB(nxb.MANXB);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lay ten nha xuat ban
        public string GetTenNXB(string manxb)
        {
            try
            {
                return SQLDataContext.SQLData.NXBs.Single(nxb => nxb.MANXB == manxb).TENNXB;
            }
            catch
            {
                return "";
            }
        }
        //lay ma sach lon nhat
        public string GetMaNXBMax()
        {
            string manxb = "";
            try
            {
                //string masach = ""; 
                int maso;
                SQLDataContext.SQLData.sp_getMaNXBMax(ref manxb);
                maso = int.Parse(manxb.Substring(3)) + 1;
                if (maso.ToString().Length == 1)
                    manxb = "NXB00" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    manxb = "NXB0" + maso.ToString();
                else manxb = "NXB" + maso.ToString();

                SQLDataContext.CreateDataContext();
                NXB nxb = new NXB();
                nxb.MANXB = manxb;
                SQLDataContext.SQLData.NXBs.InsertOnSubmit(nxb);
                SQLDataContext.SQLData.SubmitChanges();
                return manxb;
            }
            catch
            {
                return "demo";
            }
        }
        //delete ma sach rong
        public void DeleteMaNXBMax()
        {
            try
            {
                NXB nxb = SQLDataContext.SQLData.NXBs.Single(xb => xb.TENNXB == null);
                SQLDataContext.SQLData.NXBs.DeleteOnSubmit(nxb);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
