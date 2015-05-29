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
        private SQL_QUANLYTHUVIENDataContext db = new SQL_QUANLYTHUVIENDataContext();

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

            var tem = db.SP_LAYDULIEUNXB();

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
                db.SP_THEMNXB(nxb.MANXB, nxb.TENNXB, nxb.DIACHI, nxb.DIENTHOAI, nxb.FAX, nxb.EMAIL, nxb.WEBSITE, nxb.GHICHU);
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
                db.SP_SUANXB(nxb.MANXB, nxb.TENNXB, nxb.DIACHI, nxb.DIENTHOAI, nxb.FAX, nxb.EMAIL, nxb.WEBSITE, nxb.GHICHU);
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
                db.SP_XOANXB(nxb.MANXB);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
