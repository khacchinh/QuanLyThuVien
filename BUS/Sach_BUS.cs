using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class Sach_BUS
    {
        public Sach_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }


        public DataTable LayDuLieuSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("MALOAISACH", typeof(string));
            dt.Columns.Add("TACGIA", typeof(string));
            dt.Columns.Add("MAVITRI", typeof(string));
            dt.Columns.Add("NGONNGU", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("MANXB", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));

            var dausach = from ds in SQLDataContext.SQLData.DAUSACHes
                          where(ds.TENSACH!= null)
                          select ds;

            foreach (var i in dausach)
            {
                DataRow r = dt.NewRow();

                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["MALOAISACH"] = i.MALOAISACH;
                r["TACGIA"] = i.MATG;
                r["NGONNGU"] = i.MANGONNGU;
                r["SOTRANG"] = i.SOTRANG;
                r["MANXB"] = i.MANXB;
                r["SOTIEN"] = i.SOTIEN;
                r["MAVITRI"] = i.MAVITRI;
                r["SOLUONG"] = i.SOLUONG;

                dt.Rows.Add(r);
            }
            return dt;
        }

        public DataTable LayDuLieuNN()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MANGONNGU", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            var hop = SQLDataContext.SQLData.SP_LAYDULIEUNGONNGU();

            foreach (var i in hop)
            {
                DataRow r = dt.NewRow();

                r["MANGONNGU"] = i.MANGONNGU;
                r["TENNGONNGU"] = i.TENNGONNGU;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemDuLieuSach(DAUSACH sach)
        {
            try
            {
                SuaDuLieuSach(sach);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDuLieuSach(DAUSACH sach)
        {
            try
            {
                DAUSACH dausach = SQLDataContext.SQLData.DAUSACHes.Single(ds => ds.MASACH == sach.MASACH);
                dausach.TENSACH = sach.TENSACH;
                dausach.MALOAISACH = sach.MALOAISACH;
                dausach.MANGONNGU = sach.MANGONNGU;
                dausach.MAVITRI = sach.MAVITRI;
                dausach.SOLUONG = sach.SOLUONG;
                dausach.SOTIEN = sach.SOTIEN;
                dausach.SOTRANG = sach.SOTRANG;
                dausach.MANXB = sach.MANXB;
                dausach.MATG = sach.MATG;
                SQLDataContext.SQLData.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDuLieuSach(DAUSACH sach)
        {
            try
            {
                SQLDataContext.SQLData.SP_XOASACH(sach.MASACH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lay ma sach lon nhat
        public string GetMaSachMax()
        {
            SQLDataContext.CreateDataContext();
            string masach = "";
            try
            {
                //string masach = ""; 
                int maso;
                SQLDataContext.SQLData.sp_getMaSachMax(ref masach);
                maso = int.Parse(masach.Substring(2)) + 1;
                if (maso.ToString().Length == 1)
                    masach = "MS00" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    masach = "MS0" + maso.ToString();
                else masach = "MS" + maso.ToString();

                
                DAUSACH sach = new DAUSACH();
                sach.MASACH = masach;
                SQLDataContext.SQLData.DAUSACHes.InsertOnSubmit(sach);
                SQLDataContext.SQLData.SubmitChanges();
                return masach;
            }
            catch
            {
                return "demo";
            }
        }
        //delete ma sach rong
        public void DeleteMaSachMax()
        {
            try
            {
                DAUSACH dausach = SQLDataContext.SQLData.DAUSACHes.Single(ms => ms.TENSACH == null);
                SQLDataContext.SQLData.DAUSACHes.DeleteOnSubmit(dausach);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }

 
    }
}
