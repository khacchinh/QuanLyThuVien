using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.ComponentModel;

namespace BUS
{
    public class BaoCao_ThongKe_Bus
    {
        public BaoCao_ThongKe_Bus()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        public DataTable LoadDuLieuTacGia()
        {
            return ConvertToDataTable(SQLDataContext.SQLData.TACGIAs.ToList());
        }
        

        public DataTable LoadDuLieuNXB()
        {
            return ConvertToDataTable(SQLDataContext.SQLData.NXBs.ToList());
        }

        public DataTable LoadDuLieuTheLoai()
        {
            return ConvertToDataTable(SQLDataContext.SQLData.PHANLOAISACHes.ToList());
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        
        public DataTable LoadDuLieuSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("TENLOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("SLCONLAI", typeof(string));

            var thongke = SQLDataContext.SQLData.sp_ThongKe_BaoCaoSach();
            int c = 1;

            foreach (var i in thongke)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["TENLOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["SLDANGMUON"] = i.SLDANGMUON;     
                r["SLCONLAI"] = (int.Parse(i.SOLUONG.ToString()) - int.Parse(i.SLDANGMUON.ToString())).ToString();
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        
        public DataTable LoadDuLieuDocGiaQuaHan(int loai, DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));

            var thongke = SQLDataContext.SQLData.sp_ThongKe_BaoCaoBanDocQuaHan(loai, tungay, denngay);
            int c = 1;

            foreach (var i in thongke)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

    }
}
