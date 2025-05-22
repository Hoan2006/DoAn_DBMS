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

namespace GUI
{
    public partial class fReaderLichSuMuonSach : Form
    {
        public fReaderLichSuMuonSach()
        {
            InitializeComponent();
            LoadLichSuMuonSach();
        }




        public void LoadLichSuMuonSach()
        {
            TaiKhoan taiKhoan = Session.loginAccount;
            int maTaiKhoan = taiKhoan.MaTaiKhoan;
            MessageBox.Show(maTaiKhoan.ToString());

            DataTable data = MuonSachDAO.Instance.LoadLichSuMuonSachByTaiKhoan(maTaiKhoan);
            dgvLichSuMuonSach.DataSource = data;
        }
    }
}
