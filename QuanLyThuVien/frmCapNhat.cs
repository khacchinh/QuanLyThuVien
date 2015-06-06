using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace QuanLyThuVien
{
    public partial class frmCapNhat : Form
    {
        private DAUSACH sach = new DAUSACH();
        private NXB nxb = new NXB();
        private TACGIA tg = new TACGIA();
        private DOCGIA dg = new DOCGIA();
        private VITRI vitri = new VITRI();
        private PHANLOAISACH tl = new PHANLOAISACH();
        private CHUYENMUC cm = new CHUYENMUC();
        private DataGridViewRow m_selectedrow = new DataGridViewRow();
        private string masachmax = "";
        private string manxbmax = "";
        private string macmmax = "";
        private string matlmax = "";
        private string matgmax = "";
        public frmCapNhat()
        {
            InitializeComponent();

            LoadDuLieuCapNhatSach();
        }

        private void LoadDuLieuCapNhatSach()
        {
            //load du lieu vi tri
            m_cbbKho.DataSource = DataBase.ViTri.LoadDuLieuKho();
            m_cbbNgan.DataSource = DataBase.ViTri.LoadDuLieuNgan();
            m_cbbKe.DataSource = DataBase.ViTri.LoadDuLieuKe();
            DeleteDataNull();
        }

        private void m_btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            DeleteDataNull();
            this.Close();
        }

        private void DeleteDataNull()
        {
            DataBase.Sach.DeleteMaSachMax();
            DataBase.NXB.DeleteMaNXBMax();
            DataBase.ChuyenMuc.DeleteMaCMMax();
            DataBase.TheLoai.DeleteMaTLMax();
            DataBase.TacGia.DeleteMaTGMax();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    this.Invalidate();
                    return;
            }
            base.WndProc(ref m);
        }

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            KhoaDKSach();
            KhoaDKNXB();
            KhoaDKTG();
            //KhoaDKDG();
            KhoaDKTL();
            m_dgvSach.DataSource = DataBase.Sach.LayDuLieuSach();
            m_dgvTG.DataSource = DataBase.TacGia.LayDuLieuTG();
            //m_dgvDG.DataSource = dgbus.LayDuLieuDG();
            m_dgvTL.DataSource = DataBase.TheLoai.LayDuLieuTL();
            m_dgvCM.DataSource = DataBase.ChuyenMuc.LayDuLieuCM();
            m_dgvNXB.DataSource = DataBase.NXB.LayDuLieuNXB();

            m_cbbLoaiSach.DataSource = DataBase.TheLoai.LayDuLieuTL();
            m_cbbLoaiSach.DisplayMember = "TENLOAI";
            m_cbbLoaiSach.ValueMember = "MALOAI";

            m_cbbNXB.DataSource = DataBase.NXB.LayDuLieuNXB();
            m_cbbNXB.DisplayMember = "TENNXB";
            m_cbbNXB.ValueMember = "MANXB";

            m_cbbNN.DataSource = DataBase.Sach.LayDuLieuNN();
            m_cbbNN.DisplayMember = "TENNGONNGU";
            m_cbbNN.ValueMember = "MANGONNGU";

            m_cbbTLCM.DataSource = DataBase.ChuyenMuc.LayDuLieuCM();
            m_cbbTLCM.DisplayMember = "TENCHUYENMUC";
            m_cbbTLCM.ValueMember = "MACHUYENMUC";
        }
        #region Tab Sách

        void KhoaDKSach()
        {
            m_txtTenSach.Enabled = false;
            m_cbbLoaiSach.Enabled = false;
            m_txtMaTacGiaS.Enabled = false;
            m_cbbNN.Enabled = false;
            m_txtSoTrang.Enabled = false;
            m_txtSoTien.Enabled = false;
            m_txtMaVT.Enabled = false;
            m_cbbNXB.Enabled = false;
            m_txtSoluong.Enabled = false;

            m_btnThemS.Enabled = true;
            m_btnLuuS.Enabled = false;
            m_btnSuaS.Enabled = true;
            m_btnXoaS.Enabled = true;
        }

        void MoDKSach()
        {
            m_txtTenSach.Enabled = true;
            m_cbbLoaiSach.Enabled = true;
            m_txtMaTacGiaS.Enabled = true;
            m_cbbNN.Enabled = true;
            m_txtSoTrang.Enabled = true;
            m_txtSoTien.Enabled = true;
            m_txtSoluong.Enabled = true;
            m_cbbNXB.Enabled = true;
            m_btnLuuS.Enabled = true;
            m_btnSuaS.Enabled = true;
            m_btnThemS.Enabled = true;
            m_btnXoaS.Enabled = true;
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            MoDKSach();
            m_btnLuuS.Enabled = true;
            m_txtMaSach.Text = "";
            m_txtMaVT.Text = "";
            m_txtSoTien.Text = "0";
            m_txtSoTrang.Text = "0";
            m_txtMaTacGiaS.Text = "";
            m_txtTenSach.Text = "";
            m_cbbLoaiSach.Text = "";
            m_cbbNN.Text = "";
            m_cbbNXB.Text = "";

            m_btnThemS.Enabled = false;
            m_btnLuuS.Enabled = true;
            m_btnSuaS.Enabled = false;
            m_btnXoaS.Enabled = false;
        }

        private void m_btnLuuS_Click(object sender, EventArgs e)
        {
            MoDKSach();
            if (m_txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                return;
            }
            //
            sach.MASACH = m_txtMaSach.Text.ToUpper();
            sach.TENSACH = m_txtTenSach.Text;

            sach.MALOAISACH = m_cbbLoaiSach.SelectedValue.ToString();
            sach.MAVITRI = m_txtMaVT.Text.ToUpper();
            sach.MATG = DataBase.TacGia.LayMaTG(m_txtMaTacGiaS.Text.ToUpper());
            sach.TRANGTHAI = "OK";
            sach.MANGONNGU = m_cbbNN.SelectedValue.ToString();
            if(m_txtSoTrang.Text!="")
                sach.SOTRANG = int.Parse(m_txtSoTrang.Text);
            sach.MANXB = m_cbbNXB.SelectedValue.ToString();
            if(m_txtSoTien.Text!="")
                sach.SOTIEN = decimal.Parse(m_txtSoTien.Text);
            if (m_txtSoluong.Text != "")
                sach.SOLUONG = int.Parse(m_txtSoluong.Text);

            if (DataBase.Sach.ThemDuLieuSach(sach))
            {
                masachmax = "";
                m_dgvSach.DataSource = DataBase.Sach.LayDuLieuSach();
                m_btnLuuS.Enabled = false;
                MessageBox.Show("Thành công");
                return;
            }
            MessageBox.Show("Thất bại");
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            m_btnLuuS.Enabled = false;
            MoDKSach();
            if (m_txtMaSach.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            sach.MASACH = m_txtMaSach.Text.ToUpper();
            sach.TENSACH = m_txtTenSach.Text;
            sach.MALOAISACH = m_cbbLoaiSach.SelectedValue.ToString();
            sach.MAVITRI = m_txtMaVT.Text.ToUpper();
            sach.MATG = DataBase.TacGia.LayMaTG(m_txtMaTacGiaS.Text.ToUpper());
            sach.MANGONNGU = m_cbbNN.SelectedValue.ToString();
            sach.SOTRANG = int.Parse(m_txtSoTrang.Text);
            sach.MANXB = m_cbbNXB.SelectedValue.ToString();
            sach.SOTIEN = decimal.Parse(m_txtSoTien.Text);

            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.Sach.SuaDuLieuSach(sach))
            {
                masachmax = "";
                m_dgvSach.DataSource = DataBase.Sach.LayDuLieuSach();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");

        }

        private void m_btnXoaS_Click(object sender, EventArgs e)
        {
            if (m_txtMaSach.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            sach.MASACH = m_txtMaSach.Text.ToUpper();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.Sach.XoaDuLieuSach(sach))
            {
                masachmax = "";
                m_dgvSach.DataSource = DataBase.Sach.LayDuLieuSach();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtMaSach.Text = "";
            m_txtTenSach.Text = "";
            m_txtMaTacGiaS.Text = "";
            m_txtSoTrang.Text = "0";
            m_txtSoluong.Text = "0";
            m_txtSoTien.Text = "0";
            m_txtMaVT.Text = "";
            m_cbbLoaiSach.Text = "";
            m_cbbNN.Text = "";
            m_cbbNXB.Text = "";

        }

        private void m_dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKSach();
            m_selectedrow = m_dgvSach.SelectedRows[0];
            m_txtMaSach.Text = m_selectedrow.Cells["MASACH"].Value.ToString();
            m_txtTenSach.Text = m_selectedrow.Cells["TENSACH"].Value.ToString();
            m_cbbLoaiSach.Text = DataBase.TheLoai.GetTenTheLoai(m_selectedrow.Cells["MALOAISACH"].Value.ToString());
            m_txtMaTacGiaS.Text = DataBase.TacGia.LayTenTG(m_selectedrow.Cells["TACGIA"].Value.ToString());
            m_cbbNN.Text = DataBase.NgonNgu.GetTenNgonNgu(m_selectedrow.Cells["NGONNGU"].Value.ToString());
            m_txtSoTrang.Text = m_selectedrow.Cells["SOTRANG"].Value.ToString();
            m_cbbNXB.Text = DataBase.NXB.GetTenNXB(m_selectedrow.Cells["MANXB"].Value.ToString());
            m_txtSoTien.Text = m_selectedrow.Cells["SOTIEN"].Value.ToString();
            m_txtMaVT.Text = m_selectedrow.Cells["MAVITRI"].Value.ToString();
            m_txtSoluong.Text = m_selectedrow.Cells["SOLUONG"].Value.ToString();
            m_cbbKho.Text = DataBase.ViTri.LayTenKho(m_txtMaVT.Text);
            m_cbbNgan.Text = DataBase.ViTri.LayTenNgan(m_txtMaVT.Text);
            m_cbbKe.Text = DataBase.ViTri.LayTenKe(m_txtMaVT.Text);
        }

        #endregion

        #region Tab NXB
        void KhoaDKNXB()
        {
            m_txtTenNXB.Enabled = false;
            m_txtDiaChiNXB.Enabled = false;
            m_txtDienThoaiNXB.Enabled = false;
            m_txtFAXNXB.Enabled = false;
            m_txtEmailNXB.Enabled = false;
            m_txtWeb.Enabled = false;
            m_rtxtGhiChuNXB.Enabled = false;

            m_btnThemNXB.Enabled = true;
            m_btnLuuNXB.Enabled = false;
            m_btnSuaNXB.Enabled = true;
            m_btnXoaNXB.Enabled = true;
        }

        void MoDKNXB()
        {
            m_txtTenNXB.Enabled = true;
            m_txtDiaChiNXB.Enabled = true;
            m_txtDienThoaiNXB.Enabled = true;
            m_txtFAXNXB.Enabled = true;
            m_txtEmailNXB.Enabled = true;
            m_txtWeb.Enabled = true;
            m_rtxtGhiChuNXB.Enabled = true;
        }

        private void m_btnThemNXB_Click(object sender, EventArgs e)
        {
            if(manxbmax=="")
                manxbmax = DataBase.NXB.GetMaNXBMax();
            m_txtMaNXB.Text = manxbmax;
            if (m_btnLuuNXB.Enabled == true)
            {
                m_btnLuuNXB.Enabled = false;
                m_btnSuaNXB.Enabled = true;
                m_btnXoaNXB.Enabled = true;
            }
            else
            {
                MoDKNXB();
                m_btnLuuNXB.Enabled = true;
                m_txtTenNXB.Text = "";
                m_txtDiaChiNXB.Text = "";
                m_txtDienThoaiNXB.Text = "";
                m_txtFAXNXB.Text = "";
                m_txtEmailNXB.Text = "";
                m_txtWeb.Text = "";
                m_rtxtGhiChuNXB.Text = "";

                m_btnSuaNXB.Enabled = false;
                m_btnXoaNXB.Enabled = false;
                m_btnThemNXB.Enabled = false;
            }
        }

        private void m_btnLuuNXB_Click(object sender, EventArgs e)
        {
            manxbmax = "";
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                return;
            }

            nxb.MANXB = m_txtMaNXB.Text;
            nxb.TENNXB = m_txtTenNXB.Text;
            nxb.DIACHI = m_txtDiaChiNXB.Text;
            nxb.DIENTHOAI = m_txtDienThoaiNXB.Text;
            nxb.FAX = m_txtFAXNXB.Text;
            nxb.EMAIL = m_txtEmailNXB.Text;
            nxb.WEBSITE = m_txtWeb.Text;
            nxb.GHICHU = m_rtxtGhiChuNXB.Text;

            if (DataBase.NXB.ThemNXB(nxb))
            {
                m_txtMaNXB.Text = "";
                m_dgvNXB.DataSource = DataBase.NXB.LayDuLieuNXB();
                m_btnLuuNXB.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            KhoaDKNXB();
             
        }

        private void m_btnSuaNXB_Click(object sender, EventArgs e)
        {
            manxbmax = "";
            m_btnLuuNXB.Enabled = false;
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            MoDKNXB();
            nxb.MANXB = m_txtMaNXB.Text.ToUpper();
            nxb.TENNXB = m_txtTenNXB.Text;
            nxb.DIACHI = m_txtDiaChiNXB.Text;
            nxb.DIENTHOAI = m_txtDienThoaiNXB.Text;
            nxb.FAX = m_txtFAXNXB.Text;
            nxb.EMAIL = m_txtEmailNXB.Text;
            nxb.WEBSITE = m_txtWeb.Text;
            nxb.GHICHU = m_rtxtGhiChuNXB.Text;


            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.NXB.SuaNXB(nxb))
            {
                m_dgvNXB.DataSource = DataBase.NXB.LayDuLieuNXB();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }

        private void m_btnXoaNXB_Click(object sender, EventArgs e)
        {
            manxbmax = "";
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            nxb.MANXB = m_txtMaNXB.Text;
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.NXB.XoaNXB(nxb))
            {
                m_dgvNXB.DataSource = DataBase.NXB.LayDuLieuNXB();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtMaNXB.Text = "";
            m_txtTenNXB.Text = "";
            m_txtDiaChiNXB.Text = "";
            m_txtDienThoaiNXB.Text = "";
            m_txtFAXNXB.Text = "";
            m_txtEmailNXB.Text = "";
            m_txtWeb.Text = "";
            m_rtxtGhiChuNXB.Text = "";
        }

        private void m_dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKNXB();
            m_selectedrow = m_dgvNXB.SelectedRows[0];
            m_txtMaNXB.Text = m_selectedrow.Cells["MANXB"].Value.ToString();
            m_txtTenNXB.Text = m_selectedrow.Cells["TENNXB"].Value.ToString();
            m_txtDiaChiNXB.Text = m_selectedrow.Cells["DIACHI"].Value.ToString();
            m_txtDienThoaiNXB.Text = m_selectedrow.Cells["DIENTHOAI"].Value.ToString();
            m_txtFAXNXB.Text = m_selectedrow.Cells["FAX"].Value.ToString();
            m_txtEmailNXB.Text = m_selectedrow.Cells["EMAIL"].Value.ToString();
            m_txtWeb.Text = m_selectedrow.Cells["WEBSITE"].Value.ToString();
            m_rtxtGhiChuNXB.Text = m_selectedrow.Cells["GHICHU"].Value.ToString();
        }

        #endregion

        #region Tab Tác giả
        void KhoaDKTG()
        {
            m_txtMaTG.Enabled = false;
            m_txtTenTG.Enabled = false;
            m_txtDiaChiTG.Enabled = false;
            m_txtDienThoaiTG.Enabled = false;
            m_txtFAXTG.Enabled = false;
            m_txtEmailTG.Enabled = false;
            m_rtxtGhiChuTG.Enabled = false;

            m_btnThemTG.Enabled = true;
            m_btnLuuTG.Enabled = false;
            m_btnSuaTG.Enabled = true;
            m_btnXoaTG.Enabled = true;
        }

        void MoDKTG()
        {
            m_txtTenTG.Enabled = true;
            m_txtDiaChiTG.Enabled = true;
            m_txtDienThoaiTG.Enabled = true;
            m_txtFAXTG.Enabled = true;
            m_txtEmailTG.Enabled = true;
            m_rtxtGhiChuTG.Enabled = true;
        }

        private void m_btnThemTG_Click(object sender, EventArgs e)
        {
            if (m_btnLuuTG.Enabled == true)
            {
                m_btnLuuTG.Enabled = false;
                m_btnSuaTG.Enabled = true;
                m_btnXoaTG.Enabled = true;
                m_btnThemTG.Enabled = true;
            }
            else
            {
                MoDKTG();
                if (matgmax == "")
                    matgmax = DataBase.TacGia.GetMaTGMax();
                m_txtMaTG.Text = matgmax;
                m_txtTenTG.Text = "";
                m_txtDiaChiTG.Text = "";
                m_txtDienThoaiTG.Text = "";
                m_txtFAXTG.Text = "";
                m_txtEmailTG.Text = "";
                m_rtxtGhiChuTG.Text = "";

                m_btnLuuTG.Enabled = true;
                m_btnSuaTG.Enabled = false;
                m_btnXoaTG.Enabled = false;
                m_btnThemTG.Enabled = false;
            }
        }

        private void m_btnLuuTG_Click(object sender, EventArgs e)
        {
            if (m_txtMaTG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                return;
            }

            tg.MATG = m_txtMaTG.Text.ToUpper();
            tg.TENTG = m_txtTenTG.Text;
            tg.DIACHI = m_txtDiaChiTG.Text;
            tg.DIENTHOAI = m_txtDienThoaiTG.Text;
            tg.FAX = m_txtFAXTG.Text;
            tg.EMAIL = m_txtEmailTG.Text;
            tg.GHICHU = m_rtxtGhiChuTG.Text;

            if (DataBase.TacGia.ThemTG(tg))
            {
                matgmax = "";
                m_dgvTG.DataSource = DataBase.TacGia.LayDuLieuTG();
                m_btnLuuTG.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            KhoaDKTG();
        }

        private void m_btnSuaTG_Click(object sender, EventArgs e)
        {
            if (m_txtMaTG.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            MoDKTG();
            tg.MATG = m_txtMaTG.Text.ToUpper();
            tg.TENTG = m_txtTenTG.Text;
            tg.DIACHI = m_txtDiaChiTG.Text;
            tg.DIENTHOAI = m_txtDienThoaiTG.Text;
            tg.FAX = m_txtFAXTG.Text;
            tg.EMAIL = m_txtEmailTG.Text;
            tg.GHICHU = m_rtxtGhiChuTG.Text;

            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.TacGia.SuaTG(tg))
            {
                matgmax = "";
                m_dgvTG.DataSource = DataBase.TacGia.LayDuLieuTG();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }

        private void m_btnXoaTG_Click(object sender, EventArgs e)
        {
            if (m_txtMaTG.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            tg.MATG = m_txtMaTG.Text.ToUpper();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.TacGia.XoaTG(tg))
            {
                matgmax = "";
                m_dgvTG.DataSource = DataBase.TacGia.LayDuLieuTG();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtMaTG.Text = "";
            m_txtTenTG.Text = "";
            m_txtDiaChiTG.Text = "";
            m_txtDienThoaiTG.Text = "";
            m_txtFAXTG.Text = "";
            m_txtEmailTG.Text = "";
            m_rtxtGhiChuTG.Text = "";
        }

        private void m_dgvTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKTG();
            m_selectedrow = m_dgvTG.SelectedRows[0];
            m_txtMaTG.Text = m_selectedrow.Cells["MATG"].Value.ToString();
            m_txtTenTG.Text = m_selectedrow.Cells["TENTG"].Value.ToString();
            m_txtDiaChiTG.Text = m_selectedrow.Cells["DIACHI"].Value.ToString();
            m_txtDienThoaiTG.Text = m_selectedrow.Cells["DIENTHOAI"].Value.ToString();
            m_txtFAXTG.Text = m_selectedrow.Cells["FAX"].Value.ToString();
            m_txtEmailTG.Text = m_selectedrow.Cells["EMAIL"].Value.ToString();
            m_rtxtGhiChuTG.Text = m_selectedrow.Cells["GHICHU"].Value.ToString();
        }
        #endregion
        /*
        #region Tab Đọc giả
        void KhoaDKDG()
        {
            m_txtMaDG.Enabled = false;
            m_txtTenDG.Enabled = false;
            m_txtGioiTinhDG.Enabled = false;
            m_txtNgaySinhDG.Enabled = false;
            m_txtNoiSinhDG.Enabled = false;
            m_txtDiaChiDG.Enabled = false;
            m_txtDienThoaiDG.Enabled = false;
            m_txtEmailDG.Enabled = false;
            m_txtLop.Enabled = false;
            m_txtLoaiDG.Enabled = false;

            m_btnThemDG.Enabled = true;
            m_btnLuuDG.Enabled = false;
            m_btnSuaDG.Enabled = true;
            m_btnXoaDG.Enabled = true;
        }

        void MoDKDG()
        {
            m_txtMaDG.Enabled = true;
            m_txtTenDG.Enabled = true;
            m_txtGioiTinhDG.Enabled = true;
            m_txtNgaySinhDG.Enabled = true;
            m_txtNoiSinhDG.Enabled = true;
            m_txtDiaChiDG.Enabled = true;
            m_txtDienThoaiDG.Enabled = true;
            m_txtEmailDG.Enabled = true;
            m_txtLop.Enabled = true;
            m_txtLoaiDG.Enabled = true;
        }

        private void m_btnThemDG_Click(object sender, EventArgs e)
        {
            if (m_btnLuuDG.Enabled == true)
            {
                m_btnLuuDG.Enabled = false;
                m_btnSuaDG.Enabled = true;
                m_btnXoaDG.Enabled = true;
            }
            else
            {
                MoDKDG();
                m_txtMaDG.ReadOnly = false;
                m_txtMaDG.Text = "";
                m_txtTenDG.Text = "";
                m_txtGioiTinhDG.Text = "";
                m_txtNgaySinhDG.Text = "";
                m_txtNoiSinhDG.Text = "";
                m_txtDiaChiDG.Text = "";
                m_txtDienThoaiDG.Text = "";
                m_txtEmailDG.Text = "";
                m_txtLop.Text = "";
                m_txtLoaiDG.Text = "";

                m_btnLuuDG.Enabled = true;
                m_btnSuaDG.Enabled = false;
                m_btnXoaDG.Enabled = false;
            }
        }

        private void m_btnLuuDG_Click(object sender, EventArgs e)
        {
            try
            {
                m_txtMaDG.ReadOnly = false;
                if (m_txtMaDG.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                    return;
                }

                dg.MADG = int.Parse(m_txtMaDG.Text);
                dg.TENDG = m_txtTenDG.Text;
                dg.GIOITINH = m_txtGioiTinhDG.Text;
                dg.NGAYSINH = DateTime.Parse(m_txtNgaySinhDG.Text);
                dg.NOISINH = m_txtNoiSinhDG.Text;
                dg.DIACHI = m_txtDiaChiDG.Text;
                dg.DIENTHOAI = m_txtDienThoaiDG.Text;
                dg.EMAIL = m_txtEmailTG.Text;
                dg.MALOP = m_txtLop.Text;
                dg.MALOAIDOCGIA = int.Parse(m_txtLoaiDG.Text);

                if (dgbus.ThemDG(dg))
                {
                    m_dgvDG.DataSource = dgbus.LayDuLieuDG();
                    m_btnLuuDG.Enabled = false;
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                KhoaDKDG();
            }
            catch { }
        }

        private void m_btnSuaDG_Click(object sender, EventArgs e)
        {
            m_btnLuuDG.Enabled = false;
            if (m_txtMaDG.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            m_txtMaDG.ReadOnly = true;
            MoDKDG();
            dg.MADG = int.Parse(m_txtMaDG.Text);
            dg.TENDG = m_txtTenDG.Text;
            dg.GIOITINH = m_txtGioiTinhDG.Text;
            dg.NGAYSINH = DateTime.Parse(m_txtNgaySinhDG.Text);
            dg.NOISINH = m_txtNoiSinhDG.Text;
            dg.DIACHI = m_txtDiaChiDG.Text;
            dg.DIENTHOAI = m_txtDienThoaiDG.Text;
            dg.EMAIL = m_txtEmailTG.Text;
            dg.MALOP = m_txtLop.Text;
            dg.MALOAIDOCGIA = int.Parse(m_txtLoaiDG.Text);

            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (dgbus.SuaDG(dg))
            {
                m_dgvDG.DataSource = dgbus.LayDuLieuDG();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }

        private void m_btnXoaDG_Click(object sender, EventArgs e)
        {
            if (m_txtMaDG.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            dg.MADG = int.Parse(m_txtMaDG.Text);
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (dgbus.XoaDG(dg))
            {
                m_dgvDG.DataSource = dgbus.LayDuLieuDG();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtMaDG.Text = "";
            m_txtTenDG.Text = "";
            m_txtGioiTinhDG.Text = "";
            m_txtNgaySinhDG.Text = "";
            m_txtNoiSinhDG.Text = "";
            m_txtDiaChiDG.Text = "";
            m_txtDienThoaiDG.Text = "";
            m_txtEmailDG.Text = "";
            m_txtLop.Text = "";
            m_txtLoaiDG.Text = "";
        }

        private void m_dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKDG();
            m_selectedrow = m_dgvDG.SelectedRows[0];
            m_txtMaDG.Text = m_selectedrow.Cells["MADG"].Value.ToString();
            m_txtTenDG.Text = m_selectedrow.Cells["TENDG"].Value.ToString();
            m_txtGioiTinhDG.Text = m_selectedrow.Cells["GIOITINH"].Value.ToString();
            m_txtNgaySinhDG.Text = m_selectedrow.Cells["NGAYSINH"].Value.ToString();
            m_txtNoiSinhDG.Text = m_selectedrow.Cells["NOISINH"].Value.ToString();
            m_txtDiaChiDG.Text = m_selectedrow.Cells["DIACHI"].Value.ToString();
            m_txtDienThoaiDG.Text = m_selectedrow.Cells["DIENTHOAI"].Value.ToString();
            m_txtEmailDG.Text = m_selectedrow.Cells["EMAIL"].Value.ToString();
            m_txtLop.Text = m_selectedrow.Cells["MALOP"].Value.ToString();
            m_txtLoaiDG.Text = m_selectedrow.Cells["MALOAIDOCGIA"].Value.ToString();
        }

        #endregion
        */
        #region Tab Thể Loại
        void KhoaDKTL()
        {
            m_txtMaTheLoai.Enabled = false;
            m_txtTenTheLoai.Enabled = false;
            m_cbbTLCM.Enabled = false;
            m_txtCMMCM.Enabled = false;
            m_txtTenChuyenMuc.Enabled = false;

            m_btnThemTL.Enabled = true;
            m_btnLuuTL.Enabled = false;
            m_btnSuaTL.Enabled = true;
            m_btnXoaTL.Enabled = true;
        }

        void MoDKTL()
        {
            m_txtTenTheLoai.Enabled = true;
            m_cbbTLCM.Enabled = true;
            m_txtCMMCM.Enabled = true;
            m_txtTenChuyenMuc.Enabled = true;
        }

        private void m_btnThemTL_Click(object sender, EventArgs e)
        {
            if (m_btnLuuTL.Enabled == false)
            {                
                if (m_rbtnTL.Checked == true)
                {
                    if (matlmax == "")
                        matlmax = DataBase.TheLoai.GetMaTLMax();
                    m_txtMaTheLoai.Text = matlmax;
                    m_txtTenTheLoai.Text = "";
                    MoDKTL();
                    m_btnLuuTL.Enabled = true;
                    m_btnSuaTL.Enabled = false;
                    m_btnXoaTL.Enabled = false;
                    m_btnThemTL.Enabled = false;
                }
                if (m_rbtnCM.Checked == true)
                {
                    if (macmmax == "")
                        macmmax = DataBase.ChuyenMuc.GetMaNXBMax();
                    m_txtCMMCM.Text = macmmax;
                    m_txtTenChuyenMuc.Text = "";
                    MoDKTL();
                    m_btnLuuTL.Enabled = true;
                    m_btnSuaTL.Enabled = false;
                    m_btnXoaTL.Enabled = false;
                    m_btnThemTL.Enabled = false;
                }
            }
            else
            {
                KhoaDKTL();   
            }

        }

        private void m_btnLuuTL_Click(object sender, EventArgs e)
        {
            if (m_rbtnTL.Checked == true)
            {
                if (m_txtMaTheLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                    return;
                }

                tl.MALOAI = m_txtMaTheLoai.Text.ToUpper();
                tl.TENLOAI = m_txtTenTheLoai.Text;
                tl.MACHUYENMUC = m_cbbTLCM.SelectedValue.ToString() ;

                if (DataBase.TheLoai.ThemTL(tl))
                {
                    matlmax = "";
                    m_dgvTL.DataSource = DataBase.TheLoai.LayDuLieuTL();
                    m_btnLuuTL.Enabled = false;
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                KhoaDKTL();
            }
            if (m_rbtnCM.Checked == true)
            {
                if (m_txtCMMCM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                    return;
                }

                cm.MACHUYENMUC = m_txtCMMCM.Text.ToUpper();
                cm.TENCHUYENMUC = m_txtTenChuyenMuc.Text;

                if (DataBase.ChuyenMuc.ThemCM(cm))
                {
                    macmmax = "";
                    m_dgvCM.DataSource = DataBase.ChuyenMuc.LayDuLieuCM();
                    m_btnLuuTL.Enabled = false;
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                KhoaDKTL();
            }
        }

        private void m_btnSuaTL_Click(object sender, EventArgs e)
        {
            if (m_rbtnTL.Checked == true)
            {
                m_btnLuuTL.Enabled = false;
                if (m_txtMaTheLoai.Text == "")
                {
                    MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                    return;
                }
                m_txtMaTheLoai.ReadOnly = true;
                MoDKTL();
                tl.MALOAI = m_txtMaTheLoai.Text.ToUpper();
                tl.TENLOAI = m_txtTenTheLoai.Text;
                tl.MACHUYENMUC = m_cbbTLCM.SelectedValue.ToString();

                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (DataBase.TheLoai.SuaTL(tl))
                {
                    matlmax = "";
                    m_dgvTL.DataSource = DataBase.TheLoai.LayDuLieuTL();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
            }
            if (m_rbtnCM.Checked == true)
            {
                m_btnLuuTL.Enabled = false;
                if (m_txtCMMCM.Text == "")
                {
                    MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                    return;
                }
                m_txtCMMCM.ReadOnly = true;
                MoDKTL();
                cm.MACHUYENMUC = m_txtCMMCM.Text.ToUpper();
                cm.TENCHUYENMUC = m_txtTenChuyenMuc.Text;

                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (DataBase.ChuyenMuc.SuaCM(cm))
                {
                    macmmax = "";
                    m_dgvCM.DataSource = DataBase.ChuyenMuc.LayDuLieuCM();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void m_btnXoaTL_Click(object sender, EventArgs e)
        {
            if (m_rbtnTL.Checked == true)
            {
                if (m_txtMaTheLoai.Text == "")
                {
                    MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                    return;
                }
                tl.MALOAI = m_txtMaTheLoai.Text.ToUpper();
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (DataBase.TheLoai.XoaTL(tl))
                {
                    matlmax = "";
                    m_dgvTL.DataSource = DataBase.TheLoai.LayDuLieuTL();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                m_txtMaTheLoai.Text = "";
                m_txtTenTheLoai.Text = "";
            }
            if (m_rbtnCM.Checked == true)
            {
                if (m_txtCMMCM.Text == "")
                {
                    MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                    return;
                }
                cm.MACHUYENMUC = m_txtCMMCM.Text.ToUpper();
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (DataBase.ChuyenMuc.XoaCM(cm))
                {
                    macmmax = "";
                    m_dgvCM.DataSource = DataBase.ChuyenMuc.LayDuLieuCM();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                m_txtCMMCM.Text = "";
                m_txtTenChuyenMuc.Text = "";
            }
        }

        private void m_dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKTL();
            m_selectedrow = m_dgvTL.SelectedRows[0];
            m_txtMaTheLoai.Text = m_selectedrow.Cells["MALOAI"].Value.ToString();
            m_txtTenTheLoai.Text = m_selectedrow.Cells["TENLOAI"].Value.ToString();
            m_cbbTLCM.Text = DataBase.ChuyenMuc.LayTenChuyenMuc(m_selectedrow.Cells["MACHUYENMUC"].Value.ToString());
        }

        private void m_dgvCM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MoDKTL();
            m_selectedrow = m_dgvCM.SelectedRows[0];
            m_txtCMMCM.Text = m_selectedrow.Cells["MACHUYENMUC"].Value.ToString();
            m_txtTenChuyenMuc.Text = m_selectedrow.Cells["TENCHUYENMUC"].Value.ToString();
        }
        #endregion

        private void m_btnSuaDG_Click(object sender, EventArgs e)
        {

        }

        private void m_btnLuuDG_Click(object sender, EventArgs e)
        {

        }

        private void m_btnThemDG_Click(object sender, EventArgs e)
        {

        }

        private void m_btnThemS_Click(object sender, EventArgs e)
        {
            if(masachmax=="")
                masachmax = DataBase.Sach.GetMaSachMax();
            MoDKSach();
            m_btnLuuS.Enabled = true;
            m_txtMaSach.Text = masachmax;
            m_txtSoTien.Text = "0";
            m_txtSoTrang.Text = "0";
            m_txtSoluong.Text = "0";
            m_txtMaTacGiaS.Text = "";
            m_txtTenSach.Text = "";
            m_cbbLoaiSach.Text = "";
            m_cbbNN.Text = "";
            m_cbbNXB.Text = "";

            m_btnThemS.Enabled = false;
            m_btnLuuS.Enabled = true;
            m_btnSuaS.Enabled = false;
            m_btnXoaS.Enabled = false;
        }

        private void m_cbbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_txtMaVT.Text = DataBase.ViTri.LoadDuLieuViTri(int.Parse(m_cbbKho.SelectedItem.ToString()), int.Parse(m_cbbNgan.SelectedItem.ToString()), int.Parse(m_cbbKe.SelectedItem.ToString()));
        }

        private void m_cbbNgan_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_txtMaVT.Text = DataBase.ViTri.LoadDuLieuViTri(int.Parse(m_cbbKho.SelectedItem.ToString()), int.Parse(m_cbbNgan.SelectedItem.ToString()), int.Parse(m_cbbKe.SelectedItem.ToString()));
        }

        private void m_cbbKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_txtMaVT.Text = DataBase.ViTri.LoadDuLieuViTri(int.Parse(m_cbbKho.SelectedItem.ToString()), int.Parse(m_cbbNgan.SelectedItem.ToString()), int.Parse(m_cbbKe.SelectedItem.ToString()));
        }

    }
}
