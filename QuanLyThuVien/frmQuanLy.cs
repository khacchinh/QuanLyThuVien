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
    public partial class frmQuanLy : Form
    {
        
        #region Khai báo một số biến
        private MUONSACH muonsach = new MUONSACH();
        private QUATRINHMUON quatrinhmuon = new QUATRINHMUON();
        private QUIDINH quidinh = new QUIDINH();
        private DataGridViewRow m_selectRow = new DataGridViewRow();
        private bool m_check = false;
        private string maxmapm = "";
        #endregion

        #region Các hàm cho form load
        public frmQuanLy()
        {
            InitializeComponent(); 
        }
        public frmQuanLy(DataGridViewRow row)
        {
            InitializeComponent();
            LoadDuLieuDK(row);
        }
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            LoadDuLieuPhieuMuon();
            LoadDuLieuQuaTrinhMuon();
            LoadDuLieuKT();
            LoadDate();
            m_lblMaNV.Text = frmMain.nhanvien.MANV;
            m_lblTenNV.Text = frmMain.nhanvien.TENNV;
            m_lblChucVu.Text = frmMain.nhanvien.CHUCVU;
 
        }
        private void LoadDuLieuDK(DataGridViewRow row)
        {
            m_txtPMSach.Text = row.Cells["MASACH"].Value.ToString();
            m_txtPMDG.Text = row.Cells["MADG"].Value.ToString();
            m_btnPMLuu.Enabled = true;
        }
        private void LoadDuLieuKT()
        {
           
        }
        //tab quản lý phiếu mượn
        private void LoadDuLieuPhieuMuon()
        {
            m_dgvPM.DataSource = DataBase.PhieuMuon.LayDuLieuMuonSach();
        }
        //tab quản lý phiếu trả
        private void LoadDuLieuQuaTrinhMuon()
        {
            m_dgvPT.DataSource = DataBase.QuaTrinhMuon.LayduLieuQuaTrinhMuon();

            //
            m_cbbPTHH.DataSource = DataBase.QuiDinh.LoadDuLieuQD();
            m_cbbPTHH.DisplayMember = "TENQUIDINH";
            m_cbbPTHH.ValueMember = "MAQUIDINH";
        }
        //tinh toan tien phat
        private void TinhToanTienPhat()
        {
            
            m_txtPTTienPhat.Text = "";
            m_txtPTsoNgayTre.Text = "";
            m_cbbPTHH.Enabled = true;
            DateTime ngayhen = DateTime.Parse(m_dtpPTNgayHenTra.Text);
            DateTime ngaytra = DateTime.Parse(m_dtpPTNgayTra.Text);
            int day = (ngaytra - ngayhen).Days;
            quatrinhmuon.MASACH = m_txtPTMaSach.Text;
            quidinh.MAQUIDINH = m_cbbPTHH.SelectedValue.ToString();
            float tienphat = DataBase.QuaTrinhMuon.TienPhat(quatrinhmuon, quidinh, day);
            m_txtPTTienPhat.Text = tienphat.ToString();
            if (day > 0)
                m_txtPTsoNgayTre.Text = day.ToString();
             
        }

        private void LockTextBoxQTM()
        {
            m_txtPTMaPhieuMuon.ReadOnly = true;
            m_txtPTMaDG.ReadOnly = true;
            m_txtPTHoten.ReadOnly = true;
            m_txtPTMaSach.ReadOnly = true;
            m_txtPTTenSach.ReadOnly = true;
            m_dtpPTNgayHenTra.Enabled = false;
            m_dtpPTNgayMuon.Enabled = false;
            m_cbbPTHH.Enabled = false;
        }
        private void UnLockTextBoxQTM()
        {
            m_txtPTMaPhieuMuon.ReadOnly = false; ;
            m_txtPTMaDG.ReadOnly = false;
            m_txtPTHoten.ReadOnly = false;
            m_txtPTMaSach.ReadOnly = false;
            m_txtPTTenSach.ReadOnly = false;
            m_dtpPTNgayHenTra.Enabled = true;
            m_dtpPTNgayMuon.Enabled = true;
            m_cbbPTHH.Enabled = true;
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
        #endregion

        #region Các sự kiên click chuột
        /// <summary>
        /// tab quản lý phiêu mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnPMSendPT_Click(object sender, EventArgs e)
        {
            if (m_txtPMMaPhieuMuon.Text == "" || m_txtPMDG.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần thao tac!!", "Thông báo");
                return;
            }
            m_tpMainQuanLy.SelectedIndex = 1;
            m_txtPTMaPhieuMuon.Text = m_txtPMMaPhieuMuon.Text;
            m_txtPTMaDG.Text = m_txtPMDG.Text;
            m_txtPTHoten.Text = m_txtPMHoTen.Text;
            m_txtPTMaSach.Text = m_txtPMSach.Text;
            m_txtPTTenSach.Text = m_txtPMTenSach.Text;
            m_dtpPTNgayMuon.Text = m_dtpPMNgayMuon.Text;
            m_dtpPTNgayHenTra.Text = m_dtpPMNgayTra.Text;
            if (DateTime.Parse(m_dtpPTNgayHenTra.Text) >= DateTime.Parse(m_dtpPTNgayTra.Text))
            {
                m_txtPTTienPhat.Text = "";
                m_txtPTsoNgayTre.Text = "";
                m_cbbPTHH.Enabled = false;
                return;
            }
            TinhToanTienPhat();
        }
        private void m_btnKTPM_Click(object sender, EventArgs e)
        {
            if (!m_check)
            {
                MessageBox.Show("Chọn thông tin cần thực hiện!!", "Thông báo");
                return;
            }

            m_tpMainQuanLy.SelectedIndex = 0;
            m_txtPMMaPhieuMuon.Text = m_selectRow.Cells["MAPHIEUMUON"].Value.ToString();
            m_txtPMDG.Text = m_selectRow.Cells["MADG"].Value.ToString();
            m_txtPTHoten.Text = m_selectRow.Cells["TENDG"].Value.ToString();
            m_txtPMSach.Text = m_selectRow.Cells["MASACH"].Value.ToString();
            m_txtPMTenSach.Text = m_selectRow.Cells["TENSACH"].Value.ToString();
            m_dtpPMNgayMuon.Text = m_selectRow.Cells["NGAYMUON"].Value.ToString();
            m_dtpPMNgayTra.Text = m_selectRow.Cells["NGAYTRA"].Value.ToString();  
            m_check = false;
        }
        private void m_btnKTPT_Click(object sender, EventArgs e)
        {
            if (!m_check)
            {
                MessageBox.Show("Chọn thông tin cần thực hiện!!", "Thông báo");
                return;
            }
            
            m_tpMainQuanLy.SelectedIndex = 1;
            m_txtPTMaPhieuMuon.Text = m_selectRow.Cells["MAPHIEUMUON"].Value.ToString();
            m_txtPTMaDG.Text = m_selectRow.Cells["MADG"].Value.ToString();
            m_txtPTHoten.Text = m_selectRow.Cells["TENDG"].Value.ToString();
            m_txtPTMaSach.Text = m_selectRow.Cells["MASACH"].Value.ToString();
            m_txtPTTenSach.Text = m_selectRow.Cells["TENSACH"].Value.ToString();
            m_dtpPTNgayMuon.Text = m_selectRow.Cells["NGAYMUON"].Value.ToString();
            m_dtpPTNgayHenTra.Text = m_selectRow.Cells["NGAYTRA"].Value.ToString();
            if (DateTime.Parse(m_dtpPTNgayHenTra.Text) >= DateTime.Parse(m_dtpPTNgayTra.Text))
            {
                m_txtPTTienPhat.Text = "";
                m_txtPTsoNgayTre.Text = "";
                m_cbbPTHH.Enabled = false;
                return;
            }
            TinhToanTienPhat();
            m_check = false;
        }
        private void m_dgvPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_selectRow = m_dgvPM.SelectedRows[0];
            m_txtPMMaPhieuMuon.Text = m_selectRow.Cells["MAPHIEUMUON"].Value.ToString();
            m_txtPMDG.Text = m_selectRow.Cells["MADG"].Value.ToString();
            m_txtPMHoTen.Text = m_selectRow.Cells["TENDG"].Value.ToString();
            m_txtPMSach.Text = m_selectRow.Cells["MASACH"].Value.ToString();
            m_txtPMTenSach.Text = m_selectRow.Cells["TENSACH"].Value.ToString();
            m_dtpPMNgayMuon.Text = m_selectRow.Cells["NGAYMUON"].Value.ToString();
            m_dtpPMNgayTra.Text = m_selectRow.Cells["NGAYTRA"].Value.ToString();
        }
        private void m_btnPMThem_Click(object sender, EventArgs e)
        {
            if(maxmapm=="")
                maxmapm = DataBase.PhieuMuon.GetMaPMMax(); 
            m_txtPMMaPhieuMuon.Text = maxmapm;
            m_btnPMLuu.Enabled = true;
            m_txtPMDG.Text = "";
            m_txtPMHoTen.Text = "";
            m_txtPMSach.Text = "";
            m_txtPMTenSach.Text = "";
            m_dtpPMNgayMuon.Text = "";
            m_dtpPMNgayTra.Text = "";
            LoadDate();
        }
        private void m_btnPMSua_Click(object sender, EventArgs e)
        {
            m_btnPMLuu.Enabled = false;
            if (m_txtPMMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa!!", "Thông báo");
                return;
            }
            muonsach.MAPHIEUMUON = m_txtPMMaPhieuMuon.Text.ToUpper();
            muonsach.MADG = int.Parse(m_txtPMDG.Text);
            muonsach.MASACH = m_txtPMSach.Text.ToUpper();
            muonsach.NGAYMUON = DateTime.Parse(m_dtpPMNgayMuon.Text);
            muonsach.NGAYTRA = DateTime.Parse(m_dtpPMNgayTra.Text);
            muonsach.GHICHU = m_rtbPMGhiChu.Text;
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.PhieuMuon.UpdateDuLieuPhieuMuon(muonsach))
            {
                maxmapm = "";
                LoadDuLieuPhieuMuon();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");

        }
        private void m_btnPMXoa_Click(object sender, EventArgs e)
        {
            if (m_txtPMMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!!", "Thông báo");
                return;
            }
            muonsach.MAPHIEUMUON = m_txtPMMaPhieuMuon.Text.ToUpper();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.PhieuMuon.DeleteDuLieuPhieuMuon(muonsach))
            {
                maxmapm = "";
                LoadDuLieuPhieuMuon();
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            m_txtPMMaPhieuMuon.Text = "";
            m_txtPMDG.Text = "";
            m_txtPMHoTen.Text = "";
            m_txtPMSach.Text = "";
            m_txtPMTenSach.Text = "";
            m_dtpPMNgayMuon.Text = "";
            m_dtpPMNgayTra.Text = "";
        }
        private void m_btnPMLuu_Click(object sender, EventArgs e)
        {
            if (m_txtPMMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
                return;
            }
            //
            muonsach.MAPHIEUMUON = m_txtPMMaPhieuMuon.Text.ToUpper();
            muonsach.MADG = int.Parse(m_txtPMDG.Text);
            muonsach.MASACH = m_txtPMSach.Text.ToUpper();
            muonsach.NGAYMUON = DateTime.Parse(m_dtpPMNgayMuon.Text);
            muonsach.NGAYTRA = DateTime.Parse(m_dtpPMNgayTra.Text);
            muonsach.GHICHU = m_rtbPMGhiChu.Text;
            if (DataBase.PhieuMuon.InsertDuLieuPhieuMuónach(muonsach))
            {
                maxmapm = "";
                LoadDuLieuPhieuMuon();
                m_btnPMLuu.Enabled = false;
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
        }
        private void m_tpCTPM_Click(object sender, EventArgs e)
        {
            LoadDuLieuPhieuMuon();
            LoadDate();
        }

        /// <summary>
        /// tab quản lý quá trình mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnPTQD_Click(object sender, EventArgs e)
        {
            frmQuiDinh frm_quidinh = new frmQuiDinh();
            frm_quidinh.ShowDialog();
        }
        private void m_btnPTLuu_Click(object sender, EventArgs e)
        {
            if (m_txtPTMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần lưu!", "Thông tin");
                return;
            }
            quatrinhmuon.MAPHIEUMUON = m_txtPTMaPhieuMuon.Text;
            quatrinhmuon.MADG = int.Parse(m_txtPTMaDG.Text);
            quatrinhmuon.MASACH = m_txtPTMaSach.Text;
            quatrinhmuon.NGAYMUON = DateTime.Parse(m_dtpPTNgayMuon.Text);
            quatrinhmuon.NGAYTRA = DateTime.Parse(m_dtpPTNgayHenTra.Text);
            if (m_txtPTsoNgayTre.Text != "")
                quatrinhmuon.SONGAYTRE = int.Parse(m_txtPTsoNgayTre.Text);
            quatrinhmuon.LYDO = m_rtbPTLyDo.Text;
            if (m_txtPTTienPhat.Text != "")
                quatrinhmuon.TIENPHAT = decimal.Parse(m_txtPTTienPhat.Text);
            quatrinhmuon.NGAYPHAT = DateTime.Parse(m_dtpPTNgayTra.Text);
            quatrinhmuon.GHICHU = "";
            if (DataBase.QuaTrinhMuon.InsertDuLieuQuaTrinhMuon(quatrinhmuon))
            {
                LoadDuLieuQuaTrinhMuon();
                LoadDuLieuPhieuMuon();
                MessageBox.Show("Thành công", "Thông báo");
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");

        }
        private void m_btnPTXoa_Click(object sender, EventArgs e)
        {
            if (m_txtPTMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa!", "Thông tin");
                return;
            }
            quatrinhmuon.MAPHIEUMUON = m_txtPTMaPhieuMuon.Text;
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.QuaTrinhMuon.DeleteDuLieuQuaTrinhMuon(quatrinhmuon))
            {
                LoadDuLieuQuaTrinhMuon();
                MessageBox.Show("Thành công", "Thông báo");
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }
        private void m_dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_selectRow = m_dgvPT.SelectedRows[0];
            m_txtPTMaPhieuMuon.Text = m_selectRow.Cells["MAPHIEUMUON"].Value.ToString();
            m_txtPTMaDG.Text = m_selectRow.Cells["MADG"].Value.ToString();
            m_txtPTHoten.Text = m_selectRow.Cells["TENDG"].Value.ToString();
            m_txtPTMaSach.Text = m_selectRow.Cells["MASACH"].Value.ToString();
            m_txtPTTenSach.Text = m_selectRow.Cells["TENSACH"].Value.ToString();
            m_dtpPTNgayMuon.Text = m_selectRow.Cells["NGAYMUON"].Value.ToString();
            m_dtpPTNgayHenTra.Text = m_selectRow.Cells["NGAYTRA"].Value.ToString();
            m_dtpPTNgayTra.Text = m_selectRow.Cells["NGAYPHAT"].Value.ToString();
            m_txtPTsoNgayTre.Text = m_selectRow.Cells["SONGAYTRE"].Value.ToString();
            m_txtPTTienPhat.Text = m_selectRow.Cells["TIENPHAT"].Value.ToString();
            m_rtbPTLyDo.Text = m_selectRow.Cells["LYDO"].Value.ToString();
            m_cbbPTHH.Enabled = false;
        }
        private void m_btnPTSua_Click(object sender, EventArgs e)
        {
            if (m_txtPTMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần sửa!", "Thông tin");
                return;
            }
            quatrinhmuon.MAPHIEUMUON = m_txtPTMaPhieuMuon.Text;
            quatrinhmuon.LYDO = m_rtbPTLyDo.Text;
            quatrinhmuon.NGAYPHAT = DateTime.Parse(m_dtpPTNgayTra.Text);
            if (m_txtPTsoNgayTre.Text != "")
                quatrinhmuon.SONGAYTRE = int.Parse(m_txtPTsoNgayTre.Text);
            quatrinhmuon.LYDO = m_rtbPTLyDo.Text;
            if (m_txtPTTienPhat.Text != "")
                quatrinhmuon.TIENPHAT = decimal.Parse(m_txtPTTienPhat.Text);
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (DataBase.QuaTrinhMuon.UpdateDuLieuQuaTrinhMuon(quatrinhmuon))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadDuLieuQuaTrinhMuon();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }
        private void m_tpCTPT_Click(object sender, EventArgs e)
        {
            m_txtPTMaPhieuMuon.Text = "";
            m_txtPTMaDG.Text = "";
            m_txtPTHoten.Text = "";
            m_txtPTMaSach.Text = "";
            m_txtPTTenSach.Text = "";
            m_dtpPTNgayMuon.Text = "";
            m_dtpPTNgayTra.Text = "";
            m_txtPTsoNgayTre.Text = "";
            m_txtPTTienPhat.Text = "";
            m_rtbPTLyDo.Text = "";
            LoadDuLieuQuaTrinhMuon();
            LoadDate();
        }
        /// <summary>
        /// tab kiem tra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_dgvKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_check = true;
            m_selectRow = m_dgvKT.SelectedRows[0];
        }
        private void m_tpKTSSCT_Click(object sender, EventArgs e)
        {
            m_txtKT.Text = "";
            m_txtKQ.Text = "";
            m_check = false;
        }
        #endregion

        #region Các sự kiện thay đổi dữ liệu, text change
        /// <summary>
        /// tab quản lý phiếu mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_txtPMDG_TextChanged(object sender, EventArgs e)
        {
            m_txtPMHoTen.Text = "";
            if (m_txtPMDG.Text == "") return;
            if (DataBase.PhieuMuon.LayTenDG(int.Parse(m_txtPMDG.Text)) != null)
                m_txtPMHoTen.Text = DataBase.PhieuMuon.LayTenDG(int.Parse(m_txtPMDG.Text));
        }
        private void m_txtPMSach_TextChanged(object sender, EventArgs e)
        {
            m_txtPMTenSach.Text = "";
            if (m_txtPMSach.Text == "") return;
            if (DataBase.PhieuMuon.LayTenSach(m_txtPMSach.Text) != null)
                m_txtPMTenSach.Text = DataBase.PhieuMuon.LayTenSach(m_txtPMSach.Text);
        }    
        private void m_txtPMMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            muonsach.MAPHIEUMUON = m_txtPMMaPhieuMuon.Text;
            if (DataBase.PhieuMuon.CheckMaPhieuMuon(muonsach))
            {
                m_txtPMMaPhieuMuon.ForeColor = Color.Red;
                return;
            }
            m_txtPMMaPhieuMuon.ForeColor = Color.Black;
        }
        private void m_txtPMSeach_TextChanged(object sender, EventArgs e)
        {
            DateTime tungay = DateTime.Parse(m_dtpPMTuNgay.Text);
            DateTime denngay = DateTime.Parse(m_dtpPMDenNgay.Text);
            if (denngay < tungay||m_cbbPMSeachType.SelectedItem==null)
                return;

            switch (m_cbbPMSeachType.SelectedItem.ToString())
            {
                case "Mã phiếu mượn":
                    muonsach.MAPHIEUMUON = m_txtPMSeach.Text;
                    m_dgvPM.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoMaPM(muonsach, tungay, denngay);
                    break;

                case "Mã đọc giả":
                    if (m_txtPMSeach.Text != "")
                    {
                        muonsach.MADG = int.Parse(m_txtPMSeach.Text);
                        m_dgvPM.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoMaDG(muonsach, tungay, denngay);
                    }
                    break;

                case "Mã sách":
                    muonsach.MASACH = m_txtPMSeach.Text;
                    m_dgvPM.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoMaSach(muonsach, tungay, denngay);
                    break;
                default:
                    LoadDuLieuPhieuMuon();
                    break;
            }
      //      if (m_dgvPM.DataSource == null)
             //   LoadDuLieuPhieuMuon();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            LoadDuLieuPhieuMuon();
        }
        /// <summary>
        /// tab quản lý quá trình mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_dtpPTNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(m_dtpPTNgayHenTra.Text) >= DateTime.Parse(m_dtpPTNgayTra.Text))
                m_cbbPTHH.Enabled = false;
            else
            {
                TinhToanTienPhat();
            }
        }
        private void m_cbbPTHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhToanTienPhat();
        }
        private void m_txtPTSeach_TextChanged(object sender, EventArgs e)
        {
            DateTime tungay = DateTime.Parse(m_dtpPTTuNgay.Text);
            DateTime denngay = DateTime.Parse(m_dtpPTDenNgay.Text);
            if (denngay < tungay || m_cbbPTTypeSeach.SelectedItem == null)
                return;

            switch (m_cbbPTTypeSeach.SelectedItem.ToString())
            {
                case "Mã phiếu":
                    quatrinhmuon.MAPHIEUMUON = m_txtPTSeach.Text;
                    m_dgvPT.DataSource = DataBase.QuaTrinhMuon.TimKiemQuaTrinhMuonTheoMaPhieu(quatrinhmuon, tungay, denngay);
                    break;

                case "Mã đọc giả":
                    if (m_txtPTSeach.Text != "")
                    {
                        quatrinhmuon.MADG = int.Parse(m_txtPTSeach.Text);
                        m_dgvPT.DataSource = DataBase.QuaTrinhMuon.TimKiemQuaTrinhMuonTheoMaDG(quatrinhmuon, tungay, denngay);
                    }
                    break;

                case "Mã sách":
                    quatrinhmuon.MASACH = m_txtPTSeach.Text;
                    m_dgvPT.DataSource = DataBase.QuaTrinhMuon.TimKiemQuaTrinhMuonTheoMaSach(quatrinhmuon, tungay, denngay);
                    break;

                case "Tên đọc giả":
                    m_dgvPT.DataSource = DataBase.QuaTrinhMuon.TimKiemQuaTrinhMuonTheoTenDG(m_txtPTSeach.Text, tungay, denngay);
                    break;
                default:
                    LoadDuLieuPhieuMuon();
                    break;
            }
        }
        /// <summary>
        /// tab kiem tra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            m_txtPTMaPhieuMuon.Text = "";
            m_txtPTMaDG.Text = "";
            m_txtPTHoten.Text = "";
            m_txtPTMaSach.Text = "";
            m_txtPTTenSach.Text = "";
            m_dtpPTNgayMuon.Text = "";
            //m_dtpPTNgayHenTra.Text = "";
            m_dtpPTNgayTra.Text = "";
            m_txtPTsoNgayTre.Text = "";
            m_txtPTTienPhat.Text = "";
            m_rtbPTLyDo.Text = "";
        }
        private void m_txtKT_TextChanged(object sender, EventArgs e)
        {
            if (m_cbbKTType.SelectedItem == null || m_txtKT.Text == "")
            {
                // m_dgvKT.DataSource = null;
                return;
            }
            switch (m_cbbKTType.SelectedItem.ToString())
            {
                case "Mã đọc giả":
                    muonsach.MADG = int.Parse(m_txtKT.Text);
                    m_dgvKT.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoMaDG(muonsach, DateTime.Parse(m_dtpPMTuNgay.Text), DateTime.Parse(m_dtpPMTuNgay.Text));
                    m_txtKQ.Text = DataBase.PhieuMuon.SoSachtheoMaDG(int.Parse(m_txtKT.Text)).ToString();
                    break;

                case "Tên đọc giả":
                    m_dgvKT.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoTenDG(m_txtKT.Text, DateTime.Parse(m_dtpPMTuNgay.Text), DateTime.Parse(m_dtpPMTuNgay.Text));
                    m_txtKQ.Text = DataBase.PhieuMuon.SoSachtheoTenDG(m_txtKT.Text);
                    break;

                case "Mã tài liệu":
                    muonsach.MASACH = m_txtKT.Text;
                    m_dgvKT.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoMaSach(muonsach, DateTime.Parse(m_dtpPMTuNgay.Text), DateTime.Parse(m_dtpPMTuNgay.Text));
                    m_txtKQ.Text = DataBase.PhieuMuon.SoSachtheoMaSach(m_txtKT.Text);
                    break;

                case "Tên tài liệu":
                    m_dgvKT.DataSource = DataBase.PhieuMuon.TimKiemPhieuMuonTheoTenSach(m_txtKT.Text);
                    m_txtKQ.Text = DataBase.PhieuMuon.SoSachtheoTenSach(m_txtKT.Text);
                    break;

                default:
                    m_dgvKT.DataSource = null;
                    break;
            }
        }
        #endregion

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (m_cbbKTType.SelectedItem.ToString() != "Mã đọc giả") return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_dtpPMNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            LoadDate();
        }
        private void LoadDate()
        {
            DateTime dt = DateTime.Parse(m_dtpPMNgayMuon.Text);
            dt = dt.AddDays(5);
            m_dtpPMNgayTra.Text = dt.ToString();
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            DeleteMaPMMax();
            this.Close();
        }

        private void DeleteMaPMMax()
        {
            DataBase.PhieuMuon.DeleteMaPMMax();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
