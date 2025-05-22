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

namespace GUI
{
    public partial class fReaderHome : Form
    {
        public fReaderHome()
        {
            InitializeComponent();
        }
        public void LoadForm(object Form)
        {
            if (this.panelChillForm.Controls.Count > 0)
                this.panelChillForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.panelChillForm.Controls.Add(f);
            this.panelChillForm.Tag = f;
            f.Show();
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            LoadForm(new fReaderTraSach());
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            LoadForm(new fReaderQuanLyTaiKhoan());
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LoadForm(new fReaderLichSuMuonSach());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.loginAccount = null; // Đặt lại tài khoản đăng nhập
            fGlobalLogin f = new fGlobalLogin();
            this.Hide();
            f.ShowDialog();

        }
    }
}
