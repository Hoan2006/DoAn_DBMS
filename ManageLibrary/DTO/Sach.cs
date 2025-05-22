using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public Sach(int maSach, int maTacGia, int maTheLoai, int maNhaXuatBan,
            string tenSach, string loaiTaiLieu, int namXuatBan, decimal giaSach, int soLuong)
        {
            this.MaSach = maSach;
            this.MaTacGia = maTacGia;
            this.MaTheLoai = maTheLoai;
            this.MaNhaXuatBan = maNhaXuatBan;
            this.TenSach = tenSach;
            this.LoaiTaiLieu = loaiTaiLieu;
            this.NamXuatBan = namXuatBan;
            this.GiaSach = giaSach;
            this.SoLuong = soLuong;
        }
        public Sach() { }

        private int maSach;
        private int maTacGia;
        private int maTheLoai;
        private int maNhaXuatBan;
        private string tenSach;
        private string loaiTaiLieu;
        private int namXuatBan;
        private decimal giaSach;
        private int soLuong;
        private string tenTacGia;
        private string tenNhaXuatBan;
        private string tenTheLoai;

        public Sach(DataRow row)
        {
            this.maSach = (int)row["MaSach"];
            this.maTacGia = (int)row["MaTacGia"];
            this.maTheLoai = (int)row["MaTheLoai"];
            this.maNhaXuatBan = (int)row["MaNhaXuatBan"];
            this.tenSach = row["TenSach"].ToString();
            this.loaiTaiLieu = row["LoaiTaiLieu"].ToString();
            this.namXuatBan = (int)row["NamXuatBan"];
            this.giaSach = (decimal)row["GiaSach"];
            this.soLuong = (int)row["SoLuong"];
        }

        public int MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public int MaTacGia
        {
            get
            {
                return maTacGia;
            }

            set
            {
                maTacGia = value;
            }
        }

        public int MaTheLoai
        {
            get
            {
                return maTheLoai;
            }

            set
            {
                maTheLoai = value;
            }
        }

        public int MaNhaXuatBan
        {
            get
            {
                return maNhaXuatBan;
            }

            set
            {
                maNhaXuatBan = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public string LoaiTaiLieu
        {
            get
            {
                return loaiTaiLieu;
            }

            set
            {
                loaiTaiLieu = value;
            }
        }

        public int NamXuatBan
        {
            get
            {
                return namXuatBan;
            }

            set
            {
                namXuatBan = value;
            }
        }

        public decimal GiaSach
        {
            get
            {
                return giaSach;
            }

            set
            {
                giaSach = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string TenTheLoai
        {
            get
            {
                return tenTheLoai;
            }

            set
            {
                tenTheLoai = value;
            }
        }

        public string TenNhaXuatBan
        {
            get
            {
                return tenNhaXuatBan;
            }

            set
            {
                tenNhaXuatBan = value;
            }
        }

        public string TenTacGia
        {
            get
            {
                return tenTacGia;
            }

            set
            {
                tenTacGia = value;
            }
        }
    }
}
