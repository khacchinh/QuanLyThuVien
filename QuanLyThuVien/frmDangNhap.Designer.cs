namespace QuanLyThuVien
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtID = new System.Windows.Forms.TextBox();
            this.m_txtPass = new System.Windows.Forms.TextBox();
            this.m_btnMain = new System.Windows.Forms.Button();
            this.m_btnMin = new System.Windows.Forms.Button();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(312, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // m_txtID
            // 
            this.m_txtID.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtID.Location = new System.Drawing.Point(404, 117);
            this.m_txtID.Margin = new System.Windows.Forms.Padding(2);
            this.m_txtID.Multiline = true;
            this.m_txtID.Name = "m_txtID";
            this.m_txtID.Size = new System.Drawing.Size(162, 19);
            this.m_txtID.TabIndex = 3;
            // 
            // m_txtPass
            // 
            this.m_txtPass.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtPass.Location = new System.Drawing.Point(404, 158);
            this.m_txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.m_txtPass.Multiline = true;
            this.m_txtPass.Name = "m_txtPass";
            this.m_txtPass.Size = new System.Drawing.Size(162, 19);
            this.m_txtPass.TabIndex = 3;
            // 
            // m_btnMain
            // 
            this.m_btnMain.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnMain.Location = new System.Drawing.Point(337, 223);
            this.m_btnMain.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnMain.Name = "m_btnMain";
            this.m_btnMain.Size = new System.Drawing.Size(73, 30);
            this.m_btnMain.TabIndex = 4;
            this.m_btnMain.Text = "Form Main";
            this.m_btnMain.UseVisualStyleBackColor = true;
            this.m_btnMain.Click += new System.EventHandler(this.m_btnMain_Click);
            // 
            // m_btnMin
            // 
            this.m_btnMin.BackColor = System.Drawing.Color.White;
            this.m_btnMin.FlatAppearance.BorderSize = 0;
            this.m_btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnMin.Image = global::QuanLyThuVien.Properties.Resources.Minimize;
            this.m_btnMin.Location = new System.Drawing.Point(518, 12);
            this.m_btnMin.Name = "m_btnMin";
            this.m_btnMin.Size = new System.Drawing.Size(43, 23);
            this.m_btnMin.TabIndex = 7;
            this.m_btnMin.UseVisualStyleBackColor = false;
            this.m_btnMin.Click += new System.EventHandler(this.m_btnMin_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(59)))));
            this.m_btnClose.FlatAppearance.BorderSize = 0;
            this.m_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnClose.Image = global::QuanLyThuVien.Properties.Resources.close;
            this.m_btnClose.Location = new System.Drawing.Point(567, 12);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(43, 23);
            this.m_btnClose.TabIndex = 6;
            this.m_btnClose.UseVisualStyleBackColor = false;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.login_img;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // m_btnLogin
            // 
            this.m_btnLogin.BackgroundImage = global::QuanLyThuVien.Properties.Resources.login_btn;
            this.m_btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_btnLogin.FlatAppearance.BorderSize = 0;
            this.m_btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnLogin.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnLogin.Location = new System.Drawing.Point(475, 181);
            this.m_btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.m_btnLogin.Name = "m_btnLogin";
            this.m_btnLogin.Size = new System.Drawing.Size(91, 31);
            this.m_btnLogin.TabIndex = 4;
            this.m_btnLogin.UseVisualStyleBackColor = true;
            this.m_btnLogin.Click += new System.EventHandler(this.m_btnLogin_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(622, 305);
            this.Controls.Add(this.m_btnMin);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_btnMain);
            this.Controls.Add(this.m_btnLogin);
            this.Controls.Add(this.m_txtPass);
            this.Controls.Add(this.m_txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txtID;
        private System.Windows.Forms.TextBox m_txtPass;
        private System.Windows.Forms.Button m_btnLogin;
        private System.Windows.Forms.Button m_btnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button m_btnMin;
        private System.Windows.Forms.Button m_btnClose;
    }
}

