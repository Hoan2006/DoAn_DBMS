using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSach
    {
        private int maPhieuMuon;
        private int maTaiKhoan;
        private DateTime ngayMuon;
        private DateTime ngayTra;

        public int MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }
        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateTime NgayTra

        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        public PhieuMuonSach(int maphieumuon, int masach, int mataikhoan, string tinhtrang, DateTime ngaymuon, DateTime ngaytra)
        {
            this.MaPhieuMuon = maphieumuon;
            this.MaTaiKhoan = mataikhoan;
            this.NgayMuon = ngaymuon;
            this.NgayTra = ngaytra;
        }
        public PhieuMuonSach(DataRow row)
        {
            this.MaPhieuMuon = (int)row["MaPhieuMuon"];
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayTra = (DateTime)row["NgayTra"];
        }

        public PhieuMuonSach()
        {
        }
    }
}
