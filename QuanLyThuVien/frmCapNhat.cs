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
        Sach_BUS sachbus = new Sach_BUS();
        NXB_BUS nxbbus = new NXB_BUS();
        TacGia_BUS tgbus = new TacGia_BUS();
        DocGia_BUS dgbus = new DocGia_BUS();
        ChuyenMuc_Bus cmbus = new ChuyenMuc_Bus();
        TheLoai_BUS tlbus = new TheLoai_BUS();
        DAUSACH sach = new DAUSACH();
        NXB nxb = new NXB();
        TACGIA tg = new TACGIA();
        DOCGIA dg = new DOCGIA();
        VITRI vitri = new VITRI();
        PHANLOAISACH tl = new PHANLOAISACH();
        CHUYENMUC cm = new CHUYENMUC();
        DataGridViewRow m_selectedrow = new DataGridViewRow();
        public frmCapNhat()
        {
            InitializeComponent();
        }

        private void m_btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            m_dgvSach.DataSource = sachbus.LayDuLieuSach();
            m_dgvTG.DataSource = tgbus.LayDuLieuTG();
            //m_dgvDG.DataSource = dgbus.LayDuLieuDG();
            m_dgvTL.DataSource = tlbus.LayDuLieuTL();
            m_dgvCM.DataSource = cmbus.LayDuLieuCM();
            m_dgvNXB.DataSource = nxbbus.LayDuLieuNXB();

            m_cbbLoaiSach.DataSource = tlbus.LayDuLieuTL();
            m_cbbLoaiSach.DisplayMember = "TENLOAI";
            m_cbbLoaiSach.ValueMember = "MALOAI";

            m_cbbNXB.DataSource = nxbbus.LayDuLieuNXB();
            m_cbbNXB.DisplayMember = "TENNXB";
            m_cbbNXB.ValueMember = "MANXB";

            m_cbbNN.DataSource = sachbus.LayDuLieuNN();
            m_cbbNN.DisplayMember = "TENNGONNGU";
            m_cbbNN.ValueMember = "MANGONNGU";
        }
        #region Tab Sách

        void KhoaDKSach()
        {
            m_txtMaSach.Enabled = false;
            m_txtTenSach.Enabled = false;
            m_cbbLoaiSach.Enabled = false;
            m_txtMaTacGiaS.Enabled = false;
            m_cbbNN.Enabled = false;
            m_txtSoTrang.Enabled = false;
            m_txtSoTien.Enabled = false;
            m_txtMaVT.Enabled = false;
            m_txtKho.Enabled = false;
            m_txtKe.Enabled = false;
            m_txtNgan.Enabled = false;
            m_cbbNXB.Enabled = false;

            m_btnThemS.Enabled = true;
            m_btnLuuS.Enabled = false;
            m_btnSuaS.Enabled = true;
            m_btnXoaS.Enabled = true;
        }

        void MoDKSach()
        {
            m_txtMaSach.Enabled = true;
            m_txtTenSach.Enabled = true;
            m_cbbLoaiSach.Enabled = true;
            m_txtMaTacGiaS.Enabled = true;
            m_cbbNN.Enabled = true;
            m_txtSoTrang.Enabled = true;
            m_txtSoTien.Enabled = true;
            m_txtMaVT.Enabled = true;
            m_txtKho.Enabled = true;
            m_txtKe.Enabled = true;
            m_txtNgan.Enabled = true;
            m_cbbNXB.Enabled = true;
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            MoDKSach();
            m_txtMaSach.ReadOnly = false;
            m_btnLuuS.Enabled = true;
            m_txtKe.Text = "";
            m_txtKho.Text = "";
            m_txtMaSach.Text = "";
            m_txtMaVT.Text = "";
            m_txtNgan.Text = "";
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
            m_txtMaSach.ReadOnly = false;
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
            sach.MATG = m_txtMaTacGiaS.Text.ToUpper();
            sach.MANGONNGU = m_cbbNN.SelectedValue.ToString();
            if(m_txtSoTrang.Text!="")
                sach.SOTRANG = int.Parse(m_txtSoTrang.Text);
            sach.MANXB = m_cbbNXB.SelectedValue.ToString();
            if(m_txtSoTien.Text!="")
                sach.SOTIEN = decimal.Parse(m_txtSoTien.Text);

            vitri.MAVITRI = m_txtMaVT.Text.ToUpper();
            if (m_txtKho.Text != "")
                vitri.KHO = int.Parse(m_txtKho.Text);
            if (m_txtNgan.Text != "")
                vitri.NGAN = int.Parse(m_txtNgan.Text);
            if (m_txtKe.Text != "")
                vitri.KE = int.Parse(m_txtKe.Text);

            if (sachbus.ThemDuLieuSach(sach, vitri))
            {
                m_dgvSach.DataSource = sachbus.LayDuLieuSach();
                m_btnLuuS.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            MoDKSach();
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            m_btnLuuS.Enabled = false;
            if (m_txtMaSach.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            m_txtMaSach.ReadOnly = true;
            m_txtMaVT.ReadOnly = true;
            MoDKSach();
            sach.MASACH = m_txtMaSach.Text.ToUpper();
            sach.TENSACH = m_txtTenSach.Text;
            sach.MALOAISACH = m_cbbLoaiSach.SelectedValue.ToString();
            sach.MAVITRI = m_txtMaVT.Text.ToUpper();
            sach.MATG = m_txtMaTG.Text.ToUpper();
            sach.MANGONNGU = m_cbbNN.SelectedValue.ToString();
            sach.SOTRANG = int.Parse(m_txtSoTrang.Text);
            sach.MANXB = m_cbbNXB.SelectedValue.ToString();
            sach.SOTIEN = decimal.Parse(m_txtSoTien.Text);

            vitri.MAVITRI = m_txtMaVT.Text.ToUpper();
            vitri.KHO = int.Parse(m_txtKho.Text);
            vitri.NGAN = int.Parse(m_txtNgan.Text);
            vitri.KE = int.Parse(m_txtKe.Text);

            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (sachbus.SuaDuLieuSach(sach, vitri))
            {
                m_dgvSach.DataSource = sachbus.LayDuLieuSach();
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
            if (sachbus.XoaDuLieuSach(sach))
            {
                m_dgvSach.DataSource = sachbus.LayDuLieuSach();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtMaSach.Text = "";
            m_txtTenSach.Text = "";
            m_txtMaTacGiaS.Text = "";
            m_txtSoTrang.Text = "0";
            m_txtSoTien.Text = "0";
            m_txtMaVT.Text = "";
            m_txtKho.Text = "";
            m_txtNgan.Text = "";
            m_txtKe.Text = "";
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
            m_cbbLoaiSach.Text = m_selectedrow.Cells["MALOAISACH"].Value.ToString();
            m_txtMaTacGiaS.Text = m_selectedrow.Cells["TACGIA"].Value.ToString();
            m_cbbNN.Text = m_selectedrow.Cells["NGONNGU"].Value.ToString();
            m_txtSoTrang.Text = m_selectedrow.Cells["SOTRANG"].Value.ToString();
            m_cbbNXB.Text = m_selectedrow.Cells["MANXB"].Value.ToString();
            m_txtSoTien.Text = m_selectedrow.Cells["SOTIEN"].Value.ToString();
            m_txtMaVT.Text = m_selectedrow.Cells["MAVITRI"].Value.ToString();
            m_txtKho.Text = m_selectedrow.Cells["KHO"].Value.ToString();
            m_txtNgan.Text = m_selectedrow.Cells["NGAN"].Value.ToString();
            m_txtKe.Text = m_selectedrow.Cells["KE"].Value.ToString();
        }

        #endregion

        #region Tab NXB
        void KhoaDKNXB()
        {
            m_txtMaNXB.Enabled = false;
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
            m_txtMaNXB.Enabled = true;
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
            if (m_btnLuuNXB.Enabled == true)
            {
                m_btnLuuNXB.Enabled = false;
                m_btnSuaNXB.Enabled = true;
                m_btnXoaNXB.Enabled = true;
            }
            else
            {
                MoDKNXB();
                m_txtMaNXB.ReadOnly = false;
                m_btnLuuNXB.Enabled = true;
                m_txtMaNXB.Text = "";
                m_txtTenNXB.Text = "";
                m_txtDiaChiNXB.Text = "";
                m_txtDienThoaiNXB.Text = "";
                m_txtFAXNXB.Text = "";
                m_txtEmailNXB.Text = "";
                m_txtWeb.Text = "";
                m_rtxtGhiChuNXB.Text = "";

                m_btnLuuNXB.Enabled = true;
                m_btnSuaNXB.Enabled = false;
                m_btnXoaNXB.Enabled = false;
            }
        }

        private void m_btnLuuNXB_Click(object sender, EventArgs e)
        {
            m_txtMaNXB.ReadOnly = false;
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                return;
            }

            nxb.MANXB = m_txtMaNXB.Text.ToUpper();
            nxb.TENNXB = m_txtTenNXB.Text;
            nxb.DIACHI = m_txtDiaChiNXB.Text;
            nxb.DIENTHOAI = m_txtDienThoaiNXB.Text;
            nxb.FAX = m_txtFAXNXB.Text;
            nxb.EMAIL = m_txtEmailNXB.Text;
            nxb.WEBSITE = m_txtWeb.Text;
            nxb.GHICHU = m_rtxtGhiChuNXB.Text;

            if (nxbbus.ThemNXB(nxb))
            {
                m_dgvNXB.DataSource = nxbbus.LayDuLieuNXB();
                m_btnLuuNXB.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            KhoaDKNXB();
        }

        private void m_btnSuaNXB_Click(object sender, EventArgs e)
        {
            m_btnLuuNXB.Enabled = false;
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa", "Thông báo");
                return;
            }
            m_txtMaNXB.ReadOnly = true;
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
            if (nxbbus.SuaNXB(nxb))
            {
                m_dgvNXB.DataSource = nxbbus.LayDuLieuNXB();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }

        private void m_btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (m_txtMaNXB.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            nxb.MANXB = m_txtMaNXB.Text.ToUpper();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (nxbbus.XoaNXB(nxb))
            {
                m_dgvNXB.DataSource = nxbbus.LayDuLieuNXB();
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
            m_txtMaTG.Enabled = true;
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
            }
            else
            {
                MoDKTG();
                m_txtMaTG.ReadOnly = false;
                m_txtMaTG.Text = "";
                m_txtTenTG.Text = "";
                m_txtDiaChiTG.Text = "";
                m_txtDienThoaiTG.Text = "";
                m_txtFAXTG.Text = "";
                m_txtEmailTG.Text = "";
                m_rtxtGhiChuTG.Text = "";

                m_btnLuuTG.Enabled = true;
                m_btnSuaTG.Enabled = false;
                m_btnXoaTG.Enabled = false;
            }
        }

        private void m_btnLuuTG_Click(object sender, EventArgs e)
        {
            m_txtMaTG.ReadOnly = false;
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

            if (tgbus.ThemTG(tg))
            {
                m_dgvTG.DataSource = tgbus.LayDuLieuTG();
                m_btnLuuTG.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            KhoaDKTG();
        }

        private void m_btnSuaTG_Click(object sender, EventArgs e)
        {

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
            if (tgbus.XoaTG(tg))
            {
                m_dgvTG.DataSource = tgbus.LayDuLieuTG();
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
            m_txtTLMCM.Enabled = false;
            m_txtCMMCM.Enabled = false;
            m_txtTenChuyenMuc.Enabled = false;

            m_btnThemTL.Enabled = true;
            m_btnLuuTL.Enabled = false;
            m_btnSuaTL.Enabled = true;
            m_btnXoaTL.Enabled = true;
        }

        void MoDKTL()
        {
            m_txtMaTheLoai.Enabled = true;
            m_txtTenTheLoai.Enabled = true;
            m_txtTLMCM.Enabled = true;
            m_txtCMMCM.Enabled = true;
            m_txtTenChuyenMuc.Enabled = true;
        }

        private void m_btnThemTL_Click(object sender, EventArgs e)
        {
            if (m_btnLuuTL.Enabled == true)
            {
                m_btnLuuTL.Enabled = false;
                m_btnSuaTL.Enabled = true;
                m_btnXoaTL.Enabled = true;
            }
            else
            {
                MoDKTL();
                if (m_rbtnTL.Checked == true)
                {
                    m_txtMaTheLoai.ReadOnly = false;
                    m_txtMaTheLoai.Text = "";
                    m_txtTenTheLoai.Text = "";
                    m_txtTLMCM.Text = "";
                }
                else
                {
                    m_txtCMMCM.ReadOnly = false;
                    m_txtCMMCM.Text = "";
                    m_txtTenChuyenMuc.Text = "";
                }
                m_btnLuuTL.Enabled = true;
                m_btnSuaTL.Enabled = false;
                m_btnXoaTL.Enabled = false;
            }

        }

        private void m_btnLuuTL_Click(object sender, EventArgs e)
        {
            if (m_rbtnTL.Checked == true)
            {
                m_txtMaTheLoai.ReadOnly = false;
                if (m_txtMaTheLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                    return;
                }

                tl.MALOAI = m_txtMaTheLoai.Text.ToUpper();
                tl.TENLOAI = m_txtTenTheLoai.Text;
                tl.MACHUYENMUC = m_txtTLMCM.Text;

                if (tlbus.ThemTL(tl))
                {
                    m_dgvTL.DataSource = tlbus.LayDuLieuTL();
                    m_btnLuuTL.Enabled = false;
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                KhoaDKTL();
            }
            else
            {
                m_txtCMMCM.ReadOnly = false;
                if (m_txtCMMCM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                    return;
                }

                cm.MACHUYENMUC = m_txtCMMCM.Text.ToUpper();
                cm.TENCHUYENMUC = m_txtTenChuyenMuc.Text;

                if (cmbus.ThemCM(cm))
                {
                    m_dgvCM.DataSource = cmbus.LayDuLieuCM();
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
                tl.MACHUYENMUC = m_txtTLMCM.Text;

                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (tlbus.SuaTL(tl))
                {
                    m_dgvTL.DataSource = tlbus.LayDuLieuTL();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
            }
            else
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
                if (cmbus.SuaCM(cm))
                {
                    m_dgvCM.DataSource = cmbus.LayDuLieuCM();
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
                if (tlbus.XoaTL(tl))
                {
                    m_dgvTL.DataSource = tlbus.LayDuLieuTL();
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                m_txtMaTheLoai.Text = "";
                m_txtTenTheLoai.Text = "";
                m_txtTLMCM.Text = "";
            }
            else
            {
                if (m_txtCMMCM.Text == "")
                {
                    MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                    return;
                }
                cm.MACHUYENMUC = m_txtCMMCM.Text.ToUpper();
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                if (cmbus.XoaCM(cm))
                {
                    m_dgvCM.DataSource = cmbus.LayDuLieuCM();
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
            m_txtTLMCM.Text = m_selectedrow.Cells["MACHUYENMUC"].Value.ToString();
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
            MoDKSach();
            m_txtMaSach.ReadOnly = false;
            m_btnLuuS.Enabled = true;
            m_txtKe.Text = "";
            m_txtKho.Text = "";
            m_txtMaSach.Text = "";
            m_txtMaVT.Text = "";
            m_txtNgan.Text = "";
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
    }
}
