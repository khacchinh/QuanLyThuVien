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

        private void LoadDuLieuQuiDinh()
        {
            m_dgvQD.DataSource = qd.LoadDuLieuQD();
        }
    }
}
