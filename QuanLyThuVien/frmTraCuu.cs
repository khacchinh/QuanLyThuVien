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

namespace QuanLyThuVien
{
    public partial class frmTraCuu : Form
    {
        private TraCuu_Bus tc = new TraCuu_Bus();
        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void m_txtTLSeach_TextChanged(object sender, EventArgs e)
        {
            if (m_cbbTraCuuTL.SelectedItem == null || m_txtTLSeach.Text =="") return;
            switch (m_cbbTraCuuTL.SelectedItem.ToString())
            {
                case "Mã tài liệu":
                    m_dgvTL.DataSource = tc.TraCuuTLtheoMaSach(m_txtTLSeach.Text);
                    break;

                case "Tên tài liệu":
                    m_dgvTL.DataSource = tc.TraCuuTLtheoTenSach(m_txtTLSeach.Text);
                    break;

                case "Thể loại":
                    m_dgvTL.DataSource = tc.TraCuuTLtheoTentheNXB(m_txtTLSeach.Text);
                    break;

                case "NXB":
                    m_dgvTL.DataSource = tc.TraCuuTLtheoTentheNXB(m_txtTLSeach.Text);
                    break;

                case "Tác giả":
                    m_dgvTL.DataSource = tc.TraCuuTLtheoTenTG(m_txtTLSeach.Text);
                    break;

                default:
                    m_dgvTL.DataSource = null;
                    break;
            }
                                
        }

        private void m_txtDGSeach_TextChanged(object sender, EventArgs e)
        {
            if (m_cbbDG.SelectedItem == null || m_txtDGSeach.Text == "") return;
            switch (m_cbbDG.SelectedItem.ToString())
            {
                case "MSSV":
                    m_dgvDG.DataSource = tc.TraCuuDGtheoMSSV(int.Parse(m_txtDGSeach.Text));
                    break;

                case "Mã giảng viên":
                    m_dgvDG.DataSource = tc.TraCuuDGtheoMGV(int.Parse(m_txtDGSeach.Text));
                    break;

                case "Họ tên":
                    m_dgvDG.DataSource = tc.TraCuuDGtheoHoTen(m_txtDGSeach.Text);
                    break;

                case "Lớp":
                    m_dgvDG.DataSource = tc.TraCuuDGtheoLop(m_txtDGSeach.Text);
                    break;

                case "Khoa":
                    m_dgvDG.DataSource = tc.TraCuuDGtheoKhoa(m_txtDGSeach.Text);
                    break;

                default:
                    m_dgvDG.DataSource = null;
                    break;
            }
                                
        }

        private void m_btnTLDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmdangky = new frmDangKy();
            frmdangky.ShowDialog();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (m_cbbDG.SelectedItem.ToString() != "MSSV" && m_cbbDG.SelectedItem.ToString() != "Mã giảng viên")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
