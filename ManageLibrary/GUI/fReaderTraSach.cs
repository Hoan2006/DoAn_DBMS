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
    public partial class fReaderTraSach : Form
    {

        public fReaderTraSach()
        {
            InitializeComponent();
            Load_Data();
            Load_TacGia();
            Load_TheLoai();
            Load_NhaXuatBan();
        }

        public void Load_Data()
        {


            DataTable data1 = SachDAO.Instance.LoadBookList();

            dgvSach.DataSource = data1;

        }


        public void Load_TacGia()
        {
            DataTable data2 = SachDAO.Instance.LoadTacGia();
            DataRow emptyRow = data2.NewRow();
            emptyRow["MaTacGia"] = 0;
            emptyRow["TenTacGia"] = "";
            data2.Rows.InsertAt(emptyRow, 0);  // Thêm dòng rỗng vào đầu DataTable

            cbbTacGia.DataSource = data2;
            cbbTacGia.DisplayMember = "TenTacGia";
            cbbTacGia.ValueMember = "MaTacGia";
        }

        public void Load_NhaXuatBan()
        {
            DataTable data3 = SachDAO.Instance.LoadNhaXuatBan();
            DataRow emptyRow = data3.NewRow();
            emptyRow["MaNhaXuatBan"] = 0;
            emptyRow["TenNhaXuatBan"] = "";
            data3.Rows.InsertAt(emptyRow, 0);  // Thêm dòng rỗng vào đầu DataTable

            cbbNhaXuatBan.DataSource = data3;
            cbbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbbNhaXuatBan.ValueMember = "MaNhaXuatBan";
        }

        public void Load_TheLoai()
        {
            DataTable data4 = SachDAO.Instance.LoadTheLoai();
            DataRow emptyRow = data4.NewRow();
            emptyRow["TenTheLoai"] = "";
            data4.Rows.InsertAt(emptyRow, 0);  // Thêm dòng rỗng vào đầu DataTable

            cbbTheLoai.DataSource = data4;
            cbbTheLoai.DisplayMember = "TenTheLoai";
            cbbTheLoai.ValueMember = "TenTheLoai";
        }

        public void btn_Timkiemtheoten_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "")
            {
                Load_Data();
                return;
            }
            string tenSach = txbTenSach.Text;
            DataTable data5 = SachDAO.Instance.LoadSachByName(tenSach);
            dgvSach.DataSource = data5;
        }

        public void btn_TimKiemTheoTheLoai_Click(object sender, EventArgs e)
        {
            string tenTheLoai = cbbTheLoai.SelectedValue.ToString();  // Dùng SelectedValue thay vì Text để kiểm tra
            if (string.IsNullOrEmpty(tenTheLoai))
            {
                Load_Data();
                return;
            }
            DataTable data6 = SachDAO.Instance.LoadSachByTheLoai(tenTheLoai);
            dgvSach.DataSource = data6;
        }

        public void btn_TimKiemTheoNhaXuatBan_Click(object sender, EventArgs e)
        {
            int maNhaXuatBan = (int)cbbNhaXuatBan.SelectedValue;
            if (maNhaXuatBan == 0)
            {
                Load_Data();
                return;
            }
            DataTable data7 = SachDAO.Instance.LoadSachByNhaXuatBan(maNhaXuatBan);
            dgvSach.DataSource = data7;
        }

        public void btn_TimKiemTheoTacGia_Click(object sender, EventArgs e)
        {
            int maTacGia = (int)cbbTacGia.SelectedValue;
            if (maTacGia == 0)
            {
                Load_Data();
                return;
            }
            DataTable data8 = SachDAO.Instance.LoadSachByTacGia(maTacGia);
            dgvSach.DataSource = data8;
        }


        public void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgvSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvSach.Rows[rowIndex];
                nudMasachdachon.Value = Convert.ToInt32(selectedRow.Cells["MaSach"].Value);
            }
        }


        public void btnMuonSach_Click(object sender, EventArgs e)
        {
            int maSach = (int)nudMasachdachon.Value;
            int maTaiKhoan = Session.loginAccount.MaTaiKhoan;
            DateTime ngayMuon = dtpNgayMuon.Value; // Ngày mượn từ DateTimePicker
            DateTime ngayTra = dtpNgayTra.Value; // Giả sử thời gian trả là 7 ngày sau
            if (MuonSachDAO.Instance.MuonSach(maTaiKhoan, maSach, ngayMuon, ngayTra))
            {
                MessageBox.Show("Mượn sách thành công!");
                Load_Data();
            }
            else
            {
                MessageBox.Show("Mượn sách thất bại!");
            }
        }


    }
}
