namespace GUI
{
    partial class fGlobalLogin
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
            this.lbChuyenformregister = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbChuyenformregister
            // 
            this.lbChuyenformregister.AutoSize = true;
            this.lbChuyenformregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChuyenformregister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbChuyenformregister.Location = new System.Drawing.Point(109, 226);
            this.lbChuyenformregister.Name = "lbChuyenformregister";
            this.lbChuyenformregister.Size = new System.Drawing.Size(280, 20);
            this.lbChuyenformregister.TabIndex = 30;
            this.lbChuyenformregister.Text = "Chưa có tài khoản ? Vui lòng đăng kí";
            this.lbChuyenformregister.Click += new System.EventHandler(this.lbChuyenformregister_Click);
            this.lbChuyenformregister.MouseEnter += new System.EventHandler(this.lbChuyenformregister_MouseEnter);
            this.lbChuyenformregister.MouseLeave += new System.EventHandler(this.lbChuyenformregister_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(124, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "Đăng nhập tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Lime;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Red;
            this.btnDangNhap.Location = new System.Drawing.Point(143, 173);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(211, 40);
            this.btnDangNhap.TabIndex = 28;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(109, 124);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(329, 22);
            this.txbMatKhau.TabIndex = 23;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(109, 70);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(329, 22);
            this.txbEmail.TabIndex = 22;
            // 
            // fGlobalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 276);
            this.Controls.Add(this.lbChuyenformregister);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbEmail);
            this.Name = "fGlobalLogin";
            this.Text = "fGlobalLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChuyenformregister;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbEmail;
    }
}