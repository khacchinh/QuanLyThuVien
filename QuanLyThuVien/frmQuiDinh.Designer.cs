namespace QuanLyThuVien
{
    partial class frmQuiDinh
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
            this.m_dgvQD = new System.Windows.Forms.DataGridView();
            this.m_btnPMXoa = new System.Windows.Forms.Button();
            this.m_btnPMSua = new System.Windows.Forms.Button();
            this.m_btnPMLuu = new System.Windows.Forms.Button();
            this.m_btnPMThem = new System.Windows.Forms.Button();
            this.m_btnMin = new System.Windows.Forms.Button();
            this.m_btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dgvQD
            // 
            this.m_dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvQD.Location = new System.Drawing.Point(5, 200);
            this.m_dgvQD.Margin = new System.Windows.Forms.Padding(2);
            this.m_dgvQD.Name = "m_dgvQD";
            this.m_dgvQD.RowTemplate.Height = 24;
            this.m_dgvQD.Size = new System.Drawing.Size(698, 224);
            this.m_dgvQD.TabIndex = 0;
            // 
            // m_btnPMXoa
            // 
            this.m_btnPMXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnPMXoa.FlatAppearance.BorderSize = 0;
            this.m_btnPMXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPMXoa.ForeColor = System.Drawing.Color.White;
            this.m_btnPMXoa.Location = new System.Drawing.Point(527, 108);
            this.m_btnPMXoa.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnPMXoa.Name = "m_btnPMXoa";
            this.m_btnPMXoa.Size = new System.Drawing.Size(112, 42);
            this.m_btnPMXoa.TabIndex = 13;
            this.m_btnPMXoa.Text = "Xóa";
            this.m_btnPMXoa.UseVisualStyleBackColor = false;
            // 
            // m_btnPMSua
            // 
            this.m_btnPMSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnPMSua.FlatAppearance.BorderSize = 0;
            this.m_btnPMSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPMSua.ForeColor = System.Drawing.Color.White;
            this.m_btnPMSua.Location = new System.Drawing.Point(380, 108);
            this.m_btnPMSua.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnPMSua.Name = "m_btnPMSua";
            this.m_btnPMSua.Size = new System.Drawing.Size(112, 42);
            this.m_btnPMSua.TabIndex = 12;
            this.m_btnPMSua.Text = "Sửa";
            this.m_btnPMSua.UseVisualStyleBackColor = false;
            // 
            // m_btnPMLuu
            // 
            this.m_btnPMLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnPMLuu.Enabled = false;
            this.m_btnPMLuu.FlatAppearance.BorderSize = 0;
            this.m_btnPMLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPMLuu.ForeColor = System.Drawing.Color.White;
            this.m_btnPMLuu.Location = new System.Drawing.Point(232, 108);
            this.m_btnPMLuu.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnPMLuu.Name = "m_btnPMLuu";
            this.m_btnPMLuu.Size = new System.Drawing.Size(111, 42);
            this.m_btnPMLuu.TabIndex = 11;
            this.m_btnPMLuu.Text = "Lưu";
            this.m_btnPMLuu.UseVisualStyleBackColor = false;
            // 
            // m_btnPMThem
            // 
            this.m_btnPMThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.m_btnPMThem.FlatAppearance.BorderSize = 0;
            this.m_btnPMThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPMThem.ForeColor = System.Drawing.Color.White;
            this.m_btnPMThem.Location = new System.Drawing.Point(75, 108);
            this.m_btnPMThem.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnPMThem.Name = "m_btnPMThem";
            this.m_btnPMThem.Size = new System.Drawing.Size(110, 42);
            this.m_btnPMThem.TabIndex = 10;
            this.m_btnPMThem.Text = "Thêm";
            this.m_btnPMThem.UseVisualStyleBackColor = false;
            // 
            // m_btnMin
            // 
            this.m_btnMin.BackColor = System.Drawing.Color.White;
            this.m_btnMin.FlatAppearance.BorderSize = 0;
            this.m_btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnMin.Image = global::QuanLyThuVien.Properties.Resources.Minimize;
            this.m_btnMin.Location = new System.Drawing.Point(600, 12);
            this.m_btnMin.Name = "m_btnMin";
            this.m_btnMin.Size = new System.Drawing.Size(43, 23);
            this.m_btnMin.TabIndex = 15;
            this.m_btnMin.UseVisualStyleBackColor = false;
            this.m_btnMin.Click += new System.EventHandler(this.m_btnMin_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(59)))));
            this.m_btnClose.FlatAppearance.BorderSize = 0;
            this.m_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnClose.Image = global::QuanLyThuVien.Properties.Resources.close;
            this.m_btnClose.Location = new System.Drawing.Point(649, 12);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(43, 23);
            this.m_btnClose.TabIndex = 14;
            this.m_btnClose.UseVisualStyleBackColor = false;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // frmQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.main_quydinh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 469);
            this.Controls.Add(this.m_btnMin);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_btnPMXoa);
            this.Controls.Add(this.m_btnPMSua);
            this.Controls.Add(this.m_btnPMLuu);
            this.Controls.Add(this.m_btnPMThem);
            this.Controls.Add(this.m_dgvQD);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmQuiDinh";
            this.Text = "Qui Định";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgvQD;
        private System.Windows.Forms.Button m_btnPMXoa;
        private System.Windows.Forms.Button m_btnPMSua;
        private System.Windows.Forms.Button m_btnPMLuu;
        private System.Windows.Forms.Button m_btnPMThem;
        private System.Windows.Forms.Button m_btnMin;
        private System.Windows.Forms.Button m_btnClose;
    }
}