﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyThuVien
{
    public partial class frmBaoCao_ThongKe : Form
    {
        public frmBaoCao_ThongKe()
        {
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
        private void frmBaoCao_ThongKe_Load(object sender, EventArgs e)
        {
            DeleteDataNull();
            LoadDuLieuTacGia();
            LoadDuLieuNXB();
            LoadDuLieuTheLoai();
            LoadDuLieuSach();
            LoadDuLieuDocGiaQuaHan();
        }
        private void DeleteDataNull()
        {
            DataBase.Sach.DeleteMaSachMax();
            DataBase.NXB.DeleteMaNXBMax();
            DataBase.ChuyenMuc.DeleteMaCMMax();
            DataBase.TheLoai.DeleteMaTLMax();
            DataBase.TacGia.DeleteMaTGMax();
        }

        private void LoadDuLieuSach()
        {
            m_dgvSach.DataSource = DataBase.BaoCao.LoadDuLieuSach();
        }

        private void LoadDuLieuTacGia()
        {
            m_dgvTacGia.DataSource = DataBase.BaoCao.LoadDuLieuTacGia();
        }

        private void LoadDuLieuNXB()
        {
            m_dgvNXB.DataSource = DataBase.BaoCao.LoadDuLieuNXB();
        }

        private void LoadDuLieuTheLoai()
        {
            m_dgvTheLoai.DataSource = DataBase.BaoCao.LoadDuLieuTheLoai();
        }

        private void LoadDuLieuDocGiaQuaHan()
        {
            m_dgvQuaHan.DataSource = DataBase.BaoCao.LoadDuLieuDocGiaQuaHan(0, DateTime.Now, DateTime.Now);
        }

        private void m_cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DateTime.Parse(m_dtpQHTuNgay.Text)>=DateTime.Parse(m_drpQHDenNgay.Text)) return;

            switch (m_cbbType.SelectedItem.ToString())
            {
                case "Tất cả":
                    LoadDuLieuDocGiaQuaHan();
                    break;

                case "Theo thời gian":
                    m_dgvQuaHan.DataSource = DataBase.BaoCao.LoadDuLieuDocGiaQuaHan(1, DateTime.Parse(m_dtpQHTuNgay.Text), DateTime.Parse(m_drpQHDenNgay.Text));
                    break;

                default:
                    break;
            }
        }

        private void PrintData(DataGridView m_dgv)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xls) |*.xls | All Files (*.*) |*.*";
            save.ShowDialog();

            string path = save.FileName.ToString();
            if (path != "")
            {
                DataTable dataTable = new DataTable();
                dataTable = (DataTable)m_dgv.DataSource;          
                try
                {
                    ExpEcel(dataTable, path);
                    MessageBox.Show("Success");

                }
                catch
                {
                    MessageBox.Show("Youre fucking something up!!");

                }
                dataTable = null;
            }
        }
        
        private void ExpEcel(DataTable data, string path)
        {
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


            for (int i = 0; i < data.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = data.Columns[i].ColumnName;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                }
            }
            ws.Name = "Demo" + "fdsfdvbsd";
            wb.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            wb.Close(true, misValue, misValue);
            app.Quit();
        }

        private void m_btnSachExcel_Click(object sender, EventArgs e)
        {
            PrintData(m_dgvSach);
            
        }

        private void m_btnTGExcel_Click(object sender, EventArgs e)
        {
            PrintData(m_dgvTacGia);
        }

        private void m_btnTheLoaiExecl_Click(object sender, EventArgs e)
        {
            PrintData(m_dgvTheLoai);
        }

        private void m_btnNXBExcel_Click(object sender, EventArgs e)
        {
            PrintData(m_dgvNXB);
        }

        private void m_btnQHExcel_Click(object sender, EventArgs e)
        {
            PrintData(m_dgvQuaHan);
        }

        private void m_dtpQHTuNgay_ValueChanged(object sender, EventArgs e)
        {
            m_dgvQuaHan.DataSource = DataBase.BaoCao.LoadDuLieuDocGiaQuaHan(1, DateTime.Parse(m_dtpQHTuNgay.Text), DateTime.Parse(m_drpQHDenNgay.Text));
        }

        private void m_drpQHDenNgay_ValueChanged(object sender, EventArgs e)
        {
            m_dgvQuaHan.DataSource = DataBase.BaoCao.LoadDuLieuDocGiaQuaHan(1, DateTime.Parse(m_dtpQHTuNgay.Text), DateTime.Parse(m_drpQHDenNgay.Text));
        }

        private void m_btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btnPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(m_dgvSach, 0);
            frm.Show();
        }

        private void m_btnTGPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(m_dgvTacGia, 1);
            frm.Show();
        }

        private void m_btnTLPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(m_dgvTheLoai, 2);
            frm.Show();
        }

        private void m_btnNXBPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(m_dgvNXB, 3);
            frm.Show();
        }

        private void n_btnQuaHanPrint_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(m_dgvQuaHan, 4);
            frm.Show();
        }

        

    }
}
