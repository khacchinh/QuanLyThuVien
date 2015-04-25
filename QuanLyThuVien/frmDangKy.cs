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
    public partial class frmDangKy : Form
    {
        private DangKy_BUS dk = new DangKy_BUS();
        private DANGKY dangky = new DANGKY();
        public frmDangKy()
        {
            InitializeComponent();

        }

        private void LoadDuLieuDangKy()
        {
            m_dgvDK.DataSource = dk.LoadDuLieuDangKy();
        }

        private void m_btnThem_Click(object sender, EventArgs e)
        {
            m_txtMaDK.Text = "";
            m_txtMadocgia.Text = "";
            m_txtMaTL.Text = "";
            m_txtTenDG.Text = "";
            m_txtTenTL.Text = "";
            m_rtbGhiChu.Text = "";
            m_dtpNgayDK.Text = "";
            m_btnLuu.Enabled = true;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            LoadDuLieuDangKy();
        }


        private void m_dgvDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = m_dgvDK.SelectedRows[0];
            m_txtMaDK.Text = row.Cells["MADK"].Value.ToString();
            m_txtMaTL.Text = row.Cells["MASACH"].Value.ToString();
            m_txtMadocgia.Text = row.Cells["MADG"].Value.ToString();
            m_dtpNgayDK.Text = row.Cells["NGAYDK"].Value.ToString();
            m_rtbGhiChu.Text = row.Cells["GHICHU"].Value.ToString();

        }

        private void m_btnXoa_Click(object sender, EventArgs e)
        {
            if (m_txtMaDK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Cancel)
                return;
            if (dk.DeleteDuLieuDangKy(m_txtMaDK.Text))
            {
                MessageBox.Show("Thành công");
                LoadDuLieuDangKy();
                return;
            }
            MessageBox.Show("Thất bại");

        }

        private void m_txtMadocgia_TextChanged(object sender, EventArgs e)
        {
            if (m_txtMadocgia.Text != "")
                m_txtTenDG.Text = dk.LoadTenDocGia(int.Parse(m_txtMadocgia.Text));
        }

        private void m_txtMaTL_TextChanged(object sender, EventArgs e)
        {
            m_txtTenTL.Text = dk.LoadTenTaiLieu(m_txtMaTL.Text);
        }

        private void m_btnSua_Click(object sender, EventArgs e)
        {
            if (m_txtMaDK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Cancel)
                return;
            dangky.MADK = m_txtMaDK.Text.ToUpper();
            dangky.MASACH = m_txtMaTL.Text.ToUpper();
            if (m_txtMadocgia.Text != "")
                dangky.MADG = int.Parse(m_txtMadocgia.Text);
            if (m_dtpNgayDK.Text != "")
                dangky.NGAYDK = DateTime.Parse(m_dtpNgayDK.Text);
            dangky.GHICHU = m_rtbGhiChu.Text;
            if (dk.UpdateDuLieuDangKy(dangky))
            {
                MessageBox.Show("Thành công");
                m_dgvDK.DataSource = dk.LoadDuLieuDangKy1();
                return;
            }
            MessageBox.Show("Thất bại");
        }

        private void m_btnLuu_Click(object sender, EventArgs e)
        {
            if (m_txtMaDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo");
                return;
            }
            dangky.MADK = m_txtMaDK.Text.ToUpper(); ;
            dangky.MASACH = m_txtMaTL.Text.ToUpper();
            if (m_txtMadocgia.Text != "")
                dangky.MADG = int.Parse(m_txtMadocgia.Text);
            if (m_dtpNgayDK.Text != "")
                dangky.NGAYDK = DateTime.Parse(m_dtpNgayDK.Text);
            dangky.GHICHU = m_rtbGhiChu.Text;
            if (dk.InsertDuLieuDangKy(dangky))
            {
                LoadDuLieuDangKy();
                MessageBox.Show("Thành công");
                return;
            }
            MessageBox.Show("Thất bại");
        }

        private void m_btnMuonSach_Click(object sender, EventArgs e)
        {
            if (m_txtMaDK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin!", "Thông báo");
                return;
            }
            frmQuanLy frm_quanly = new frmQuanLy(m_dgvDK.SelectedRows[0]);
            frm_quanly.Show();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
