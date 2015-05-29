using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoai_BUS
    {
        private SQL_QUANLYTHUVIENDataContext db = new SQL_QUANLYTHUVIENDataContext();

        public DataTable LayDuLieuTL()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOAI", typeof(string));
            dt.Columns.Add("TENLOAI", typeof(string));
            dt.Columns.Add("MACHUYENMUC", typeof(string));

            var tem = db.SP_LAYDULIEUTHELOAI();

            foreach (var i in tem)
            {
                DataRow r = dt.NewRow();

                r["MALOAI"] = i.MALOAI;
                r["TENLOAI"] = i.TENLOAI;
                r["MACHUYENMUC"] = i.MACHUYENMUC;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemTL(PHANLOAISACH tl)
        {
            try
            {
                db.SP_THEMTHELOAI(tl.MALOAI, tl.TENLOAI, tl.MACHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTL(PHANLOAISACH tl)
        {
            try
            {
                db.SP_SUATHELOAI(tl.MALOAI, tl.TENLOAI, tl.MACHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTL(PHANLOAISACH tl)
        {
            try
            {
                db.SP_XOATHELOAI(tl.MALOAI);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
