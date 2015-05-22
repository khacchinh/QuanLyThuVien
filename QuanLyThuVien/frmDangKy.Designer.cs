namespace QuanLyThuVien
{
    partial class frmDangKy
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
            this.m_dgvDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txtMaDK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txtMadocgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtTenDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txtMaTL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txtTenTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.m_btnLuu = new System.Windows.Forms.Button();
            this.m_btnSua = new System.Windows.Forms.Button();
            this.m_btnThem = new System.Windows.Forms.Button();
            this.m_btnXoa = new System.Windows.Forms.Button();
            this.m_dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.m_btnMuonSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvDK)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dgvDK
            // 
            this.m_dgvDK.AllowUserToAddRows = false;
            this.m_dgvDK.AllowUserToDeleteRows = false;
            this.m_dgvDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvDK.Location = new System.Drawing.Point(1, 280);
            this.m_dgvDK.Name = "m_dgvDK";
            this.m_dgvDK.ReadOnly = true;
            this.m_dgvDK.RowTemplate.Height = 24;
            this.m_dgvDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvDK.Size = new System.Drawing.Size(924, 273);
            this.m_dgvDK.TabIndex = 0;
            this.m_dgvDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgvDK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ĐK:";
            // 
            // m_txtMaDK
            // 
            this.m_txtMaDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMaDK.Location = new System.Drawing.Point(146, 9);
            this.m_txtMaDK.Name = "m_txtMaDK";
            this.m_txtMaDK.Size = new System.Drawing.Size(217, 32);
            this.m_txtMaDK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đọc giả:";
            // 
            // m_txtMadocgia
            // 
            this.m_txtMadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMadocgia.Location = new System.Drawing.Point(146, 64);
            this.m_txtMadocgia.Name = "m_txtMadocgia";
            this.m_txtMadocgia.Size = new System.Drawing.Size(217, 32);
            this.m_txtMadocgia.TabIndex = 2;
            this.m_txtMadocgia.TextChanged += new System.EventHandler(this.m_txtMadocgia_TextChanged);
            this.m_txtMadocgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đọc giả:";
            // 
            // m_txtTenDG
            // 
            this.m_txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtTenDG.Location = new System.Drawing.Point(146, 124);
            this.m_txtTenDG.Name = "m_txtTenDG";
            this.m_txtTenDG.ReadOnly = true;
            this.m_txtTenDG.Size = new System.Drawing.Size(217, 32);
            this.m_txtTenDG.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã tài liệu:";
            // 
            // m_txtMaTL
            // 
            this.m_txtMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMaTL.Location = new System.Drawing.Point(646, 7);
            this.m_txtMaTL.Name = "m_txtMaTL";
            this.m_txtMaTL.Size = new System.Drawing.Size(217, 32);
            this.m_txtMaTL.TabIndex = 2;
            this.m_txtMaTL.TextChanged += new System.EventHandler(this.m_txtMaTL_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tài liệu:";
            // 
            // m_txtTenTL
            // 
            this.m_txtTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtTenTL.Location = new System.Drawing.Point(646, 58);
            this.m_txtTenTL.Name = "m_txtTenTL";
            this.m_txtTenTL.ReadOnly = true;
            this.m_txtTenTL.Size = new System.Drawing.Size(217, 32);
            this.m_txtTenTL.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày đăng ký:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ghi chú:";
            // 
            // m_rtbGhiChu
            // 
            this.m_rtbGhiChu.Location = new System.Drawing.Point(646, 165);
            this.m_rtbGhiChu.Name = "m_rtbGhiChu";
            this.m_rtbGhiChu.Size = new System.Drawing.Size(217, 81);
            this.m_rtbGhiChu.TabIndex = 3;
            this.m_rtbGhiChu.Text = "";
            // 
            // m_btnLuu
            // 
            this.m_btnLuu.Enabled = false;
            this.m_btnLuu.Location = new System.Drawing.Point(106, 201);
            this.m_btnLuu.Name = "m_btnLuu";
            this.m_btnLuu.Size = new System.Drawing.Size(92, 42);
            this.m_btnLuu.TabIndex = 4;
            this.m_btnLuu.Text = "Lưu";
            this.m_btnLuu.UseVisualStyleBackColor = true;
            this.m_btnLuu.Click += new System.EventHandler(this.m_btnLuu_Click);
            // 
            // m_btnSua
            // 
            this.m_btnSua.Location = new System.Drawing.Point(213, 201);
            this.m_btnSua.Name = "m_btnSua";
            this.m_btnSua.Size = new System.Drawing.Size(92, 42);
            this.m_btnSua.TabIndex = 4;
            this.m_btnSua.Text = "Sửa";
            this.m_btnSua.UseVisualStyleBackColor = true;
            this.m_btnSua.Click += new System.EventHandler(this.m_btnSua_Click);
            // 
            // m_btnThem
            // 
            this.m_btnThem.Location = new System.Drawing.Point(6, 201);
            this.m_btnThem.Name = "m_btnThem";
            this.m_btnThem.Size = new System.Drawing.Size(92, 42);
            this.m_btnThem.TabIndex = 4;
            this.m_btnThem.Text = "Thêm";
            this.m_btnThem.UseVisualStyleBackColor = true;
            this.m_btnThem.Click += new System.EventHandler(this.m_btnThem_Click);
            // 
            // m_btnXoa
            // 
            this.m_btnXoa.Location = new System.Drawing.Point(330, 201);
            this.m_btnXoa.Name = "m_btnXoa";
            this.m_btnXoa.Size = new System.Drawing.Size(92, 42);
            this.m_btnXoa.TabIndex = 4;
            this.m_btnXoa.Text = "Xóa";
            this.m_btnXoa.UseVisualStyleBackColor = true;
            this.m_btnXoa.Click += new System.EventHandler(this.m_btnXoa_Click);
            // 
            // m_dtpNgayDK
            // 
            this.m_dtpNgayDK.Location = new System.Drawing.Point(646, 119);
            this.m_dtpNgayDK.Name = "m_dtpNgayDK";
            this.m_dtpNgayDK.Size = new System.Drawing.Size(217, 22);
            this.m_dtpNgayDK.TabIndex = 5;
            // 
            // m_btnMuonSach
            // 
            this.m_btnMuonSach.Location = new System.Drawing.Point(448, 201);
            this.m_btnMuonSach.Name = "m_btnMuonSach";
            this.m_btnMuonSach.Size = new System.Drawing.Size(92, 42);
            this.m_btnMuonSach.TabIndex = 4;
            this.m_btnMuonSach.Text = "Mượn sách";
            this.m_btnMuonSach.UseVisualStyleBackColor = true;
            this.m_btnMuonSach.Click += new System.EventHandler(this.m_btnMuonSach_Click);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 556);
            this.Controls.Add(this.m_dtpNgayDK);
            this.Controls.Add(this.m_btnMuonSach);
            this.Controls.Add(this.m_btnXoa);
            this.Controls.Add(this.m_btnSua);
            this.Controls.Add(this.m_btnThem);
            this.Controls.Add(this.m_btnLuu);
            this.Controls.Add(this.m_rtbGhiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_txtTenTL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_txtMaTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_txtTenDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txtMadocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txtMaDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_dgvDK);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgvDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txtMaDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txtMadocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txtTenDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txtMaTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txtTenTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox m_rtbGhiChu;
        private System.Windows.Forms.Button m_btnLuu;
        private System.Windows.Forms.Button m_btnSua;
        private System.Windows.Forms.Button m_btnThem;
        private System.Windows.Forms.Button m_btnXoa;
        private System.Windows.Forms.DateTimePicker m_dtpNgayDK;
        private System.Windows.Forms.Button m_btnMuonSach;
    }
}