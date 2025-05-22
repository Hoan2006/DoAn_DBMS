using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using LibraryManagement.DAO;

namespace GUI
{
    public partial class fReaderDoiMatKhau : Form
    {
        public fReaderDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = Session.loginAccount;
            string email = tk.Email;
            string matKhauCu = txbMatKhauCu.Text;
            string matKhauMoi = txbMatKhauMoi.Text;
            string matKhauXacNhan = txbXacNhanMatKhauMoi.Text;
            if (matKhauCu == "" || matKhauMoi == "" || matKhauXacNhan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (matKhauMoi != matKhauXacNhan)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return;
            }
            if (TaiKhoanDAO.Instance.ChangeAccountPassword(email, matKhauMoi, matKhauXacNhan, matKhauCu))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }
    }
}
