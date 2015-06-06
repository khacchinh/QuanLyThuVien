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
        private MUONSACH muonsach;
        public PhieuMuon_Bus()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }
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

            var phieumuon = SQLDataContext.SQLData.sp_LayDuLieuMuonSach();
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
                return SQLDataContext.SQLData.DOCGIAs.Where(dg => dg.MADG == madg).FirstOrDefault().TENDG.ToString();
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
                return SQLDataContext.SQLData.DAUSACHes.Where(ds => ds.MASACH == masach).FirstOrDefault().TENSACH;
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
                UpdateDuLieuPhieuMuon(muonsach);
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
                SQLDataContext.SQLData.sp_UpdateDuLieuPhieuMuon(muonsach.MAPHIEUMUON, muonsach.MADG, muonsach.MASACH, muonsach.NGAYMUON, muonsach.NGAYTRA, muonsach.GHICHU);
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
                SQLDataContext.SQLData.sp_DeleteDuLieuPhieuMuon(muonsach.MAPHIEUMUON);
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
                int a = SQLDataContext.SQLData.sp_CheckMaPhieuMuon(muonsach.MAPHIEUMUON);
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
        public DataTable TimKiemPhieuMuonTheoMaPM(MUONSACH muonsach, DateTime tungay, DateTime denngay)
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

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemPhieuMuonTheoMPM(muonsach.MAPHIEUMUON, tungay, denngay);
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
        public DataTable TimKiemPhieuMuonTheoMaSach(MUONSACH muonsach, DateTime tungay, DateTime denngay)
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

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemPhieuMuonTheoMS(muonsach.MASACH, tungay, denngay);
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
        public DataTable TimKiemPhieuMuonTheoMaDG(MUONSACH muonsach, DateTime tungay, DateTime denngay)
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

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemPhieuMuonTheoMDG(muonsach.MADG, tungay, denngay);
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
        public DataTable TimKiemPhieuMuonTheoTenDG(string tendg, DateTime tungay, DateTime denngay)
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

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemPhieuMuonTheoTenDG(tendg, tungay, denngay);
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

            var phieumuon = SQLDataContext.SQLData.sp_TimKiemPhieuMuonTheoTenTaiLieu(tensach);
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
                SQLDataContext.SQLData.sp_KiemTraSosachChuaTraTheoMaDG(madg, ref sosach);
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
                SQLDataContext.SQLData.sp_KiemTraSosachChuaTraTheoTenDG(tendg, ref sosach);
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
                SQLDataContext.SQLData.sp_KiemTraSosachChuaTraTheoMaSach(masach, ref sosach);
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
                SQLDataContext.SQLData.sp_KiemTraSosachChuaTraTheoTenSach(tensach, ref sosach);
                return "Số lượng tài liệu chưa trả là: " + sosach.ToString();
            }
            catch
            {
                return "";
            }
        }

        //lay ma phieu muon lon nhat
        public string GetMaPMMax(){
            try{
                string mapm = ""; int maso;
                SQLDataContext.SQLData.sp_getMaPMMax(ref mapm);
                maso = int.Parse(mapm.Substring(2))+1;
                if(maso.ToString().Length == 1)
                    mapm =  "PM000" + maso.ToString();
                else if (maso.ToString().Length == 2)
                    mapm = "PM00" + maso.ToString();
                else if(maso.ToString().Length == 3)
                    mapm = "PM0" + maso.ToString();
                else mapm = "PM" + maso.ToString();

                SQLDataContext.CreateDataContext();
                muonsach = new MUONSACH();
                muonsach.MAPHIEUMUON = mapm;
                SQLDataContext.SQLData.MUONSACHes.InsertOnSubmit(muonsach);
                SQLDataContext.SQLData.SubmitChanges();
                return mapm;
            }
            catch{
                return "demo";
            }
        }
        public void DeleteMaPMMax()
        {
            try
            {
                muonsach = SQLDataContext.SQLData.MUONSACHes.Single(ms => ms.MASACH == null);
                SQLDataContext.SQLData.MUONSACHes.DeleteOnSubmit(muonsach);
                SQLDataContext.SQLData.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
