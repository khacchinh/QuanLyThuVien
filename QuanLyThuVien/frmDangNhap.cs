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
        private NHANVIEN nhanvien = new NHANVIEN();
        public frmDangNhap()
        {
            InitializeComponent();

            if (!DataBase.IsLoad)
                DataBase.InitDataBase();
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
        private void m_btnMain_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }

        private void m_btnLogin_Click(object sender, EventArgs e)
        {
            DataBase.InitDataBase();
            if (DataBase.Login.Login(m_txtID.Text, m_txtPass.Text, ref nhanvien))
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

        private void m_btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            if (keydata == Keys.Enter)
            {
                DataBase.InitDataBase();
                if (DataBase.Login.Login(m_txtID.Text, m_txtPass.Text, ref nhanvien))
                {
                    this.Visible = false;
                    frmMain.nhanvien = nhanvien;
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
