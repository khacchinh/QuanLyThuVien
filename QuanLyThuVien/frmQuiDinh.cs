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
    public partial class frmQuiDinh : Form
    {
        private QuiDinh_Bus qd = new QuiDinh_Bus();
        public frmQuiDinh()
        {
            InitializeComponent();
            LoadDuLieuQuiDinh();
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
        private void LoadDuLieuQuiDinh()
        {
            m_dgvQD.DataSource = qd.LoadDuLieuQD();
        }

        private void m_btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
