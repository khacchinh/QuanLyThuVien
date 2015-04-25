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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dgvQD
            // 
            this.m_dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvQD.Location = new System.Drawing.Point(2, 43);
            this.m_dgvQD.Name = "m_dgvQD";
            this.m_dgvQD.RowTemplate.Height = 24;
            this.m_dgvQD.Size = new System.Drawing.Size(586, 265);
            this.m_dgvQD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qui định lập phiếu phạt khi nhận sách";
            // 
            // frmQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_dgvQD);
            this.MaximizeBox = false;
            this.Name = "frmQuiDinh";
            this.Text = "Qui Định";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgvQD;
        private System.Windows.Forms.Label label1;
    }
}