namespace GUI
{
    partial class fReaderLichSuMuonSach
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
            this.dgvLichSuMuonSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuMuonSach
            // 
            this.dgvLichSuMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.NgayMuon,
            this.NgayTra,
            this.TenSach,
            this.TenTacGia,
            this.NamXuatBan,
            this.GiaSach,
            this.TinhTrang});
            this.dgvLichSuMuonSach.Location = new System.Drawing.Point(12, 72);
            this.dgvLichSuMuonSach.Name = "dgvLichSuMuonSach";
            this.dgvLichSuMuonSach.RowHeadersWidth = 51;
            this.dgvLichSuMuonSach.RowTemplate.Height = 24;
            this.dgvLichSuMuonSach.Size = new System.Drawing.Size(987, 441);
            this.dgvLichSuMuonSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kiểm tra lịch sử mượn sách";
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
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
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            // 
            // GiaSach
            // 
            this.GiaSach.DataPropertyName = "GiaSach";
            this.GiaSach.HeaderText = "Giá Sách";
            this.GiaSach.MinimumWidth = 6;
            this.GiaSach.Name = "GiaSach";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // fReaderLichSuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichSuMuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReaderLichSuMuonSach";
            this.Text = "fReaderLichSuMuonSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuMuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}