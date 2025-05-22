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
    public partial class fGlobalLogin : Form
    {
        public fGlobalLogin()
        {
            InitializeComponent();
        }

         private void lbChuyenformregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            fGlobalRegister f = new fGlobalRegister();
            f.ShowDialog();
            this.Close();
        }

        private void lbChuyenformregister_MouseEnter(object sender, EventArgs e)
        {
            lbChuyenformregister.Cursor = Cursors.Hand;
        }
        private void lbChuyenformregister_MouseLeave(object sender, EventArgs e)
        {
            lbChuyenformregister.Cursor = Cursors.Default;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string password = txbMatKhau.Text;
            bool success = TaiKhoanDAO.Instance.CheckLogin(email, password);
            if (success)
            {
                TaiKhoan taiKhoan = TaiKhoanDAO.Instance.GetTaiKhoanByEmail(email);
                Session.loginAccount = taiKhoan;
                if (taiKhoan.VaiTro == "DocGia")
                {
                    this.Hide();
                    fReaderHome f = new fReaderHome();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    fHome f = new fHome();
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

    }
}
