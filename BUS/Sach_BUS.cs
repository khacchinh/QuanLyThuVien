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
        private SQL_QUANLYTHUVIENDataContext db = new SQL_QUANLYTHUVIENDataContext();


        public DataTable LayDuLieuSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("MALOAISACH", typeof(string));
            dt.Columns.Add("TACGIA", typeof(string));
            dt.Columns.Add("NGONNGU", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("MANXB", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("MAVITRI", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));

            var hop = db.SP_LAYDULIEUSACH();

            foreach (var i in hop)
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
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public DataTable LayDuLieuNN()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MANGONNGU", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            var hop = db.SP_LAYDULIEUNGONNGU();

            foreach (var i in hop)
            {
                DataRow r = dt.NewRow();

                r["MANGONNGU"] = i.MANGONNGU;
                r["TENNGONNGU"] = i.TENNGONNGU;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemDuLieuSach(DAUSACH sach, VITRI vt)
        {
            try
            {
                db.SP_THEMSACH(sach.MASACH, sach.TENSACH, sach.MALOAISACH, sach.MATG, sach.MANGONNGU, sach.SOTRANG, sach.MANXB, sach.SOTIEN, vt.MAVITRI, vt.KHO, vt.NGAN, vt.KE, sach.SOLUONG);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDuLieuSach(DAUSACH sach, VITRI vt)
        {
            try
            {
                db.SP_SUASACH(sach.MASACH, sach.TENSACH, sach.MALOAISACH, sach.MATG, sach.MANGONNGU, sach.SOTRANG, sach.MANXB, sach.SOTIEN, sach.MAVITRI, vt.KHO, vt.NGAN, vt.KE);
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
                db.SP_XOASACH(sach.MASACH);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
