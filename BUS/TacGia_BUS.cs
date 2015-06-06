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
        public TacGia_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

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

            var tem = SQLDataContext.SQLData.SP_LAYDULIEUTG();

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
                SuaTG(tg);
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
                SQLDataContext.SQLData.SP_SUATG(tg.MATG, tg.TENTG, tg.DIACHI, tg.DIENTHOAI, tg.FAX, tg.EMAIL, tg.GHICHU);
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
                SQLDataContext.SQLData.SP_XOATG(tg.MATG);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string LayTenTG(string matg)
        {
            try
            {
                return SQLDataContext.SQLData.TACGIAs.Single(tg => tg.MATG == matg).TENTG;
            }
            catch
            {
                return "";
            }
        }
        public string LayMaTG(string tentg)
        {
            try
            {
                return SQLDataContext.SQLData.TACGIAs.Single(tg => tg.TENTG == tentg).MATG;
            }
            catch
            {
                return "";
            }
        }
        //lay ma sach lon nhat
        public string GetMaTGMax()
        {
            string matg = "";
            try
            {
                //string masach = ""; 
                int maso;
                SQLDataContext.SQLData.sp_getMaTGMax(ref matg);
                maso = int.Parse(matg.Substring(2)) + 1;
                if (maso.ToString().Length == 1)
                    matg = "TG00" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    matg = "TG0" + maso.ToString();
                else matg = "TG" + maso.ToString();

                SQLDataContext.CreateDataContext();
                TACGIA tg = new TACGIA();
                tg.MATG = matg;
                SQLDataContext.SQLData.TACGIAs.InsertOnSubmit(tg);
                SQLDataContext.SQLData.SubmitChanges();
                return matg;
            }
            catch
            {
                return "demo";
            }
        }
        //delete ma sach rong
        public void DeleteMaTGMax()
        {
            try
            {
                TACGIA tacgia = SQLDataContext.SQLData.TACGIAs.Single(tg =>tg.TENTG == null);
                SQLDataContext.SQLData.TACGIAs.DeleteOnSubmit(tacgia);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
