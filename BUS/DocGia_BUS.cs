using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class DocGia_BUS
    {
        public DocGia_BUS()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public DataTable LayDuLieuDG()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MALOAIDOCGIA", typeof(string));

            var tem = SQLDataContext.SQLData.SP_LAYDULIEUDG();

            foreach (var i in tem)
            {
                DataRow r = dt.NewRow();

                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["NOISINH"] = i.NOISINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["MALOP"] = i.MALOP;
                r["MALOAIDOCGIA"] = i.MALOAIDOCGIA;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public bool ThemDG(DOCGIA dg)
        {
            try
            {
                SQLDataContext.SQLData.SP_THEMDG(dg.MADG, dg.TENDG, dg.GIOITINH, dg.NGAYSINH, dg.NOISINH, dg.DIACHI, dg.DIENTHOAI, dg.EMAIL, dg.MALOP, dg.MALOAIDOCGIA);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDG(DOCGIA dg)
        {
            try
            {
                SQLDataContext.SQLData.SP_SUADG(dg.MADG, dg.TENDG, dg.GIOITINH, dg.NGAYSINH, dg.NOISINH, dg.DIACHI, dg.DIENTHOAI, dg.EMAIL, dg.MALOP, dg.MALOAIDOCGIA);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDG(DOCGIA dg)
        {
            try
            {
                SQLDataContext.SQLData.SP_XOADG(dg.MADG);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
