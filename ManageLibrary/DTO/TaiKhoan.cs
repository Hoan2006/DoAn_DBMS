using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int maTaiKhoan, string email, string matKhau, string vaiTro, string hoTen, string soDienThoai, DateTime ngaySinh, string diaChi, string gioiTinh)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.Email = email;
            this.MatKhau = matKhau;
            this.VaiTro = vaiTro;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
        }

        public TaiKhoan(DataRow row)
        {
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.Email = row["Email"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.VaiTro = row["VaiTro"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.DiaChi = row["DiaChi"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        public TaiKhoan()
        {
        }

        private int maTaiKhoan;
        private string email;
        private string matKhau;
        private string vaiTro;
        private string hoTen;
        private string soDienThoai;
        private DateTime ngaySinh;
        private string diaChi;
        private string gioiTinh;

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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string VaiTro
        {
            get
            {
                return vaiTro;
            }

            set
            {
                vaiTro = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
    }
}
