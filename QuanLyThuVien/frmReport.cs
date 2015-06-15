using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using QuanLyThuVien.Report;

namespace QuanLyThuVien
{
    public partial class frmReport : Form
    {
        private DataTable dt = new DataTable();
        public frmReport(DataGridView dgv, int key)
        {
            InitializeComponent();
            dt = dgv.DataSource as DataTable;
            crystalReportViewer1.ReportSource = null;
            PrintReport(key);
        }

        private void PrintReport(int key)
        {
            switch (key)
            {
                case 0:
                    CrystalReportDauSach rp = new CrystalReportDauSach();
                    rp.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rp;
                    crystalReportViewer1.Refresh();
                    break;
                case 1:
                    CrystalReportTacGia rptacgia = new CrystalReportTacGia();
                    rptacgia.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rptacgia;
                    crystalReportViewer1.Refresh();
                    break;
                case 2:
                    CrystalReportTheLoai rptheloai = new CrystalReportTheLoai();
                    rptheloai.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rptheloai;
                    crystalReportViewer1.Refresh();
                    break;
                case 3:
                    CrystalReportNXB rpnxb = new CrystalReportNXB();
                    rpnxb.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rpnxb;
                    crystalReportViewer1.Refresh();
                    break;

                case 4:
                    CrystalReportDocGiaQuaHan rpquahan = new CrystalReportDocGiaQuaHan();
                    rpquahan.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rpquahan;
                    crystalReportViewer1.Refresh();
                    break;
            }
        }
    }
}
