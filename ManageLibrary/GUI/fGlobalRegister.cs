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
    public partial class fGlobalRegister : Form
    {
        public fGlobalRegister()
        {
            InitializeComponent();
            cbbGioiTinh_Load();
            cbbVaiTro_Load();

        }

        public void lbChuyenformlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fGlobalLogin f = new fGlobalLogin();
            f.ShowDialog();
            this.Close();
        }

        public void lbChuyenformlogin_MouseEnter(object sender, EventArgs e)
        {
            lbChuyenformlogin.Cursor = Cursors.Hand;
        }
        public void lbChuyenformlogin_MouseLeave(object sender, EventArgs e)
        {
            lbChuyenformlogin.Cursor = Cursors.Default;
        }


        public void cbbGioiTinh_Load()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedIndex = 0;
        }


        public void cbbVaiTro_Load()
        {
            // Tạo một danh sách chứa các đối tượng với Text và Value
            List<dynamic> roles = new List<dynamic>
            {
                new { Text = "Độc giả", Value = "DocGia" },
                new { Text = "Thủ thư", Value = "ThuThu" },
                new { Text = "Quản trị viên", Value = "QuanTriVien" },
            };

            // Gán danh sách vào ComboBox
            cbbVaiTro.DataSource = roles;

            // Đặt DisplayMember và ValueMember để hiển thị Text và lưu giá trị Value
            cbbVaiTro.DisplayMember = "Text";  // Hiển thị 'Text'
            cbbVaiTro.ValueMember = "Value";  // Lưu 'Value'

            // Chọn mặc định "Độc giả"
            cbbVaiTro.SelectedIndex = 0;
        }


        public void btnDangKi_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string matkhau = txbMatKhau.Text;

            string hoten = txbHoTen.Text;
            string sodienthoai = txbSoDienThoai.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txbDiaChi.Text;
            string gioitinh = cbbGioiTinh.SelectedItem.ToString();

            int mataikhoan = int.Parse(txbMaTaiKhoan.Text);
            string vaitro = cbbVaiTro.SelectedValue.ToString();


            // Kiểm tra các trường thông tin
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(hoten) ||
                string.IsNullOrEmpty(sodienthoai) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (email.Length < 5 || email.Length > 50)
            {
                MessageBox.Show("Email phải có độ dài từ 5 đến 50 ký tự.");
                return;
            }
            if (matkhau.Length < 6 || matkhau.Length > 20)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 đến 20 ký tự.");
                return;
            }


            // Kiểm tra định dạng email
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            //Register
            bool success = TaiKhoanDAO.Instance.Register(new TaiKhoan(mataikhoan, email, matkhau, vaitro, hoten, sodienthoai, ngaysinh, diachi, gioitinh));
            if (success)
            {
                MessageBox.Show("Đăng ký thành công!");
                
                this.Hide();
                

                if(vaitro == "DocGia")
                {
                    fReaderHome f = new fReaderHome();
                    f.ShowDialog();
                }
                else
                {
                    fHome f = new fHome();
                    f.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.");
            }

        }
    }
    }
