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
    public class DangKy_BUS
    {
        SQL_QUANLYTHUVIENDataContext DB = new SQL_QUANLYTHUVIENDataContext();

        public DataTable LoadDuLieuDangKy()
        {
            DataTable dataTable = new DataTable();
            dataTable = ConvertToDataTable(DB.DANGKies.ToList());
            dataTable.Columns.RemoveAt(6);
            dataTable.Columns.RemoveAt(5);
            return dataTable;
        }

        public DataTable LoadDuLieuDangKy1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADK", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("NGAYDK", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_DemoDangKi();
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADK"] = i.MADK;
                r["MASACH"] = i.MASACH;
                r["MADG"] = i.MADG;
                r["NGAYDK"] = i.NGAYDK;
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public string LoadTenDocGia(int madg)
        {
            try
            {
                return DB.DOCGIAs.Where(dg => dg.MADG == madg).FirstOrDefault().TENDG.ToString();
            }
            catch
            {
                return null;
            }
        }

        public string LoadTenTaiLieu(string matl)
        {
            try
            {
                return DB.DAUSACHes.Where(ds => ds.MASACH == matl).FirstOrDefault().TENSACH.ToString();
            }
            catch
            {
                return null;
            }
        }

        public bool DeleteDuLieuDangKy(string madk)
        {
            try
            {
                var dulieu = DB.DANGKies.SingleOrDefault(dk => dk.MADK == madk);
                DB.DANGKies.DeleteOnSubmit(dulieu);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDuLieuDangKy(DANGKY dangky)
        {
            try
            {
                DB.sp_UpdateDuLieuDangKi(dangky.MADK, dangky.MASACH, dangky.MADG, dangky.NGAYDK, dangky.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertDuLieuDangKy(DANGKY dangky)
        {
            try
            {
                DB.sp_InsertDuLieuDangKi(dangky.MADK, dangky.MASACH, dangky.MADG, dangky.NGAYDK, dangky.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
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
    }
}
