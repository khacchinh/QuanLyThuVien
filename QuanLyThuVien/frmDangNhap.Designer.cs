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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtID = new System.Windows.Forms.TextBox();
            this.m_txtPass = new System.Windows.Forms.TextBox();
            this.m_btnLogin = new System.Windows.Forms.Button();
            this.m_btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // m_txtID
            // 
            this.m_txtID.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtID.Location = new System.Drawing.Point(195, 188);
            this.m_txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtID.Multiline = true;
            this.m_txtID.Name = "m_txtID";
            this.m_txtID.Size = new System.Drawing.Size(191, 22);
            this.m_txtID.TabIndex = 3;
            // 
            // m_txtPass
            // 
            this.m_txtPass.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtPass.Location = new System.Drawing.Point(195, 217);
            this.m_txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_txtPass.Multiline = true;
            this.m_txtPass.Name = "m_txtPass";
            this.m_txtPass.Size = new System.Drawing.Size(191, 22);
            this.m_txtPass.TabIndex = 3;
            // 
            // m_btnLogin
            // 
            this.m_btnLogin.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnLogin.Location = new System.Drawing.Point(288, 254);
            this.m_btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btnLogin.Name = "m_btnLogin";
            this.m_btnLogin.Size = new System.Drawing.Size(97, 37);
            this.m_btnLogin.TabIndex = 4;
            this.m_btnLogin.Text = "Login";
            this.m_btnLogin.UseVisualStyleBackColor = true;
            this.m_btnLogin.Click += new System.EventHandler(this.m_btnLogin_Click);
            // 
            // m_btnMain
            // 
            this.m_btnMain.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnMain.Location = new System.Drawing.Point(56, 295);
            this.m_btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btnMain.Name = "m_btnMain";
            this.m_btnMain.Size = new System.Drawing.Size(97, 37);
            this.m_btnMain.TabIndex = 4;
            this.m_btnMain.Text = "Form Main";
            this.m_btnMain.UseVisualStyleBackColor = true;
            this.m_btnMain.Click += new System.EventHandler(this.m_btnMain_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.m_btnMain);
            this.Controls.Add(this.m_btnLogin);
            this.Controls.Add(this.m_txtPass);
            this.Controls.Add(this.m_txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
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
    }
}

