using DAO;
using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();

            LoadSachChart();

            LoadTaiKhoanChart();
        }

        private void LoadSachChart()
        {
            dgvTacGia.DataSource = TacGiaDAO.Instance.TotalAuthors();
            dgvtheLoai.DataSource = TheLoaiDAO.Instance.TotalCategories();
            dgvNXB.DataSource = NhaXuatBanDAO.Instance.TotalPublishers();

            int all = SachDAO.Instance.TotalBooks();
            int availabe = SachDAO.Instance.TotalAvailableBooks();
            int borrowed = SachDAO.Instance.TotalBorrowedBooks();
            int lostDamaged = SachDAO.Instance.TotalDamagedOrLostBooks();

            chartSach.Titles.Add("Tổng số sách: " + all);
            chartSach.Series["SachSeries"].Points.AddXY($"Hiện hữu  {availabe} ", availabe);
            chartSach.Series["SachSeries"].Points.AddXY($"Đang mượn  {borrowed} ", borrowed);
            chartSach.Series["SachSeries"].Points.AddXY($"Đã trả  {lostDamaged} ", lostDamaged);

            double total = chartSach.Series["SachSeries"].Points.Sum(p => p.YValues[0]);

            foreach (var point in chartSach.Series["SachSeries"].Points)
            {
                double percentage = (point.YValues[0] / total) * 100;
                point.Label = $"{percentage:F2}%";
                point.LegendText = point.AxisLabel;
            }
        }
        private void LoadTaiKhoanChart()
        {
            int all = TaiKhoanDAO.Instance.TotalAccounts();
            int daiTra = TaiKhoanDAO.Instance.TotalMassStudentAccounts();
            int thuThu = TaiKhoanDAO.Instance.TotalLibrarianAccounts();
            int quanTriVien = TaiKhoanDAO.Instance.TotalAdministratorAccounts();

            chartTaiKhoan.Titles.Add("Tổng số tài khoản: " + all);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Độc giả {daiTra}", daiTra);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Thủ thư {thuThu}", thuThu);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Quản trị viên {quanTriVien}", quanTriVien);

            double total = chartTaiKhoan.Series["TaiKhoanSeries"].Points.Sum(p => p.YValues[0]);

            foreach (var point in chartTaiKhoan.Series["TaiKhoanSeries"].Points)
            {
                double percentage = (point.YValues[0] / total) * 100;
                point.Label = $"{percentage:F2}%";
                point.LegendText = point.AxisLabel;
            }
        }
    }
}
