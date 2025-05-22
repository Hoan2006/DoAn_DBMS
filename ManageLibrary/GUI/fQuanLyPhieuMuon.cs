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
using LibraryManagement.DAO;

namespace GUI
{
    public partial class fQuanLyPhieuMuon : Form
    {
        public fQuanLyPhieuMuon()
        {
            InitializeComponent();
            LoadData();
            DataTable data = TaiKhoanDAO.Instance.GetAllMaTaiKhoan();
            cbbLocTheoTaiKhoan.DataSource = data.AsEnumerable().Select(row => row["MaTaiKhoan"]).ToList();
            
            cbbLocTheoTaiKhoan.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì

            AddCombobox_TrangThai();

        }

        private void LoadData()
        {
            dgvPhieuMuonSach.DataSource = PhieuMuonSachDAO.Instance.getAllPhieuMuonSach();
        }

        private void AddCombobox_TrangThai()
        {
            cbbLocTheoTrangThai.Items.Add("Đang mượn");
            cbbLocTheoTrangThai.Items.Add("Đã trả");
        }


        private void dgvPhieuMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhieuMuonSach.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                nudMaPhieuDaChon.Value = Convert.ToInt32(dgvPhieuMuonSach.Rows[rowIndex].Cells["MaPhieuMuon"].Value);
            }
        }

        private void btnUpdateTraSach(object sender, EventArgs e)
        {
            int maPhieuMuon = Convert.ToInt32(nudMaPhieuDaChon.Value);
            if (MuonSachDAO.Instance.UpdateTraSach(maPhieuMuon))
            {
                MessageBox.Show("Trả sách thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Trả sách thất bại");
            }
        }


        private void btnLocTheoMaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (cbbLocTheoTaiKhoan.SelectedIndex != -1)
            {
                int maTaiKhoan = Convert.ToInt32(cbbLocTheoTaiKhoan.SelectedItem);
                dgvPhieuMuonSach.DataSource = PhieuMuonSachDAO.Instance.getPhieuMuonSachByMaTaiKhoan(maTaiKhoan);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã tài khoản để lọc");
            }
        }

        private void btnLocTheoTrangThai_Click(object sender, EventArgs e)
        {
            if (cbbLocTheoTrangThai.SelectedIndex != -1)
            {
                string tinhTrang = cbbLocTheoTrangThai.SelectedItem.ToString();
                dgvPhieuMuonSach.DataSource = PhieuMuonSachDAO.Instance.getPhieuMuonSachByTinhTrang(tinhTrang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái để lọc");
            }
        }


    }
}
