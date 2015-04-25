namespace QuanLyThuVien
{
    partial class frmTraCuu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_tpTaiLieu = new System.Windows.Forms.TabPage();
            this.m_btnTLDangKy = new System.Windows.Forms.Button();
            this.m_cbbTraCuuTL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txtTLSeach = new System.Windows.Forms.TextBox();
            this.m_dgvTL = new System.Windows.Forms.DataGridView();
            this.m_tpDocGia = new System.Windows.Forms.TabPage();
            this.m_cbbDG = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_dgvDG = new System.Windows.Forms.DataGridView();
            this.m_txtDGSeach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.m_tpTaiLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTL)).BeginInit();
            this.m_tpDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_tpTaiLieu);
            this.tabControl1.Controls.Add(this.m_tpDocGia);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // m_tpTaiLieu
            // 
            this.m_tpTaiLieu.Controls.Add(this.m_btnTLDangKy);
            this.m_tpTaiLieu.Controls.Add(this.m_cbbTraCuuTL);
            this.m_tpTaiLieu.Controls.Add(this.label3);
            this.m_tpTaiLieu.Controls.Add(this.label1);
            this.m_tpTaiLieu.Controls.Add(this.m_txtTLSeach);
            this.m_tpTaiLieu.Controls.Add(this.m_dgvTL);
            this.m_tpTaiLieu.Location = new System.Drawing.Point(4, 25);
            this.m_tpTaiLieu.Name = "m_tpTaiLieu";
            this.m_tpTaiLieu.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpTaiLieu.Size = new System.Drawing.Size(952, 487);
            this.m_tpTaiLieu.TabIndex = 0;
            this.m_tpTaiLieu.Text = "Tài Liệu";
            this.m_tpTaiLieu.UseVisualStyleBackColor = true;
            // 
            // m_btnTLDangKy
            // 
            this.m_btnTLDangKy.Location = new System.Drawing.Point(682, 41);
            this.m_btnTLDangKy.Name = "m_btnTLDangKy";
            this.m_btnTLDangKy.Size = new System.Drawing.Size(144, 51);
            this.m_btnTLDangKy.TabIndex = 7;
            this.m_btnTLDangKy.Text = "Đăng ký";
            this.m_btnTLDangKy.UseVisualStyleBackColor = true;
            this.m_btnTLDangKy.Click += new System.EventHandler(this.m_btnTLDangKy_Click);
            // 
            // m_cbbTraCuuTL
            // 
            this.m_cbbTraCuuTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbTraCuuTL.FormattingEnabled = true;
            this.m_cbbTraCuuTL.Items.AddRange(new object[] {
            "Mã tài liệu",
            "Tên tài liệu",
            "Tác giả",
            "NXB",
            "Thể loại"});
            this.m_cbbTraCuuTL.Location = new System.Drawing.Point(165, 55);
            this.m_cbbTraCuuTL.Name = "m_cbbTraCuuTL";
            this.m_cbbTraCuuTL.Size = new System.Drawing.Size(362, 37);
            this.m_cbbTraCuuTL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seach:";
            // 
            // m_txtTLSeach
            // 
            this.m_txtTLSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtTLSeach.Location = new System.Drawing.Point(362, 130);
            this.m_txtTLSeach.Multiline = true;
            this.m_txtTLSeach.Name = "m_txtTLSeach";
            this.m_txtTLSeach.Size = new System.Drawing.Size(584, 38);
            this.m_txtTLSeach.TabIndex = 1;
            this.m_txtTLSeach.TextChanged += new System.EventHandler(this.m_txtTLSeach_TextChanged);
            // 
            // m_dgvTL
            // 
            this.m_dgvTL.AllowUserToAddRows = false;
            this.m_dgvTL.AllowUserToDeleteRows = false;
            this.m_dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTL.Location = new System.Drawing.Point(0, 211);
            this.m_dgvTL.Name = "m_dgvTL";
            this.m_dgvTL.ReadOnly = true;
            this.m_dgvTL.RowTemplate.Height = 24;
            this.m_dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvTL.Size = new System.Drawing.Size(956, 273);
            this.m_dgvTL.TabIndex = 0;
            // 
            // m_tpDocGia
            // 
            this.m_tpDocGia.Controls.Add(this.m_cbbDG);
            this.m_tpDocGia.Controls.Add(this.label4);
            this.m_tpDocGia.Controls.Add(this.pictureBox1);
            this.m_tpDocGia.Controls.Add(this.m_dgvDG);
            this.m_tpDocGia.Controls.Add(this.m_txtDGSeach);
            this.m_tpDocGia.Controls.Add(this.label2);
            this.m_tpDocGia.Location = new System.Drawing.Point(4, 25);
            this.m_tpDocGia.Name = "m_tpDocGia";
            this.m_tpDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpDocGia.Size = new System.Drawing.Size(952, 487);
            this.m_tpDocGia.TabIndex = 1;
            this.m_tpDocGia.Text = "Đọc Giả";
            this.m_tpDocGia.UseVisualStyleBackColor = true;
            // 
            // m_cbbDG
            // 
            this.m_cbbDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbDG.FormattingEnabled = true;
            this.m_cbbDG.Items.AddRange(new object[] {
            "MSSV",
            "Mã giảng viên",
            "Họ tên",
            "Lớp",
            "Khoa"});
            this.m_cbbDG.Location = new System.Drawing.Point(327, 85);
            this.m_cbbDG.Name = "m_cbbDG";
            this.m_cbbDG.Size = new System.Drawing.Size(415, 34);
            this.m_cbbDG.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tìm theo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 166);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // m_dgvDG
            // 
            this.m_dgvDG.AllowUserToAddRows = false;
            this.m_dgvDG.AllowUserToDeleteRows = false;
            this.m_dgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvDG.Location = new System.Drawing.Point(0, 233);
            this.m_dgvDG.Name = "m_dgvDG";
            this.m_dgvDG.ReadOnly = true;
            this.m_dgvDG.RowTemplate.Height = 24;
            this.m_dgvDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvDG.Size = new System.Drawing.Size(956, 258);
            this.m_dgvDG.TabIndex = 6;
            // 
            // m_txtDGSeach
            // 
            this.m_txtDGSeach.Location = new System.Drawing.Point(468, 159);
            this.m_txtDGSeach.Multiline = true;
            this.m_txtDGSeach.Name = "m_txtDGSeach";
            this.m_txtDGSeach.Size = new System.Drawing.Size(469, 37);
            this.m_txtDGSeach.TabIndex = 5;
            this.m_txtDGSeach.TextChanged += new System.EventHandler(this.m_txtDGSeach_TextChanged);
            this.m_txtDGSeach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seach";
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTraCuu";
            this.Text = "Tra Cứu";
            this.tabControl1.ResumeLayout(false);
            this.m_tpTaiLieu.ResumeLayout(false);
            this.m_tpTaiLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTL)).EndInit();
            this.m_tpDocGia.ResumeLayout(false);
            this.m_tpDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_tpTaiLieu;
        private System.Windows.Forms.TabPage m_tpDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txtTLSeach;
        private System.Windows.Forms.DataGridView m_dgvTL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView m_dgvDG;
        private System.Windows.Forms.TextBox m_txtDGSeach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_cbbTraCuuTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbbDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_btnTLDangKy;
    }
}