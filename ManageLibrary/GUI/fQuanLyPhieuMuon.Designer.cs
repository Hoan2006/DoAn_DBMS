namespace GUI
{
    partial class fQuanLyPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyPhieuMuon));
            this.dgvPhieuMuonSach = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbLocTheoTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimtheoten = new System.Windows.Forms.Button();
            this.nudMaPhieuDaChon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLocTheoTaiKhoan = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaPhieuDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuMuonSach
            // 
            this.dgvPhieuMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaTaiKhoan,
            this.NgayMuon,
            this.NgayTra,
            this.TinhTrang,
            this.TenSach,
            this.TenTheLoai,
            this.TenTacGia});
            this.dgvPhieuMuonSach.Location = new System.Drawing.Point(15, 153);
            this.dgvPhieuMuonSach.Name = "dgvPhieuMuonSach";
            this.dgvPhieuMuonSach.RowHeadersWidth = 51;
            this.dgvPhieuMuonSach.RowTemplate.Height = 24;
            this.dgvPhieuMuonSach.Size = new System.Drawing.Size(957, 447);
            this.dgvPhieuMuonSach.TabIndex = 0;
            this.dgvPhieuMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuonSach_CellClick);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            this.MaTaiKhoan.MinimumWidth = 6;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            // 
            // cbbLocTheoTrangThai
            // 
            this.cbbLocTheoTrangThai.FormattingEnabled = true;
            this.cbbLocTheoTrangThai.Location = new System.Drawing.Point(144, 111);
            this.cbbLocTheoTrangThai.Name = "cbbLocTheoTrangThai";
            this.cbbLocTheoTrangThai.Size = new System.Drawing.Size(133, 24);
            this.cbbLocTheoTrangThai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc theo trạng thái";
            // 
            // btnTimtheoten
            // 
            this.btnTimtheoten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimtheoten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimtheoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimtheoten.Image = ((System.Drawing.Image)(resources.GetObject("btnTimtheoten.Image")));
            this.btnTimtheoten.Location = new System.Drawing.Point(283, 109);
            this.btnTimtheoten.Name = "btnTimtheoten";
            this.btnTimtheoten.Size = new System.Drawing.Size(31, 27);
            this.btnTimtheoten.TabIndex = 71;
            this.btnTimtheoten.UseVisualStyleBackColor = false;
            this.btnTimtheoten.Click += new System.EventHandler(this.btnLocTheoTrangThai_Click);
            // 
            // nudMaPhieuDaChon
            // 
            this.nudMaPhieuDaChon.Location = new System.Drawing.Point(230, 40);
            this.nudMaPhieuDaChon.Name = "nudMaPhieuDaChon";
            this.nudMaPhieuDaChon.Size = new System.Drawing.Size(84, 22);
            this.nudMaPhieuDaChon.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Mã phiếu mượn chọn để sửa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(283, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 27);
            this.button1.TabIndex = 79;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLocTheoMaTaiKhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Lọc theo tài khoản";
            // 
            // cbbLocTheoTaiKhoan
            // 
            this.cbbLocTheoTaiKhoan.FormattingEnabled = true;
            this.cbbLocTheoTaiKhoan.Location = new System.Drawing.Point(144, 78);
            this.cbbLocTheoTaiKhoan.Name = "cbbLocTheoTaiKhoan";
            this.cbbLocTheoTaiKhoan.Size = new System.Drawing.Size(133, 24);
            this.cbbLocTheoTaiKhoan.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(666, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 48);
            this.button2.TabIndex = 80;
            this.button2.Text = "Sửa trạng thái (đã trả sách)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnUpdateTraSach);
            // 
            // fQuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbLocTheoTaiKhoan);
            this.Controls.Add(this.nudMaPhieuDaChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimtheoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLocTheoTrangThai);
            this.Controls.Add(this.dgvPhieuMuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuanLyPhieuMuon";
            this.Text = "fQuanLyPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaPhieuDaChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuMuonSach;
        private System.Windows.Forms.ComboBox cbbLocTheoTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimtheoten;
        private System.Windows.Forms.NumericUpDown nudMaPhieuDaChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLocTheoTaiKhoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
    }
}