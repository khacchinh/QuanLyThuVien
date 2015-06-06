using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class QuaTrinhMuon_Bus
    {
        public QuaTrinhMuon_Bus() {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        //lấy thông tin phiếu quá trình mượn(trả sách)
        public DataTable LayduLieuQuaTrinhMuon()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAPHIEUMUON", typeof(string));
            dt.Columns.Add("MADG", typeof(int));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));
            dt.Columns.Add("TIENPHAT", typeof(string));
            dt.Columns.Add("NGAYPHAT", typeof(string));
            dt.Columns.Add("LYDO", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));
            dt.Columns.Add("TRANGTHAI", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_LayDuLieuQuaTrinhMuon();
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAPHIEUMUON"] = i.MAPHIEUMUON;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                r["TIENPHAT"] = i.TIENPHAT;
                r["NGAYPHAT"] = i.NGAYPHAT;
                r["LYDO"] = i.LYDO;
                r["GHICHU"] = i.GHICHU;
                r["TRANGTHAI"] = i.TRANGTHAI;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tính tiền phạt 
        public float TienPhat(QUATRINHMUON quatrinhmuon, QUIDINH quidinh, int day)
        {
            double? tienphat = 0;
            SQLDataContext.SQLData.sp_TinhToanTienPhat(quatrinhmuon.MASACH, quidinh.MAQUIDINH, day, ref tienphat);
            return float.Parse(tienphat.ToString());
        }

        //thêm dữ liệu quá trình mượn
        public bool InsertDuLieuQuaTrinhMuon(QUATRINHMUON quatrinhmuon)
        {
            try
            {
                SQLDataContext.SQLData.sp_InsertduLieuQuaTrinhMuon(quatrinhmuon.MAPHIEUMUON, quatrinhmuon.MADG, quatrinhmuon.MASACH, quatrinhmuon.NGAYMUON, quatrinhmuon.NGAYTRA, quatrinhmuon.SONGAYTRE, quatrinhmuon.LYDO, quatrinhmuon.TIENPHAT, quatrinhmuon.NGAYPHAT, quatrinhmuon.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //xoa du lieu qua trinh muon
        public bool DeleteDuLieuQuaTrinhMuon(QUATRINHMUON quatrinhmuon)
        {
            try
            {
                SQLDataContext.SQLData.sp_DeleteDuLieuQuaTrinhMuon(quatrinhmuon.MAPHIEUMUON);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //sua du lieu qua trinh muon
        public bool UpdateDuLieuQuaTrinhMuon(QUATRINHMUON quatrinhmuon)
        {
            try
            {
                SQLDataContext.SQLData.sp_UpdateDuLieuQuaTrinhMuon(quatrinhmuon.MAPHIEUMUON, quatrinhmuon.LYDO, quatrinhmuon.NGAYPHAT, quatrinhmuon.SONGAYTRE, quatrinhmuon.TIENPHAT);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //tim kiem qua trinh muon theo ma phieu
        public DataTable TimKiemQuaTrinhMuonTheoMaPhieu(QUATRINHMUON quatrinhmuon, DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAPHIEUMUON", typeof(string));
            dt.Columns.Add("MADG", typeof(int));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));
            dt.Columns.Add("TIENPHAT", typeof(string));
            dt.Columns.Add("NGAYPHAT", typeof(string));
            dt.Columns.Add("LYDO", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));
            dt.Columns.Add("TRANGTHAI", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemQuaTrinhMuontheoMaPhieu(quatrinhmuon.MAPHIEUMUON, tungay, denngay);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAPHIEUMUON"] = i.MAPHIEUMUON;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                r["TIENPHAT"] = i.TIENPHAT;
                r["NGAYPHAT"] = i.NGAYPHAT;
                r["LYDO"] = i.LYDO;
                r["GHICHU"] = i.GHICHU;
                r["TRANGTHAI"] = i.TRANGTHAI;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tim kiem qua trinh muon theo ma doc gia
        public DataTable TimKiemQuaTrinhMuonTheoMaDG(QUATRINHMUON quatrinhmuon, DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAPHIEUMUON", typeof(string));
            dt.Columns.Add("MADG", typeof(int));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));
            dt.Columns.Add("TIENPHAT", typeof(string));
            dt.Columns.Add("NGAYPHAT", typeof(string));
            dt.Columns.Add("LYDO", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));
            dt.Columns.Add("TRANGTHAI", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemQuaTrinhMuontheoMaDG(quatrinhmuon.MADG, tungay, denngay);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAPHIEUMUON"] = i.MAPHIEUMUON;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                r["TIENPHAT"] = i.TIENPHAT;
                r["NGAYPHAT"] = i.NGAYPHAT;
                r["LYDO"] = i.LYDO;
                r["GHICHU"] = i.GHICHU;
                r["TRANGTHAI"] = i.TRANGTHAI;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tim kiem qua trinh muon theo ten doc gia
        public DataTable TimKiemQuaTrinhMuonTheoTenDG(string tendg, DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAPHIEUMUON", typeof(string));
            dt.Columns.Add("MADG", typeof(int));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));
            dt.Columns.Add("TIENPHAT", typeof(string));
            dt.Columns.Add("NGAYPHAT", typeof(string));
            dt.Columns.Add("LYDO", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));
            dt.Columns.Add("TRANGTHAI", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemQuaTrinhMuontheoTenDG(tendg, tungay, denngay);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAPHIEUMUON"] = i.MAPHIEUMUON;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                r["TIENPHAT"] = i.TIENPHAT;
                r["NGAYPHAT"] = i.NGAYPHAT;
                r["LYDO"] = i.LYDO;
                r["GHICHU"] = i.GHICHU;
                r["TRANGTHAI"] = i.TRANGTHAI;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tim kiem qua trinh muon theo m sach
        public DataTable TimKiemQuaTrinhMuonTheoMaSach(QUATRINHMUON quatrinhmuon, DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAPHIEUMUON", typeof(string));
            dt.Columns.Add("MADG", typeof(int));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("NGAYMUON", typeof(string));
            dt.Columns.Add("NGAYTRA", typeof(string));
            dt.Columns.Add("SONGAYTRE", typeof(string));
            dt.Columns.Add("TIENPHAT", typeof(string));
            dt.Columns.Add("NGAYPHAT", typeof(string));
            dt.Columns.Add("LYDO", typeof(string));
            dt.Columns.Add("GHICHU", typeof(string));
            dt.Columns.Add("TRANGTHAI", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemQuaTrinhMuontheoMaSach(quatrinhmuon.MASACH, tungay, denngay);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAPHIEUMUON"] = i.MAPHIEUMUON;
                r["MADG"] = i.MADG;
                r["TENDG"] = i.TENDG;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["NGAYMUON"] = i.NGAYMUON;
                r["NGAYTRA"] = i.NGAYTRA;
                r["SONGAYTRE"] = i.SONGAYTRE;
                r["TIENPHAT"] = i.TIENPHAT;
                r["NGAYPHAT"] = i.NGAYPHAT;
                r["LYDO"] = i.LYDO;
                r["GHICHU"] = i.GHICHU;
                r["TRANGTHAI"] = i.TRANGTHAI;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
