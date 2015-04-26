using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        static public NHANVIEN nhanvien = new NHANVIEN();
        public frmMain()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
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
        private void m_btnQuanLy_Click(object sender, EventArgs e)
        {
            frmQuanLy frm_quanly = new frmQuanLy();
            frm_quanly.ShowDialog();
        }

        private void m_btnTraCuu_Click(object sender, EventArgs e)
        {
            frmTraCuu frm_tracuu = new frmTraCuu();
            frm_tracuu.ShowDialog();
        }

        private void m_btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao_ThongKe frm_baocao = new frmBaoCao_ThongKe();
            frm_baocao.ShowDialog();
        }

        private void m_btnCapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhat frm_capnhat = new frmCapNhat();
            frm_capnhat.ShowDialog();
        }

        private void m_btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm_about = new frmAbout();
            frm_about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
