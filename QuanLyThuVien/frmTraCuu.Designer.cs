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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_btnTLTraCuu = new System.Windows.Forms.Button();
            this.m_cbbTraCuuTL = new System.Windows.Forms.ComboBox();
            this.m_txtTLSeach = new System.Windows.Forms.TextBox();
            this.m_dgvTL = new System.Windows.Forms.DataGridView();
            this.m_tpDocGia = new System.Windows.Forms.TabPage();
            this.m_btnDGTraCuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cbbDG = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_dgvDG = new System.Windows.Forms.DataGridView();
            this.m_txtDGSeach = new System.Windows.Forms.TextBox();
            this.m_btnMin = new System.Windows.Forms.Button();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.m_tpTaiLieu);
            this.tabControl1.Controls.Add(this.m_tpDocGia);
            this.tabControl1.Location = new System.Drawing.Point(1, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // m_tpTaiLieu
            // 
            this.m_tpTaiLieu.Controls.Add(this.button1);
            this.m_tpTaiLieu.Controls.Add(this.label5);
            this.m_tpTaiLieu.Controls.Add(this.label6);
            this.m_tpTaiLieu.Controls.Add(this.m_btnTLTraCuu);
            this.m_tpTaiLieu.Controls.Add(this.m_cbbTraCuuTL);
            this.m_tpTaiLieu.Controls.Add(this.m_txtTLSeach);
            this.m_tpTaiLieu.Controls.Add(this.m_dgvTL);
            this.m_tpTaiLieu.Location = new System.Drawing.Point(4, 28);
            this.m_tpTaiLieu.Name = "m_tpTaiLieu";
            this.m_tpTaiLieu.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpTaiLieu.Size = new System.Drawing.Size(1168, 514);
            this.m_tpTaiLieu.TabIndex = 0;
            this.m_tpTaiLieu.Text = "Tài Liệu";
            this.m_tpTaiLieu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(53, 12, 53, 12);
            this.label5.Size = new System.Drawing.Size(203, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mục tiềm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(47, 12, 40, 12);
            this.label6.Size = new System.Drawing.Size(207, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nội dung tìm kiếm";
            // 
            // m_btnTLTraCuu
            // 
            this.m_btnTLTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnTLTraCuu.FlatAppearance.BorderSize = 0;
            this.m_btnTLTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnTLTraCuu.Image = global::QuanLyThuVien.Properties.Resources.tracuu;
            this.m_btnTLTraCuu.Location = new System.Drawing.Point(668, 52);
            this.m_btnTLTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btnTLTraCuu.Name = "m_btnTLTraCuu";
            this.m_btnTLTraCuu.Size = new System.Drawing.Size(144, 97);
            this.m_btnTLTraCuu.TabIndex = 8;
            this.m_btnTLTraCuu.UseVisualStyleBackColor = false;
            this.m_btnTLTraCuu.Click += new System.EventHandler(this.m_btnTLTraCuu_Click);
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
            this.m_cbbTraCuuTL.Location = new System.Drawing.Point(327, 46);
            this.m_cbbTraCuuTL.Name = "m_cbbTraCuuTL";
            this.m_cbbTraCuuTL.Size = new System.Drawing.Size(261, 37);
            this.m_cbbTraCuuTL.TabIndex = 6;
            // 
            // m_txtTLSeach
            // 
            this.m_txtTLSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtTLSeach.Location = new System.Drawing.Point(327, 102);
            this.m_txtTLSeach.Multiline = true;
            this.m_txtTLSeach.Name = "m_txtTLSeach";
            this.m_txtTLSeach.Size = new System.Drawing.Size(261, 41);
            this.m_txtTLSeach.TabIndex = 1;
            // 
            // m_dgvTL
            // 
            this.m_dgvTL.AllowUserToAddRows = false;
            this.m_dgvTL.AllowUserToDeleteRows = false;
            this.m_dgvTL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTL.Location = new System.Drawing.Point(0, 272);
            this.m_dgvTL.Name = "m_dgvTL";
            this.m_dgvTL.ReadOnly = true;
            this.m_dgvTL.RowTemplate.Height = 24;
            this.m_dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvTL.Size = new System.Drawing.Size(1171, 242);
            this.m_dgvTL.TabIndex = 0;
            // 
            // m_tpDocGia
            // 
            this.m_tpDocGia.Controls.Add(this.m_btnDGTraCuu);
            this.m_tpDocGia.Controls.Add(this.label2);
            this.m_tpDocGia.Controls.Add(this.label4);
            this.m_tpDocGia.Controls.Add(this.m_cbbDG);
            this.m_tpDocGia.Controls.Add(this.pictureBox1);
            this.m_tpDocGia.Controls.Add(this.m_dgvDG);
            this.m_tpDocGia.Controls.Add(this.m_txtDGSeach);
            this.m_tpDocGia.Location = new System.Drawing.Point(4, 28);
            this.m_tpDocGia.Name = "m_tpDocGia";
            this.m_tpDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.m_tpDocGia.Size = new System.Drawing.Size(1168, 514);
            this.m_tpDocGia.TabIndex = 1;
            this.m_tpDocGia.Text = "Đọc Giả";
            this.m_tpDocGia.UseVisualStyleBackColor = true;
            // 
            // m_btnDGTraCuu
            // 
            this.m_btnDGTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnDGTraCuu.FlatAppearance.BorderSize = 0;
            this.m_btnDGTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnDGTraCuu.Image = global::QuanLyThuVien.Properties.Resources.tracuu;
            this.m_btnDGTraCuu.Location = new System.Drawing.Point(749, 67);
            this.m_btnDGTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btnDGTraCuu.Name = "m_btnDGTraCuu";
            this.m_btnDGTraCuu.Size = new System.Drawing.Size(144, 97);
            this.m_btnDGTraCuu.TabIndex = 19;
            this.m_btnDGTraCuu.UseVisualStyleBackColor = false;
            this.m_btnDGTraCuu.Click += new System.EventHandler(this.m_btnDGTraCuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(53, 12, 53, 12);
            this.label2.Size = new System.Drawing.Size(203, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mục tiềm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(47, 12, 40, 12);
            this.label4.Size = new System.Drawing.Size(207, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nội dung tìm kiếm";
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
            this.m_cbbDG.Location = new System.Drawing.Point(445, 67);
            this.m_cbbDG.Name = "m_cbbDG";
            this.m_cbbDG.Size = new System.Drawing.Size(261, 34);
            this.m_cbbDG.TabIndex = 9;
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
            this.m_dgvDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvDG.Location = new System.Drawing.Point(0, 272);
            this.m_dgvDG.Name = "m_dgvDG";
            this.m_dgvDG.ReadOnly = true;
            this.m_dgvDG.RowTemplate.Height = 24;
            this.m_dgvDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvDG.Size = new System.Drawing.Size(1171, 247);
            this.m_dgvDG.TabIndex = 6;
            // 
            // m_txtDGSeach
            // 
            this.m_txtDGSeach.Location = new System.Drawing.Point(445, 123);
            this.m_txtDGSeach.Multiline = true;
            this.m_txtDGSeach.Name = "m_txtDGSeach";
            this.m_txtDGSeach.Size = new System.Drawing.Size(261, 42);
            this.m_txtDGSeach.TabIndex = 5;
            this.m_txtDGSeach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // m_btnMin
            // 
            this.m_btnMin.BackColor = System.Drawing.Color.White;
            this.m_btnMin.FlatAppearance.BorderSize = 0;
            this.m_btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnMin.Image = global::QuanLyThuVien.Properties.Resources.Minimize;
            this.m_btnMin.Location = new System.Drawing.Point(1041, 15);
            this.m_btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.m_btnMin.Name = "m_btnMin";
            this.m_btnMin.Size = new System.Drawing.Size(57, 28);
            this.m_btnMin.TabIndex = 4;
            this.m_btnMin.UseVisualStyleBackColor = false;
            this.m_btnMin.Click += new System.EventHandler(this.m_btnMin_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(59)))));
            this.m_btnClose.FlatAppearance.BorderSize = 0;
            this.m_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnClose.Image = global::QuanLyThuVien.Properties.Resources.close;
            this.m_btnClose.Location = new System.Drawing.Point(1107, 15);
            this.m_btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(57, 28);
            this.m_btnClose.TabIndex = 3;
            this.m_btnClose.UseVisualStyleBackColor = false;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dang ky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.m_btnTLDangKy_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.main_tracuu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 713);
            this.Controls.Add(this.m_btnMin);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox m_txtTLSeach;
        private System.Windows.Forms.DataGridView m_dgvTL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView m_dgvDG;
        private System.Windows.Forms.TextBox m_txtDGSeach;
        private System.Windows.Forms.ComboBox m_cbbTraCuuTL;
        private System.Windows.Forms.ComboBox m_cbbDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button m_btnTLTraCuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_btnMin;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.Button m_btnDGTraCuu;
        private System.Windows.Forms.Button button1;
    }
}