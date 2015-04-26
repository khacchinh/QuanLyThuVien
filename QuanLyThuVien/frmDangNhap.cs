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
    public partial class frmDangNhap : Form
    {
        private Login_BUS login_bus = new Login_BUS();
        private NHANVIEN nhanvien = new NHANVIEN();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void m_btnMain_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }

        private void m_btnLogin_Click(object sender, EventArgs e)
        {
            if (login_bus.Login(m_txtID.Text, m_txtPass.Text, ref nhanvien))
            {
                this.Visible = false;
                frmMain.nhanvien = nhanvien;
                frmMain frm = new frmMain();
                frm.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Đăng nhập thất bại, thông tin đăng nhập không chính xác");
            nhanvien = null;
        }
    }
}
