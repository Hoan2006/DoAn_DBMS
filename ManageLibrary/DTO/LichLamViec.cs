using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichLamViec
    {
        public LichLamViec(DateTime ngayLam, string ca, int maTaiKhoan)
        {
            this.NgayLam = ngayLam;
            this.Ca = ca;
            this.MaTaiKhoan = maTaiKhoan;
        }

        public LichLamViec() { }

        private int maLichLamViec;
        private DateTime ngayLam;
        private string ca;
        private int maTaiKhoan;

        public DateTime NgayLam
        {
            get
            {
                return ngayLam;
            }

            set
            {
                ngayLam = value;
            }
        }

        public string Ca
        {
            get
            {
                return ca;
            }

            set
            {
                ca = value;
            }
        }

        public int MaTaiKhoan
        {
            get
            {
                return maTaiKhoan;
            }

            set
            {
                maTaiKhoan = value;
            }
        }

        public int MaLichLamViec
        {
            get
            {
                return maLichLamViec;
            }

            set
            {
                maLichLamViec = value;
            }
        }
    }
}
