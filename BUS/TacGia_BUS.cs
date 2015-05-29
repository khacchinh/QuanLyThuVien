using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TacGia_BUS
    {
        private SQL_QUANLYTHUVIENDataContext db = new SQL_QUANLYTHUVIENDataContext();

        public DataTable LayDuLieuTG()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MATG", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("FAX", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));

            var tem = db.SP_LAYDULIEUTG();

            foreach (var i in tem)
            {
                DataRow r = dt.NewRow();

                r["MATG"] = i.MATG;
                r["TENTG"] = i.TENTG;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["FAX"] = i.FAX;
                r["EMAIL"] = i.EMAIL;
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemTG(TACGIA tg)
        {
            try
            {
                db.SP_THEMTG(tg.MATG, tg.TENTG, tg.DIACHI, tg.DIENTHOAI, tg.FAX, tg.EMAIL, tg.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTG(TACGIA tg)
        {
            try
            {
                db.SP_SUATG(tg.MATG, tg.TENTG, tg.DIACHI, tg.DIENTHOAI, tg.FAX, tg.EMAIL, tg.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTG(TACGIA tg)
        {
            try
            {
                db.SP_XOATG(tg.MATG);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
