using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
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
    }
}
