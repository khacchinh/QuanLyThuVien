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
        public ChuyenMuc_Bus()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public DataTable LayDuLieuCM()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MACHUYENMUC", typeof(string));
            dt.Columns.Add("TENCHUYENMUC", typeof(string));

            var tem = SQLDataContext.SQLData.SP_LAYDULIEUCHUYENMUC();

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
                SuaCM(cm);
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
                SQLDataContext.SQLData.SP_SUACHUYENMUC(cm.MACHUYENMUC, cm.TENCHUYENMUC);
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
                SQLDataContext.SQLData.SP_XOACHUYENMUC(cm.MACHUYENMUC);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lay ten chuyen muc
        public string LayTenChuyenMuc(string macm)
        {
            try
            {
                return SQLDataContext.SQLData.CHUYENMUCs.Single(cm => cm.MACHUYENMUC == macm).TENCHUYENMUC;
            }
            catch
            {
                return null;
            }
        }

        //lay ma chuyen muc lon nhat
        public string GetMaNXBMax()
        {
            SQLDataContext.CreateDataContext();
            string chuyenmuc = "";
            try
            {
                //string masach = ""; 
                int maso;
                SQLDataContext.SQLData.sp_getMaCMMax(ref chuyenmuc);
                maso = int.Parse(chuyenmuc.Substring(2)) + 1;
                if (maso.ToString().Length == 1)
                    chuyenmuc = "CM00" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    chuyenmuc = "CM0" + maso.ToString();
                else chuyenmuc = "CM" + maso.ToString();

                CHUYENMUC cm = new CHUYENMUC();
                cm.MACHUYENMUC = chuyenmuc;
                SQLDataContext.SQLData.CHUYENMUCs.InsertOnSubmit(cm);
                SQLDataContext.SQLData.SubmitChanges();
                return chuyenmuc;
            }
            catch
            {
                return "demo";
            }
        }
        //delete ma sach rong
        public void DeleteMaCMMax()
        {
            try
            {
                CHUYENMUC chuyenmuc = SQLDataContext.SQLData.CHUYENMUCs.Single(cm => cm.TENCHUYENMUC == null);
                SQLDataContext.SQLData.CHUYENMUCs.DeleteOnSubmit(chuyenmuc);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
