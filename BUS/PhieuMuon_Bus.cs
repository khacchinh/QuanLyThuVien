using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;


namespace BUS
{
    public class PhieuMuon_Bus
    {
        private SQL_QUANLYTHUVIENDataContext DB = new SQL_QUANLYTHUVIENDataContext();
        //Lấy thông tin phiếu mượn sách
        public DataTable LayDuLieuMuonSach()
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_LayDuLieuMuonSach();
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //Lấy họ tên đọc giả từ mã đọc giả.
        public string LayTenDG(int madg)
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

        //Lấy tên sách từ mã sách
        public string LayTenSach(string masach)
        {
            try
            {
                return DB.DAUSACHes.Where(ds => ds.MASACH == masach).FirstOrDefault().TENSACH;
            }
            catch
            {
                return null;
            }
        }

        //thêm dữ liệu mượn sách
        public bool InsertDuLieuPhieuMuónach(MUONSACH muonsach)
        {
            try
            {
                DB.sp_InsertDuLieuPhieuMuonSach(muonsach.MAPHIEUMUON, muonsach.MADG, muonsach.MASACH, muonsach.NGAYMUON, muonsach.NGAYTRA, muonsach.GHICHU);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //sửa dữ liệu phiếu mượn
        public bool UpdateDuLieuPhieuMuon(MUONSACH muonsach)
        {
            try
            {
                DB.sp_UpdateDuLieuPhieuMuon(muonsach.MAPHIEUMUON, muonsach.MADG, muonsach.MASACH, muonsach.NGAYMUON, muonsach.NGAYTRA, muonsach.GHICHU);
                return true;       
            }
            catch
            {
                return false;
            }
        }

        //xóa dữ liệu phiếu mượn
        public bool DeleteDuLieuPhieuMuon(MUONSACH muonsach)
        {
            try
            {
                DB.sp_DeleteDuLieuPhieuMuon(muonsach.MAPHIEUMUON);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //kiểm tra mã phiếu mượn
        public bool CheckMaPhieuMuon(MUONSACH muonsach)
        {
            try
            {
                int a = DB.sp_CheckMaPhieuMuon(muonsach.MAPHIEUMUON);
                if(a==1)
                  return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        //tìm kiếm phiếu mượn theo mã phiếu mượn
        public DataTable TimKiemPhieuMuonTheoMaPM(MUONSACH muonsach, DateTime tungay, DateTime denngay,int kt)
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_TimKiemPhieuMuonTheoMPM(muonsach.MAPHIEUMUON, tungay, denngay, kt);
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tìm kiếm phiếu mượn theo mã sách
        public DataTable TimKiemPhieuMuonTheoMaSach(MUONSACH muonsach, DateTime tungay, DateTime denngay, int kt)
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_TimKiemPhieuMuonTheoMS(muonsach.MASACH, tungay, denngay, kt);
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tìm kiếm phiếu mượn theo đọc giả
        public DataTable TimKiemPhieuMuonTheoMaDG(MUONSACH muonsach, DateTime tungay, DateTime denngay, int kt)
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_TimKiemPhieuMuonTheoMDG(muonsach.MADG, tungay, denngay, kt);
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tim kiem theo ten
        public DataTable TimKiemPhieuMuonTheoTenDG(string tendg, DateTime tungay, DateTime denngay, int kt)
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_TimKiemPhieuMuonTheoTenDG(tendg, tungay, denngay, kt);
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tim kiem theo tem tai lieu
        public DataTable TimKiemPhieuMuonTheoTenSach(string tensach)
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
            dt.Columns.Add("GHICHU", typeof(string));

            var phieumuon = DB.sp_TimKiemPhieuMuonTheoTenTaiLieu(tensach);
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
                r["GHICHU"] = i.GHICHU;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //kiem tra so sach muon theo ma doc gia
        public string SoSachtheoMaDG(int madg)
        {
            int? sosach = 0;
            try
            {
                DB.sp_KiemTraSosachChuaTraTheoMaDG(madg, ref sosach);
                return "Số lượng tài liệu chưa trả là: " + sosach.ToString();
            }
            catch
            {
                return "";
            }
        }

        //kiem tra so sach muon theo ten doc gia
        public string SoSachtheoTenDG(string tendg)
        {
            int? sosach = 0;
            try
            {
                DB.sp_KiemTraSosachChuaTraTheoTenDG(tendg, ref sosach);
                return "Số lượng tài liệu chưa trả là: " + sosach.ToString();
            }
            catch
            {
                return "";
            }
        }

        //kiem tra so sach muon theo ma tai leiu
        public string SoSachtheoMaSach(string masach )
        {
            int? sosach = 0;
            try
            {
                DB.sp_KiemTraSosachChuaTraTheoMaSach(masach, ref sosach);
                return "Số lượng tài liệu chưa trả là: " + sosach.ToString();
            }
            catch
            {
                return "";
            }
        }

        //kiem tra so sach muon theo ten tai leiu
        public string SoSachtheoTenSach(string tensach)
        {
            int? sosach = 0;
            try
            {
                DB.sp_KiemTraSosachChuaTraTheoTenSach(tensach, ref sosach);
                return "Số lượng tài liệu chưa trả là: " + sosach.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
