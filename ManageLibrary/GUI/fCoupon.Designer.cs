namespace GUI
{
    partial class fCoupon
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
            this.tcCoupon = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateNgayTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetPM = new System.Windows.Forms.Button();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.numMaPhieuMuon = new System.Windows.Forms.NumericUpDown();
            this.numMaTaiKhoan = new System.Windows.Forms.NumericUpDown();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.rbDaTra = new System.Windows.Forms.RadioButton();
            this.rbDangMuon = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnTimPM = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.IDPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCoupon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCoupon
            // 
            this.tcCoupon.Controls.Add(this.tabPage2);
            this.tcCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCoupon.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tcCoupon.Location = new System.Drawing.Point(0, 0);
            this.tcCoupon.Name = "tcCoupon";
            this.tcCoupon.SelectedIndex = 0;
            this.tcCoupon.Size = new System.Drawing.Size(967, 579);
            this.tcCoupon.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu mượn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.dgvPhieuMuon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 541);
            this.panel5.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel8.Controls.Add(this.dateNgayTra);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnResetPM);
            this.panel8.Controls.Add(this.dateNgayMuon);
            this.panel8.Controls.Add(this.numMaPhieuMuon);
            this.panel8.Controls.Add(this.numMaTaiKhoan);
            this.panel8.Controls.Add(this.btnAccSearch);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.btnTraSach);
            this.panel8.Controls.Add(this.rbTatCa);
            this.panel8.Controls.Add(this.rbDaTra);
            this.panel8.Controls.Add(this.rbDangMuon);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.btnXoaPM);
            this.panel8.Controls.Add(this.btnTimPM);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.btnThemPM);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 133);
            this.panel8.TabIndex = 4;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Enabled = false;
            this.dateNgayTra.Location = new System.Drawing.Point(416, 73);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(103, 27);
            this.dateNgayTra.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày trả";
            // 
            // btnResetPM
            // 
            this.btnResetPM.Location = new System.Drawing.Point(708, 70);
            this.btnResetPM.Name = "btnResetPM";
            this.btnResetPM.Size = new System.Drawing.Size(103, 44);
            this.btnResetPM.TabIndex = 28;
            this.btnResetPM.Text = "Làm mới";
            this.btnResetPM.UseVisualStyleBackColor = true;
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dateNgayMuon.Enabled = false;
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayMuon.Location = new System.Drawing.Point(416, 41);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(200, 27);
            this.dateNgayMuon.TabIndex = 26;
            // 
            // numMaPhieuMuon
            // 
            this.numMaPhieuMuon.Location = new System.Drawing.Point(416, 8);
            this.numMaPhieuMuon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaPhieuMuon.Name = "numMaPhieuMuon";
            this.numMaPhieuMuon.ReadOnly = true;
            this.numMaPhieuMuon.Size = new System.Drawing.Size(120, 27);
            this.numMaPhieuMuon.TabIndex = 25;
            // 
            // numMaTaiKhoan
            // 
            this.numMaTaiKhoan.Location = new System.Drawing.Point(138, 87);
            this.numMaTaiKhoan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaTaiKhoan.Name = "numMaTaiKhoan";
            this.numMaTaiKhoan.ReadOnly = true;
            this.numMaTaiKhoan.Size = new System.Drawing.Size(120, 27);
            this.numMaTaiKhoan.TabIndex = 24;
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.Location = new System.Drawing.Point(5, 10);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(181, 43);
            this.btnAccSearch.TabIndex = 22;
            this.btnAccSearch.Text = "Chọn Tài Khoản";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Phiếu Mượn";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Enabled = false;
            this.btnTraSach.Location = new System.Drawing.Point(845, 16);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(103, 44);
            this.btnTraSach.TabIndex = 19;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Location = new System.Drawing.Point(350, 105);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(78, 23);
            this.rbTatCa.TabIndex = 18;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất Cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            // 
            // rbDaTra
            // 
            this.rbDaTra.AutoSize = true;
            this.rbDaTra.Location = new System.Drawing.Point(589, 104);
            this.rbDaTra.Margin = new System.Windows.Forms.Padding(2);
            this.rbDaTra.Name = "rbDaTra";
            this.rbDaTra.Size = new System.Drawing.Size(79, 23);
            this.rbDaTra.TabIndex = 17;
            this.rbDaTra.TabStop = true;
            this.rbDaTra.Text = "Đã Trả";
            this.rbDaTra.UseVisualStyleBackColor = true;
            // 
            // rbDangMuon
            // 
            this.rbDangMuon.AutoSize = true;
            this.rbDangMuon.Location = new System.Drawing.Point(452, 105);
            this.rbDangMuon.Margin = new System.Windows.Forms.Padding(2);
            this.rbDangMuon.Name = "rbDangMuon";
            this.rbDangMuon.Size = new System.Drawing.Size(118, 23);
            this.rbDangMuon.TabIndex = 16;
            this.rbDangMuon.TabStop = true;
            this.rbDangMuon.Text = "Đang Mượn";
            this.rbDangMuon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã tài khoản";
            // 
            // btnXoaPM
            // 
            this.btnXoaPM.Enabled = false;
            this.btnXoaPM.Location = new System.Drawing.Point(845, 70);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(103, 44);
            this.btnXoaPM.TabIndex = 8;
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            // 
            // btnTimPM
            // 
            this.btnTimPM.Location = new System.Drawing.Point(5, 70);
            this.btnTimPM.Name = "btnTimPM";
            this.btnTimPM.Size = new System.Drawing.Size(103, 44);
            this.btnTimPM.TabIndex = 10;
            this.btnTimPM.Text = "Tra";
            this.btnTimPM.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày mượn";
            // 
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(708, 16);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(103, 44);
            this.btnThemPM.TabIndex = 7;
            this.btnThemPM.Text = "Tạo";
            this.btnThemPM.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhieuMuon,
            this.IDTaiKhoan,
            this.NgayMuon,
            this.NgayTra});
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 132);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(953, 409);
            this.dgvPhieuMuon.TabIndex = 3;
            // 
            // IDPhieuMuon
            // 
            this.IDPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.IDPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.IDPhieuMuon.MinimumWidth = 6;
            this.IDPhieuMuon.Name = "IDPhieuMuon";
            this.IDPhieuMuon.ReadOnly = true;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.IDTaiKhoan.HeaderText = "Mã tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // fCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tcCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCoupon";
            this.Text = "fCoupon";
            this.tcCoupon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCoupon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox dateNgayTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetPM;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.NumericUpDown numMaPhieuMuon;
        private System.Windows.Forms.NumericUpDown numMaTaiKhoan;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.RadioButton rbDaTra;
        private System.Windows.Forms.RadioButton rbDangMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnTimPM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}