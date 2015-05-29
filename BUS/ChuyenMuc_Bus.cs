using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class ChuyenMuc_Bus
    {
        private SQL_QUANLYTHUVIENDataContext db = new SQL_QUANLYTHUVIENDataContext();

        public DataTable LayDuLieuCM()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MACHUYENMUC", typeof(string));
            dt.Columns.Add("TENCHUYENMUC", typeof(string));

            var tem = db.SP_LAYDULIEUCHUYENMUC();

            foreach (var i in tem)
            {
                DataRow r = dt.NewRow();

                r["MACHUYENMUC"] = i.MACHUYENMUC;
                r["TENCHUYENMUC"] = i.TENCHUYENMUC;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemCM(CHUYENMUC cm)
        {
            try
            {
                db.SP_THEMCHUYENMUC(cm.MACHUYENMUC, cm.TENCHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaCM(CHUYENMUC cm)
        {
            try
            {
                db.SP_SUACHUYENMUC(cm.MACHUYENMUC, cm.TENCHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaCM(CHUYENMUC cm)
        {
            try
            {
                db.SP_XOACHUYENMUC(cm.MACHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
