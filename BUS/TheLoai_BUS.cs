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
        public TheLoai_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public DataTable LayDuLieuTL()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOAI", typeof(string));
            dt.Columns.Add("TENLOAI", typeof(string));
            dt.Columns.Add("MACHUYENMUC", typeof(string));

            var tem = SQLDataContext.SQLData.SP_LAYDULIEUTHELOAI();

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
                SuaTL(tl);
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
                SQLDataContext.SQLData.SP_SUATHELOAI(tl.MALOAI, tl.TENLOAI, tl.MACHUYENMUC);
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
                SQLDataContext.SQLData.SP_XOATHELOAI(tl.MALOAI);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lay ten the loai
        public string GetTenTheLoai(string matl)
        {
            try
            {
                return SQLDataContext.SQLData.PHANLOAISACHes.Single(tl => tl.MALOAI == matl).TENLOAI;
            }
            catch
            {
                return "";
            }
        }

        //lay ma chuyen muc lon nhat
        public string GetMaTLMax()
        {
            SQLDataContext.CreateDataContext();
            string theloai = "";
            try
            {
                //string masach = ""; 
                int maso;
                SQLDataContext.SQLData.sp_getMaTLMax(ref theloai);
                maso = int.Parse(theloai.Substring(2)) + 1;
                if (maso.ToString().Length == 1)
                    theloai = "TL00" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    theloai = "TL0" + maso.ToString();
                else theloai = "TL" + maso.ToString();

                PHANLOAISACH tl = new PHANLOAISACH();
                tl.MALOAI = theloai;
                SQLDataContext.SQLData.PHANLOAISACHes.InsertOnSubmit(tl);
                SQLDataContext.SQLData.SubmitChanges();
                return theloai;
            }
            catch
            {
                return "demo";
            }
        }
        //delete ma sach rong
        public void DeleteMaTLMax()
        {
            try
            {
                PHANLOAISACH phanloaisach = SQLDataContext.SQLData.PHANLOAISACHes.Single(tl => tl.TENLOAI == null);
                SQLDataContext.SQLData.PHANLOAISACHes.DeleteOnSubmit(phanloaisach);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
