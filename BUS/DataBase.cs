using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DataBase
    {
        public static BaoCao_ThongKe_Bus BaoCao
        { get; set; }
        public static ChuyenMuc_Bus ChuyenMuc
        { get; set; }
        public static DangKy_BUS DangKy
        { get; set; }
        public static DocGia_BUS DocGia
        { get; set; }
        public static Login_BUS Login
        { get; set; }
        public static NgonNgu_BUS NgonNgu
        { get; set; }
        public static NXB_BUS NXB
        { get; set; }
        public static PhieuMuon_Bus PhieuMuon
        { get; set; }
        public static QuaTrinhMuon_Bus QuaTrinhMuon
        { get; set; }
        public static QuiDinh_Bus QuiDinh
        { get; set; }
        public static Sach_BUS Sach
        { get; set; }
        public static TacGia_BUS TacGia
        { get; set; }
        public static TheLoai_BUS TheLoai
        { get; set; }
        public static TraCuu_Bus TraCuu
        { get; set; }
        public static ViTri_BUS ViTri
        { get; set; }
        public static bool IsLoad
        { get; set; }

        public static void InitDataBase()
        {
            BaoCao = new BaoCao_ThongKe_Bus();
            ChuyenMuc = new ChuyenMuc_Bus();
            DangKy = new DangKy_BUS();
            DocGia = new DocGia_BUS();
            Login = new Login_BUS();
            NgonNgu = new NgonNgu_BUS();
            NXB = new NXB_BUS();
            PhieuMuon = new PhieuMuon_Bus(); 
            QuaTrinhMuon = new QuaTrinhMuon_Bus();
            QuiDinh = new QuiDinh_Bus();
            Sach = new Sach_BUS();
            TacGia = new TacGia_BUS();
            TheLoai = new TheLoai_BUS();
            TraCuu = new TraCuu_Bus();
            ViTri = new ViTri_BUS();
            IsLoad = true;
        }

    }
}
