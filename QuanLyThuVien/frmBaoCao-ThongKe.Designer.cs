namespace QuanLyThuVien
{
    partial class frmBaoCao_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_tcBaocaoThongke = new System.Windows.Forms.TabControl();
            this.m_tpSach = new System.Windows.Forms.TabPage();
            this.m_btnSachExcel = new System.Windows.Forms.Button();
            this.m_dgvSach = new System.Windows.Forms.DataGridView();
            this.m_tpTG = new System.Windows.Forms.TabPage();
            this.m_btnTGExcel = new System.Windows.Forms.Button();
            this.m_dgvTacGia = new System.Windows.Forms.DataGridView();
            this.m_tbTheLoai = new System.Windows.Forms.TabPage();
            this.m_btnTheLoaiExecl = new System.Windows.Forms.Button();
            this.m_dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.m_tbNXB = new System.Windows.Forms.TabPage();
            this.m_btnNXBExcel = new System.Windows.Forms.Button();
            this.m_dgvNXB = new System.Windows.Forms.DataGridView();
            this.m_tpBGQuaHan = new System.Windows.Forms.TabPage();
            this.m_drpQHDenNgay = new System.Windows.Forms.DateTimePicker();
            this.m_dtpQHTuNgay = new System.Windows.Forms.DateTimePicker();
            this.m_btnQHExcel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.m_cbbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_dgvQuaHan = new System.Windows.Forms.DataGridView();
            this.m_tbTongHop = new System.Windows.Forms.TabPage();
            this.m_tcBaocaoThongke.SuspendLayout();
            this.m_tpSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvSach)).BeginInit();
            this.m_tpTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTacGia)).BeginInit();
            this.m_tbTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTheLoai)).BeginInit();
            this.m_tbNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvNXB)).BeginInit();
            this.m_tpBGQuaHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQuaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tcBaocaoThongke
            // 
            this.m_tcBaocaoThongke.Controls.Add(this.m_tpSach);
            this.m_tcBaocaoThongke.Controls.Add(this.m_tpTG);
            this.m_tcBaocaoThongke.Controls.Add(this.m_tbTheLoai);
            this.m_tcBaocaoThongke.Controls.Add(this.m_tbNXB);
            this.m_tcBaocaoThongke.Controls.Add(this.m_tpBGQuaHan);
            this.m_tcBaocaoThongke.Controls.Add(this.m_tbTongHop);
            this.m_tcBaocaoThongke.Location = new System.Drawing.Point(0, -2);
            this.m_tcBaocaoThongke.Name = "m_tcBaocaoThongke";
            this.m_tcBaocaoThongke.SelectedIndex = 0;
            this.m_tcBaocaoThongke.Size = new System.Drawing.Size(953, 545);
            this.m_tcBaocaoThongke.TabIndex = 0;
            // 
            // m_tpSach
            // 
            this.m_tpSach.Controls.Add(this.m_btnSachExcel);
            this.m_tpSach.Controls.Add(this.m_dgvSach);
            this.m_tpSach.Location = new System.Drawing.Point(4, 25);
            this.m_tpSach.Name = "m_tpSach";
            this.m_tpSach.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpSach.Size = new System.Drawing.Size(945, 516);
            this.m_tpSach.TabIndex = 0;
            this.m_tpSach.Text = "Sách";
            this.m_tpSach.UseVisualStyleBackColor = true;
            // 
            // m_btnSachExcel
            // 
            this.m_btnSachExcel.Location = new System.Drawing.Point(772, 35);
            this.m_btnSachExcel.Name = "m_btnSachExcel";
            this.m_btnSachExcel.Size = new System.Drawing.Size(139, 59);
            this.m_btnSachExcel.TabIndex = 1;
            this.m_btnSachExcel.Text = "Excel";
            this.m_btnSachExcel.UseVisualStyleBackColor = true;
            this.m_btnSachExcel.Click += new System.EventHandler(this.m_btnSachExcel_Click);
            // 
            // m_dgvSach
            // 
            this.m_dgvSach.AllowUserToAddRows = false;
            this.m_dgvSach.AllowUserToDeleteRows = false;
            this.m_dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvSach.Location = new System.Drawing.Point(0, 122);
            this.m_dgvSach.Name = "m_dgvSach";
            this.m_dgvSach.ReadOnly = true;
            this.m_dgvSach.RowTemplate.Height = 24;
            this.m_dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvSach.Size = new System.Drawing.Size(938, 398);
            this.m_dgvSach.TabIndex = 0;
            // 
            // m_tpTG
            // 
            this.m_tpTG.Controls.Add(this.m_btnTGExcel);
            this.m_tpTG.Controls.Add(this.m_dgvTacGia);
            this.m_tpTG.Location = new System.Drawing.Point(4, 25);
            this.m_tpTG.Name = "m_tpTG";
            this.m_tpTG.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpTG.Size = new System.Drawing.Size(945, 516);
            this.m_tpTG.TabIndex = 1;
            this.m_tpTG.Text = "Tác Giả";
            this.m_tpTG.UseVisualStyleBackColor = true;
            // 
            // m_btnTGExcel
            // 
            this.m_btnTGExcel.Location = new System.Drawing.Point(793, 26);
            this.m_btnTGExcel.Name = "m_btnTGExcel";
            this.m_btnTGExcel.Size = new System.Drawing.Size(126, 51);
            this.m_btnTGExcel.TabIndex = 3;
            this.m_btnTGExcel.Text = "Excel";
            this.m_btnTGExcel.UseVisualStyleBackColor = true;
            this.m_btnTGExcel.Click += new System.EventHandler(this.m_btnTGExcel_Click);
            // 
            // m_dgvTacGia
            // 
            this.m_dgvTacGia.AllowUserToAddRows = false;
            this.m_dgvTacGia.AllowUserToDeleteRows = false;
            this.m_dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTacGia.Location = new System.Drawing.Point(1, 109);
            this.m_dgvTacGia.Name = "m_dgvTacGia";
            this.m_dgvTacGia.ReadOnly = true;
            this.m_dgvTacGia.RowTemplate.Height = 24;
            this.m_dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvTacGia.Size = new System.Drawing.Size(938, 407);
            this.m_dgvTacGia.TabIndex = 0;
            // 
            // m_tbTheLoai
            // 
            this.m_tbTheLoai.Controls.Add(this.m_btnTheLoaiExecl);
            this.m_tbTheLoai.Controls.Add(this.m_dgvTheLoai);
            this.m_tbTheLoai.Location = new System.Drawing.Point(4, 25);
            this.m_tbTheLoai.Name = "m_tbTheLoai";
            this.m_tbTheLoai.Size = new System.Drawing.Size(945, 516);
            this.m_tbTheLoai.TabIndex = 2;
            this.m_tbTheLoai.Text = "Thể Loại";
            this.m_tbTheLoai.UseVisualStyleBackColor = true;
            // 
            // m_btnTheLoaiExecl
            // 
            this.m_btnTheLoaiExecl.Location = new System.Drawing.Point(785, 31);
            this.m_btnTheLoaiExecl.Name = "m_btnTheLoaiExecl";
            this.m_btnTheLoaiExecl.Size = new System.Drawing.Size(124, 49);
            this.m_btnTheLoaiExecl.TabIndex = 1;
            this.m_btnTheLoaiExecl.Text = "Excel";
            this.m_btnTheLoaiExecl.UseVisualStyleBackColor = true;
            this.m_btnTheLoaiExecl.Click += new System.EventHandler(this.m_btnTheLoaiExecl_Click);
            // 
            // m_dgvTheLoai
            // 
            this.m_dgvTheLoai.AllowUserToAddRows = false;
            this.m_dgvTheLoai.AllowUserToDeleteRows = false;
            this.m_dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTheLoai.Location = new System.Drawing.Point(0, 112);
            this.m_dgvTheLoai.Name = "m_dgvTheLoai";
            this.m_dgvTheLoai.ReadOnly = true;
            this.m_dgvTheLoai.RowTemplate.Height = 24;
            this.m_dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvTheLoai.Size = new System.Drawing.Size(938, 421);
            this.m_dgvTheLoai.TabIndex = 0;
            // 
            // m_tbNXB
            // 
            this.m_tbNXB.Controls.Add(this.m_btnNXBExcel);
            this.m_tbNXB.Controls.Add(this.m_dgvNXB);
            this.m_tbNXB.Location = new System.Drawing.Point(4, 25);
            this.m_tbNXB.Name = "m_tbNXB";
            this.m_tbNXB.Size = new System.Drawing.Size(945, 516);
            this.m_tbNXB.TabIndex = 3;
            this.m_tbNXB.Text = "NXB";
            this.m_tbNXB.UseVisualStyleBackColor = true;
            // 
            // m_btnNXBExcel
            // 
            this.m_btnNXBExcel.Location = new System.Drawing.Point(770, 29);
            this.m_btnNXBExcel.Name = "m_btnNXBExcel";
            this.m_btnNXBExcel.Size = new System.Drawing.Size(135, 54);
            this.m_btnNXBExcel.TabIndex = 1;
            this.m_btnNXBExcel.Text = "Excel";
            this.m_btnNXBExcel.UseVisualStyleBackColor = true;
            this.m_btnNXBExcel.Click += new System.EventHandler(this.m_btnNXBExcel_Click);
            // 
            // m_dgvNXB
            // 
            this.m_dgvNXB.AllowUserToAddRows = false;
            this.m_dgvNXB.AllowUserToDeleteRows = false;
            this.m_dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvNXB.Location = new System.Drawing.Point(3, 110);
            this.m_dgvNXB.Name = "m_dgvNXB";
            this.m_dgvNXB.ReadOnly = true;
            this.m_dgvNXB.RowTemplate.Height = 24;
            this.m_dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvNXB.Size = new System.Drawing.Size(945, 406);
            this.m_dgvNXB.TabIndex = 0;
            // 
            // m_tpBGQuaHan
            // 
            this.m_tpBGQuaHan.Controls.Add(this.m_drpQHDenNgay);
            this.m_tpBGQuaHan.Controls.Add(this.m_dtpQHTuNgay);
            this.m_tpBGQuaHan.Controls.Add(this.m_btnQHExcel);
            this.m_tpBGQuaHan.Controls.Add(this.label5);
            this.m_tpBGQuaHan.Controls.Add(this.m_cbbType);
            this.m_tpBGQuaHan.Controls.Add(this.label4);
            this.m_tpBGQuaHan.Controls.Add(this.label3);
            this.m_tpBGQuaHan.Controls.Add(this.m_dgvQuaHan);
            this.m_tpBGQuaHan.Location = new System.Drawing.Point(4, 25);
            this.m_tpBGQuaHan.Name = "m_tpBGQuaHan";
            this.m_tpBGQuaHan.Size = new System.Drawing.Size(945, 516);
            this.m_tpBGQuaHan.TabIndex = 4;
            this.m_tpBGQuaHan.Text = "Bạn đọc quá hạn";
            this.m_tpBGQuaHan.UseVisualStyleBackColor = true;
            // 
            // m_drpQHDenNgay
            // 
            this.m_drpQHDenNgay.Location = new System.Drawing.Point(427, 43);
            this.m_drpQHDenNgay.Name = "m_drpQHDenNgay";
            this.m_drpQHDenNgay.Size = new System.Drawing.Size(174, 22);
            this.m_drpQHDenNgay.TabIndex = 4;
            this.m_drpQHDenNgay.ValueChanged += new System.EventHandler(this.m_drpQHDenNgay_ValueChanged);
            // 
            // m_dtpQHTuNgay
            // 
            this.m_dtpQHTuNgay.Location = new System.Drawing.Point(145, 43);
            this.m_dtpQHTuNgay.Name = "m_dtpQHTuNgay";
            this.m_dtpQHTuNgay.Size = new System.Drawing.Size(174, 22);
            this.m_dtpQHTuNgay.TabIndex = 4;
            this.m_dtpQHTuNgay.ValueChanged += new System.EventHandler(this.m_dtpQHTuNgay_ValueChanged);
            // 
            // m_btnQHExcel
            // 
            this.m_btnQHExcel.Location = new System.Drawing.Point(734, 70);
            this.m_btnQHExcel.Name = "m_btnQHExcel";
            this.m_btnQHExcel.Size = new System.Drawing.Size(133, 49);
            this.m_btnQHExcel.TabIndex = 3;
            this.m_btnQHExcel.Text = "Excel";
            this.m_btnQHExcel.UseVisualStyleBackColor = true;
            this.m_btnQHExcel.Click += new System.EventHandler(this.m_btnQHExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đến ngày:";
            // 
            // m_cbbType
            // 
            this.m_cbbType.FormattingEnabled = true;
            this.m_cbbType.Items.AddRange(new object[] {
            "Tất cả",
            "Theo thời gian"});
            this.m_cbbType.Location = new System.Drawing.Point(145, 102);
            this.m_cbbType.Name = "m_cbbType";
            this.m_cbbType.Size = new System.Drawing.Size(174, 24);
            this.m_cbbType.TabIndex = 2;
            this.m_cbbType.SelectedIndexChanged += new System.EventHandler(this.m_cbbType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê theo:";
            // 
            // m_dgvQuaHan
            // 
            this.m_dgvQuaHan.AllowUserToAddRows = false;
            this.m_dgvQuaHan.AllowUserToDeleteRows = false;
            this.m_dgvQuaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvQuaHan.Location = new System.Drawing.Point(3, 164);
            this.m_dgvQuaHan.Name = "m_dgvQuaHan";
            this.m_dgvQuaHan.ReadOnly = true;
            this.m_dgvQuaHan.RowTemplate.Height = 24;
            this.m_dgvQuaHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvQuaHan.Size = new System.Drawing.Size(938, 356);
            this.m_dgvQuaHan.TabIndex = 0;
            // 
            // m_tbTongHop
            // 
            this.m_tbTongHop.Location = new System.Drawing.Point(4, 25);
            this.m_tbTongHop.Name = "m_tbTongHop";
            this.m_tbTongHop.Size = new System.Drawing.Size(945, 516);
            this.m_tbTongHop.TabIndex = 5;
            this.m_tbTongHop.Text = "Tổng Hợp";
            this.m_tbTongHop.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 542);
            this.Controls.Add(this.m_tcBaocaoThongke);
            this.Name = "frmBaoCao_ThongKe";
            this.Text = "Báo Cáo - Thống Kê";
            this.Load += new System.EventHandler(this.frmBaoCao_ThongKe_Load);
            this.m_tcBaocaoThongke.ResumeLayout(false);
            this.m_tpSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvSach)).EndInit();
            this.m_tpTG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTacGia)).EndInit();
            this.m_tbTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTheLoai)).EndInit();
            this.m_tbNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvNXB)).EndInit();
            this.m_tpBGQuaHan.ResumeLayout(false);
            this.m_tpBGQuaHan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQuaHan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl m_tcBaocaoThongke;
        private System.Windows.Forms.TabPage m_tpSach;
        private System.Windows.Forms.TabPage m_tpTG;
        private System.Windows.Forms.TabPage m_tbTheLoai;
        private System.Windows.Forms.TabPage m_tbNXB;
        private System.Windows.Forms.TabPage m_tpBGQuaHan;
        private System.Windows.Forms.TabPage m_tbTongHop;
        private System.Windows.Forms.Button m_btnSachExcel;
        private System.Windows.Forms.DataGridView m_dgvSach;
        private System.Windows.Forms.Button m_btnTGExcel;
        private System.Windows.Forms.DataGridView m_dgvTacGia;
        private System.Windows.Forms.Button m_btnTheLoaiExecl;
        private System.Windows.Forms.DataGridView m_dgvTheLoai;
        private System.Windows.Forms.Button m_btnNXBExcel;
        private System.Windows.Forms.DataGridView m_dgvNXB;
        private System.Windows.Forms.DateTimePicker m_drpQHDenNgay;
        private System.Windows.Forms.DateTimePicker m_dtpQHTuNgay;
        private System.Windows.Forms.Button m_btnQHExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox m_cbbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView m_dgvQuaHan;
    }
}