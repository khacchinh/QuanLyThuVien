using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class TraCuu_Bus
    {
        public TraCuu_Bus()
        {
            if (!SQLDataContext.IsLoad)
                SQLDataContext.CreateDataContext();
        }

        #region tra cứu sách
        //tra cuu tai lieu theo ma sach
        public DataTable TraCuuTLtheoMaSach(string masach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("THELOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string)); 
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("TINHTRANG", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDauSachTheoMaTaiLieu(masach);
            int c = 1, slsachmuon = 0;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["THELOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["SLDANGMUON"] = i.SLDANGMUON;
                slsachmuon = int.Parse(i.SLDANGMUON.ToString());
                if (slsachmuon < int.Parse(i.SOLUONG.ToString()))
                    r["TINHTRANG"] = "Sẵn sàng";
                else r["TINHTRANG"] = "Đang mượn"; 
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu tai lieu theo ten sach
        public DataTable TraCuuTLtheoTenSach(string tensach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("THELOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("TINHTRANG", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDauSachTheoTenTaiLieu(tensach);
            int c = 1, slsachmuon = 0;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["THELOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                r["SLDANGMUON"] = i.SLDANGMUON;
                slsachmuon = int.Parse(i.SLDANGMUON.ToString());
                if (slsachmuon < int.Parse(i.SOLUONG.ToString()))
                    r["TINHTRANG"] = "Sẵn sàng";
                else r["TINHTRANG"] = "Đang mượn"; 
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu tai lieu theo ten tac gia
        public DataTable TraCuuTLtheoTenTG(string tentg)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("THELOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("TINHTRANG", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDauSachTheoTacGia(tentg);
            int c = 1, slsachmuon = 0;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["THELOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                r["SLDANGMUON"] = i.SLDANGMUON;
                slsachmuon = int.Parse(i.SLDANGMUON.ToString());
                if (slsachmuon < int.Parse(i.SOLUONG.ToString()))
                    r["TINHTRANG"] = "Sẵn sàng";
                else r["TINHTRANG"] = "Đang mượn"; 
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu tai lieu theo ten the loai
        public DataTable TraCuuTLtheoTentheLoai(string tentheloai)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("THELOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("TINHTRANG", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDauSachTheoTenTheLoai(tentheloai);
            int c = 1, slsachmuon =0;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["THELOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                r["SLDANGMUON"] = i.SLDANGMUON;
                slsachmuon = int.Parse(i.SLDANGMUON.ToString());
                if (slsachmuon < int.Parse(i.SOLUONG.ToString()))
                    r["TINHTRANG"] = "Sẵn sàng";
                else r["TINHTRANG"] = "Đang mượn"; 
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu tai lieu theo ten nxb
        public DataTable TraCuuTLtheoTentheNXB(string nxb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("TENSACH", typeof(string));
            dt.Columns.Add("TENTG", typeof(string));
            dt.Columns.Add("TENNXB", typeof(string));
            dt.Columns.Add("THELOAI", typeof(string));
            dt.Columns.Add("SOTRANG", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("TENNGONNGU", typeof(string));
            dt.Columns.Add("SOTIEN", typeof(string));
            dt.Columns.Add("KHO", typeof(string));
            dt.Columns.Add("NGAN", typeof(string));
            dt.Columns.Add("KE", typeof(string));
            dt.Columns.Add("SLDANGMUON", typeof(string));
            dt.Columns.Add("TINHTRANG", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDauSachTheoTenNXB(nxb);
            int c = 1, slsachmuon;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MASACH"] = i.MASACH;
                r["TENSACH"] = i.TENSACH;
                r["TENTG"] = i.TENTG;
                r["TENNXB"] = i.TENNXB;
                r["THELOAI"] = i.TENLOAI;
                r["SOTRANG"] = i.SOTRANG;
                r["SOLUONG"] = i.SOLUONG;
                r["TENNGONNGU"] = i.TENNGONNGU;
                r["SOTIEN"] = i.SOTIEN;
                r["KHO"] = i.KHO;
                r["NGAN"] = i.NGAN;
                r["KE"] = i.KE;
                r["SLDANGMUON"] = i.SLDANGMUON;
                slsachmuon = int.Parse(i.SLDANGMUON.ToString());
                if (slsachmuon < int.Parse(i.SOLUONG.ToString()))
                    r["TINHTRANG"] = "Sẵn sàng";
                else r["TINHTRANG"] = "Đang mượn"; 
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        #endregion

        #region tra cứu đọc giả

        //tra cuu doc gia theo mssv
        public DataTable TraCuuDGtheoMSSV(int madg)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENLOAIDG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("TENKHOA", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDocGiaTheoMSSV(madg);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENLOAIDG"] = i.TENDOCGIA;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NOISINH"] = i.NOISINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["TENLOP"] = i.TENLOP;
                r["TENKHOA"] = i.TENKHOA;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu doc gia theo ma giang vien
        public DataTable TraCuuDGtheoMGV(int madg)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENLOAIDG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("TENKHOA", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDocGiaTheoMaGV(madg);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENLOAIDG"] = i.TENDOCGIA;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NOISINH"] = i.NOISINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["TENLOP"] = i.TENLOP;
                r["TENKHOA"] = i.TENKHOA;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu doc gia theo ho ten
        public DataTable TraCuuDGtheoHoTen(string hoten)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENLOAIDG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("TENKHOA", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDocGiaTheoHoTen(hoten);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENLOAIDG"] = i.TENDOCGIA;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NOISINH"] = i.NOISINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["TENLOP"] = i.TENLOP;
                r["TENKHOA"] = i.TENKHOA;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu doc gia theo lop
        public DataTable TraCuuDGtheoLop(string tenlop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENLOAIDG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("TENKHOA", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDocGiaTheoLop(tenlop);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENLOAIDG"] = i.TENDOCGIA;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NOISINH"] = i.NOISINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["TENLOP"] = i.TENLOP;
                r["TENKHOA"] = i.TENKHOA;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //tra cuu doc gia theo khoa
        public DataTable TraCuuDGtheoKhoa(string tenkhoa)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MADG", typeof(string));
            dt.Columns.Add("TENLOAIDG", typeof(string));
            dt.Columns.Add("TENDG", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("NOISINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("DIENTHOAI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("TENKHOA", typeof(string));

            var phieumuon = SQLDataContext.SQLData.sp_TimDocGiaTheoKhoa(tenkhoa);
            int c = 1;

            foreach (var i in phieumuon)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MADG"] = i.MADG;
                r["TENLOAIDG"] = i.TENDOCGIA;
                r["TENDG"] = i.TENDG;
                r["GIOITINH"] = i.GIOITINH;
                r["NOISINH"] = i.NOISINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["DIENTHOAI"] = i.DIENTHOAI;
                r["EMAIL"] = i.EMAIL;
                r["TENLOP"] = i.TENLOP;
                r["TENKHOA"] = i.TENKHOA;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        #endregion



    }
}
