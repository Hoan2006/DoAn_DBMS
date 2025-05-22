namespace GUI
{
    partial class fReaderDoiMatKhau
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
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(240, 294);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(329, 40);
            this.btnDoiMatKhau.TabIndex = 37;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(170, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mật khẩu cũ";
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(294, 90);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(329, 22);
            this.txbMatKhauCu.TabIndex = 35;
            this.txbMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(288, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 32);
            this.label8.TabIndex = 38;
            this.label8.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(160, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mật khẩu mới";
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(294, 146);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(329, 22);
            this.txbMatKhauMoi.TabIndex = 39;
            this.txbMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(70, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Xác nhận mật khẩu mới";
            // 
            // txbXacNhanMatKhauMoi
            // 
            this.txbXacNhanMatKhauMoi.Location = new System.Drawing.Point(294, 205);
            this.txbXacNhanMatKhauMoi.Name = "txbXacNhanMatKhauMoi";
            this.txbXacNhanMatKhauMoi.Size = new System.Drawing.Size(329, 22);
            this.txbXacNhanMatKhauMoi.TabIndex = 41;
            this.txbXacNhanMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // fReaderDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbXacNhanMatKhauMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbMatKhauCu);
            this.Name = "fReaderDoiMatKhau";
            this.Text = "fReaderDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbXacNhanMatKhauMoi;
    }
}