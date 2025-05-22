namespace GUI
{
    partial class fReaderTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReaderTraSach));
            this.btnTimtheotheloai = new System.Windows.Forms.Button();
            this.btnTimtheoNXB = new System.Windows.Forms.Button();
            this.btnTimtheotacgia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.cbbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimtheoten = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMasachdachon = new System.Windows.Forms.NumericUpDown();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasachdachon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimtheotheloai
            // 
            this.btnTimtheotheloai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimtheotheloai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimtheotheloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimtheotheloai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimtheotheloai.Image")));
            this.btnTimtheotheloai.Location = new System.Drawing.Point(937, 126);
            this.btnTimtheotheloai.Name = "btnTimtheotheloai";
            this.btnTimtheotheloai.Size = new System.Drawing.Size(31, 27);
            this.btnTimtheotheloai.TabIndex = 69;
            this.btnTimtheotheloai.UseVisualStyleBackColor = false;
            this.btnTimtheotheloai.Click += new System.EventHandler(this.btn_TimKiemTheoTheLoai_Click);
            // 
            // btnTimtheoNXB
            // 
            this.btnTimtheoNXB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimtheoNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimtheoNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimtheoNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnTimtheoNXB.Image")));
            this.btnTimtheoNXB.Location = new System.Drawing.Point(937, 81);
            this.btnTimtheoNXB.Name = "btnTimtheoNXB";
            this.btnTimtheoNXB.Size = new System.Drawing.Size(31, 27);
            this.btnTimtheoNXB.TabIndex = 68;
            this.btnTimtheoNXB.UseVisualStyleBackColor = false;
            this.btnTimtheoNXB.Click += new System.EventHandler(this.btn_TimKiemTheoNhaXuatBan_Click);
            // 
            // btnTimtheotacgia
            // 
            this.btnTimtheotacgia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimtheotacgia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimtheotacgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimtheotacgia.Image = ((System.Drawing.Image)(resources.GetObject("btnTimtheotacgia.Image")));
            this.btnTimtheotacgia.Location = new System.Drawing.Point(382, 122);
            this.btnTimtheotacgia.Name = "btnTimtheotacgia";
            this.btnTimtheotacgia.Size = new System.Drawing.Size(31, 27);
            this.btnTimtheotacgia.TabIndex = 67;
            this.btnTimtheotacgia.UseVisualStyleBackColor = false;
            this.btnTimtheotacgia.Click += new System.EventHandler(this.btn_TimKiemTheoTacGia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã sách đã chọn";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(637, 126);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(274, 24);
            this.cbbTheLoai.TabIndex = 60;
            // 
            // cbbNhaXuatBan
            // 
            this.cbbNhaXuatBan.FormattingEnabled = true;
            this.cbbNhaXuatBan.Location = new System.Drawing.Point(637, 83);
            this.cbbNhaXuatBan.Name = "cbbNhaXuatBan";
            this.cbbNhaXuatBan.Size = new System.Drawing.Size(274, 24);
            this.cbbNhaXuatBan.TabIndex = 59;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(102, 124);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(274, 24);
            this.cbbTacGia.TabIndex = 58;
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(102, 83);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(274, 22);
            this.txbTenSach.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Tác giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tên sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(538, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Nhà xuất bản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(538, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Thể loại";
            // 
            // btnTimtheoten
            // 
            this.btnTimtheoten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimtheoten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimtheoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimtheoten.Image = ((System.Drawing.Image)(resources.GetObject("btnTimtheoten.Image")));
            this.btnTimtheoten.Location = new System.Drawing.Point(382, 81);
            this.btnTimtheoten.Name = "btnTimtheoten";
            this.btnTimtheoten.Size = new System.Drawing.Size(31, 27);
            this.btnTimtheoten.TabIndex = 70;
            this.btnTimtheoten.UseVisualStyleBackColor = false;
            this.btnTimtheoten.Click += new System.EventHandler(this.btn_Timkiemtheoten_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TacGia,
            this.NhaXuatBan,
            this.TenSach,
            this.LoaiTaiLieu,
            this.GiaSach,
            this.SoLuong});
            this.dgvSach.Location = new System.Drawing.Point(6, 167);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(964, 374);
            this.dgvSach.TabIndex = 71;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TenTacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // LoaiTaiLieu
            // 
            this.LoaiTaiLieu.DataPropertyName = "LoaiTaiLieu";
            this.LoaiTaiLieu.HeaderText = "Loại Tài Liệu";
            this.LoaiTaiLieu.MinimumWidth = 6;
            this.LoaiTaiLieu.Name = "LoaiTaiLieu";
            // 
            // GiaSach
            // 
            this.GiaSach.DataPropertyName = "GiaSach";
            this.GiaSach.HeaderText = "Giá Sách";
            this.GiaSach.MinimumWidth = 6;
            this.GiaSach.Name = "GiaSach";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tra sách và mượn sách";
            // 
            // nudMasachdachon
            // 
            this.nudMasachdachon.Location = new System.Drawing.Point(30, 46);
            this.nudMasachdachon.Name = "nudMasachdachon";
            this.nudMasachdachon.Size = new System.Drawing.Size(209, 22);
            this.nudMasachdachon.TabIndex = 74;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuonSach.Location = new System.Drawing.Point(826, 40);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(144, 33);
            this.btnMuonSach.TabIndex = 75;
            this.btnMuonSach.Text = "Mượn sách";
            this.btnMuonSach.UseVisualStyleBackColor = false;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(288, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Ngày mượn sách";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(291, 46);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(227, 22);
            this.dtpNgayMuon.TabIndex = 77;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(577, 46);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(232, 22);
            this.dtpNgayTra.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(574, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ngày trả sách";
            // 
            // fReaderTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.nudMasachdachon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnTimtheoten);
            this.Controls.Add(this.btnTimtheotheloai);
            this.Controls.Add(this.btnTimtheoNXB);
            this.Controls.Add(this.btnTimtheotacgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.cbbNhaXuatBan);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReaderTraSach";
            this.Text = "fReaderTraSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasachdachon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimtheotheloai;
        private System.Windows.Forms.Button btnTimtheoNXB;
        private System.Windows.Forms.Button btnTimtheotacgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.ComboBox cbbNhaXuatBan;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnTimtheoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.NumericUpDown nudMasachdachon;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label3;
    }
}