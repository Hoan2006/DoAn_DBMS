namespace GUI
{
    partial class fReaderHome
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
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnLichSuMuonSach = new System.Windows.Forms.Button();
            this.btnThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelChillForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(12, 73);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(150, 59);
            this.btnTraSach.TabIndex = 0;
            this.btnTraSach.Text = "Tra cứu sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnLichSuMuonSach
            // 
            this.btnLichSuMuonSach.Location = new System.Drawing.Point(12, 183);
            this.btnLichSuMuonSach.Name = "btnLichSuMuonSach";
            this.btnLichSuMuonSach.Size = new System.Drawing.Size(150, 59);
            this.btnLichSuMuonSach.TabIndex = 1;
            this.btnLichSuMuonSach.Text = "Lịch sử mượn sách";
            this.btnLichSuMuonSach.UseVisualStyleBackColor = true;
            this.btnLichSuMuonSach.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Location = new System.Drawing.Point(12, 296);
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.Size = new System.Drawing.Size(150, 59);
            this.btnThongTinTaiKhoan.TabIndex = 2;
            this.btnThongTinTaiKhoan.Text = "Thông tìn tài khoản";
            this.btnThongTinTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThongTinTaiKhoan.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 408);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 59);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelChillForm
            // 
            this.panelChillForm.Location = new System.Drawing.Point(216, 38);
            this.panelChillForm.Name = "panelChillForm";
            this.panelChillForm.Size = new System.Drawing.Size(1054, 580);
            this.panelChillForm.TabIndex = 4;
            // 
            // fReaderHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 656);
            this.Controls.Add(this.panelChillForm);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnThongTinTaiKhoan);
            this.Controls.Add(this.btnLichSuMuonSach);
            this.Controls.Add(this.btnTraSach);
            this.Name = "fReaderHome";
            this.Text = "fReaderHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnLichSuMuonSach;
        private System.Windows.Forms.Button btnThongTinTaiKhoan;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelChillForm;
    }
}