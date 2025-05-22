using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using LibraryManagement.DAO;

namespace GUI
{
    public partial class fReaderQuanLyTaiKhoan : Form
    {
        public fReaderQuanLyTaiKhoan()
        {
            InitializeComponent();
            Load_Form();

        }


        public void Load_Form()
        {
            // Load thông tin tài khoản
            TaiKhoan tk = Session.loginAccount;

            string email = tk.Email;
            TaiKhoan taiKhoan = TaiKhoanDAO.Instance.GetTaiKhoanByEmail(email);

            // Đảm bảo ComboBox có các mục
            cbbGioiTinh.Items.Clear(); // Xóa các mục cũ nếu có
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");

            txbHoTen.Enabled = false;
            txbMaTaiKhoan.Enabled = false;
            txbEmail.Enabled = false;
            txbSoDienThoai.Enabled = false;
            txbDiaChi.Enabled = false;
            txbMatKhau.Enabled = false; // Không cho chỉnh sửa mật khẩu
            dtpNgaySinh.Enabled = false; // Không cho chỉnh sửa ngày sinh
            cbbGioiTinh.Enabled = false; // Không cho chỉnh sửa giới tính
            txbVaiTro.Enabled = false; // Không cho chỉnh sửa vai trò


            txbMaTaiKhoan.Text = taiKhoan.MaTaiKhoan.ToString();
            txbEmail.Text = taiKhoan.Email;
            txbMatKhau.Text = taiKhoan.MatKhau;
            txbHoTen.Text = taiKhoan.HoTen;
            txbSoDienThoai.Text = taiKhoan.SoDienThoai;
            // txbVaiTro.Text = taiKhoan.VaiTro;
            if (taiKhoan.VaiTro == "DocGia")
            {
                txbVaiTro.Text = "Độc giả";
            }
            else
            {
                txbVaiTro.Text = "Thủ thư";
            }


            dtpNgaySinh.Value = taiKhoan.NgaySinh;
            txbDiaChi.Text = taiKhoan.DiaChi;
            // cbbGioiTinh.Text = taiKhoan.GioiTinh;
            if (taiKhoan.GioiTinh == "Nam")
            {
                cbbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbbGioiTinh.SelectedIndex = 1;
            }

        }



        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {

            txbHoTen.Enabled = true;
            txbMaTaiKhoan.Enabled = true;
            txbEmail.Enabled = false;
            txbSoDienThoai.Enabled = true;
            txbDiaChi.Enabled = true;
            txbMatKhau.Enabled = false; // Không cho chỉnh sửa mật khẩu
            dtpNgaySinh.Enabled = true; // Không cho chỉnh sửa ngày sinh
            cbbGioiTinh.Enabled = true; // Không cho chỉnh sửa giới tính
            txbVaiTro.Enabled = false; // Không cho chỉnh sửa vai trò
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string matkhau = txbMatKhau.Text;
            string hoten = txbHoTen.Text;
            string sodienthoai = txbSoDienThoai.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;

            string diachi = txbDiaChi.Text;
            string gioitinh = cbbGioiTinh.SelectedItem.ToString();
            int mataikhoan = int.Parse(txbMaTaiKhoan.Text);
            string vaitro = txbVaiTro.Text;

            TaiKhoan taiKhoan = new TaiKhoan(mataikhoan, email, matkhau, vaitro, hoten, sodienthoai, ngaysinh, diachi, gioitinh);

            bool success = TaiKhoanDAO.Instance.UpdateProfile(taiKhoan);
            if (success)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                Load_Form();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fReaderDoiMatKhau f = new fReaderDoiMatKhau();
            f.ShowDialog();

        }
    }
}
