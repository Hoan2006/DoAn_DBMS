using DAO;
using DTO;
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
    public partial class fBook : Form
    {
        BindingSource sachList = new BindingSource();
        BindingSource tacGiaList = new BindingSource();
        BindingSource TheLoaiList = new BindingSource();
        BindingSource nhaxuatbanlist = new BindingSource();
        private DataGridViewCell previousCell;
        private enum type
        {
            AuthorMode = 0,
            NXBMode = 1,
            GerneMode = 2
        }

        public fBook()
        {
            InitializeComponent();

            dgvSach.DataSource = sachList;
            dgvTacGia.DataSource = tacGiaList;
            dgvTheLoai.DataSource = TheLoaiList;
            dgvNhaXuatBan.DataSource = nhaxuatbanlist;

            LoadTacGiaList();
            LoadSachList();
            LoadTheLoaiList();
            LoadNXBList();

            DetachBookBinding();
            DetachTacGiaBinding();
            DetachNXBBinding();
            DetachTheLoaiBinding();

            cbTacGia.DataSource = SachDAO.Instance.LoadTacGia();
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
            cbTacGia.SelectedItem = null;

            cbNhaXuatBan.DataSource = SachDAO.Instance.LoadNhaXuatBan();
            cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbNhaXuatBan.ValueMember = "MaNhaXuatBan";
            cbNhaXuatBan.SelectedItem = null;

            cbTheLoai.DataSource = SachDAO.Instance.LoadTheLoai();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.SelectedItem = null;
        }

        private void DetachBookBinding()
        {
            txbTenSach.DataBindings.Clear();
            cbTacGia.DataBindings.Clear();
            cbNhaXuatBan.DataBindings.Clear();
            cbTheLoai.DataBindings.Clear();
            nudSoLuong.DataBindings.Clear();
            nudNamXuatBan.DataBindings.Clear();
            cbLoaiTaiLieu.DataBindings.Clear();
            nudGiaSach.DataBindings.Clear();
            nudMaSach.DataBindings.Clear();
        }

        private void DetachTheLoaiBinding()
        {
            txbTenTheLoai.DataBindings.Clear();
            numTheLoaiID.DataBindings.Clear();
        }

        private void DetachTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Clear();
            numTacGiaID.DataBindings.Clear();
        }

        private void DetachNXBBinding()
        {
            txbNXB.DataBindings.Clear();
            numNXBid.DataBindings.Clear();
        }

        public void LoadSachList()
        {
            sachList.DataSource = SachDAO.Instance.LoadBookList();
        }

        private void LoadTheLoaiList()
        {
            TheLoaiList.DataSource = TheLoaiDAO.Instance.LoadTheLoaiList();
        }

        private void LoadNXBList()
        {
            nhaxuatbanlist.DataSource = NhaXuatBanDAO.Instance.LoadNXBList();
        }

        public void LoadTacGiaList()
        {
            tacGiaList.DataSource = TacGiaDAO.Instance.LoadTacGiaList();
        }

        private void AddBookBinding()
        {
            txbTenSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenSach"));
            cbTacGia.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTacGia"));
            nudMaSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "MaSach"));
            cbNhaXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenNhaXuatBan"));
            cbTheLoai.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTheLoai"));
            nudSoLuong.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "SoLuong"));
            nudNamXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "NamXuatBan"));
            cbLoaiTaiLieu.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "LoaiTaiLieu"));
            nudGiaSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "GiaSach"));
        }

        private void AddTheLoaiBinding()
        {
            txbTenTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "TenTheLoai"));
            numTheLoaiID.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "MaTheLoai"));
        }

        private void AddTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Add(new Binding("Text", dgvTacGia.DataSource, "TenTacGia"));
            numTacGiaID.DataBindings.Add(new Binding("Text", dgvTacGia.DataSource, "MaTacGia"));
        }

        private void AddNXBBinding()
        {
            txbNXB.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "TenNhaXuatBan"));
            numNXBid.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "MaNhaXuatBan"));
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;
            s.MaTacGia = (int)cbTacGia.SelectedValue;
            s.MaNhaXuatBan = (int)cbNhaXuatBan.SelectedValue;
            s.MaTheLoai = (int)cbTheLoai.SelectedValue;
            s.SoLuong = (int)nudSoLuong.Value;
            s.NamXuatBan = (int)nudNamXuatBan.Value;
            s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            s.GiaSach = (decimal)nudGiaSach.Value;

            try
            {
                SachDAO.Instance.AddBook(s);
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sách thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadSachList();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;
            s.MaTacGia = (int)cbTacGia.SelectedValue;
            s.MaNhaXuatBan = (int)cbNhaXuatBan.SelectedValue;
            s.MaTheLoai = (int)cbTheLoai.SelectedValue;
            s.SoLuong = (int)nudSoLuong.Value;
            s.NamXuatBan = (int)nudNamXuatBan.Value;
            s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            s.GiaSach = (decimal)nudGiaSach.Value;

            try
            {
                // Giả sử UpdateBook trả về kiểu bool để biết được quá trình cập nhật thành công hay không
                bool result = SachDAO.Instance.UpdateBook(s);
                if (result)
                {
                    MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật sách không thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật sách thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadSachList();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int maSach = (int)nudMaSach.Value;

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa sách này không?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    SachDAO.Instance.DeleteBook(maSach);
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa sách thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadSachList();
        }

        private void btnResertBook_Click(object sender, EventArgs e)
        {
            DetachBookBinding();

            nudMaSach.Value = 0;
            txbTenSach.Clear();
            cbTacGia.SelectedItem = null;
            cbNhaXuatBan.SelectedItem = null;
            cbTheLoai.SelectedItem = null;
            nudSoLuong.Value = 0;
            nudNamXuatBan.Value = 0;
            cbLoaiTaiLieu.SelectedItem = null;
            nudGiaSach.Value = 0;

            LoadSachList();
        }

        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachBookBinding();

                nudMaSach.Value = 0;
                txbTenSach.Clear();
                cbTacGia.SelectedItem = null;
                cbNhaXuatBan.SelectedItem = null;
                cbTheLoai.SelectedItem = null;
                nudSoLuong.Value = 0;
                nudNamXuatBan.Value = 0;
                cbLoaiTaiLieu.SelectedItem = null;
                nudGiaSach.Value = 0;
            }
            else
            {
                DetachBookBinding();
                AddBookBinding();
                DetachBookBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;

            if (cbTacGia.SelectedItem == null)
            {
                s.TenTacGia = "";
            }
            else
            {
                s.TenTacGia = ((DataRowView)cbTacGia.SelectedItem)["TenTacGia"].ToString();
            }

            if (cbNhaXuatBan.SelectedItem == null)
            {
                s.TenNhaXuatBan = "";
            }
            else
            {
                s.TenNhaXuatBan = ((DataRowView)cbNhaXuatBan.SelectedItem)["TenNhaXuatBan"].ToString();
            }

            if (cbTheLoai.SelectedItem == null)
            {
                s.TenTheLoai = "";
            }
            else
            {
                s.TenTheLoai = ((DataRowView)cbTheLoai.SelectedItem)["TenTheLoai"].ToString();
            }

            s.NamXuatBan = (int)nudNamXuatBan.Value;

            if (cbLoaiTaiLieu.SelectedItem == null)
            {
                s.LoaiTaiLieu = "";
            }
            else
            {
                s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            }

            sachList.DataSource = SachDAO.Instance.FindBookByAdvanced(s);

        }

        private void btnAddTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.TenTacGia = txbTenTacGia.Text;

            try
            {
                TacGiaDAO.Instance.AddTacGia(tg);
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tác giả thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTacGiaList();
        }

        private void btnUpdateTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.MaTacGia = int.Parse(dgvTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString());
            tg.TenTacGia = txbTenTacGia.Text;

            try
            {
                TacGiaDAO.Instance.UpdateTacGia(tg);
                MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tác giả thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTacGiaList();
        }

        private void btnDeleteTacGia_Click(object sender, EventArgs e)
        {
            int maTacGia = (int)numTacGiaID.Value;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa tác giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    TacGiaDAO.Instance.DeleteTacGia(maTacGia);
                    MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa tác giả thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadTacGiaList();
            }
        }

        private void btnResertTacGia_Click(object sender, EventArgs e)
        {
            DetachTacGiaBinding();

            LoadTacGiaList();

            numTacGiaID.Value = 0;
            txbTenTacGia.Clear();
        }

        private void btnFindTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia tg = new TacGia();

                tg.TenTacGia = txbTenTacGia.Text;

                tacGiaList.DataSource = TacGiaDAO.Instance.FindTacGia(tg);
            }
            catch
            {
                MessageBox.Show("Không thể tìm");
            }
        }

        private void dgvTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachTacGiaBinding();
                txbTenTacGia.Clear();
            }
            else
            {
                DetachTacGiaBinding();
                AddTacGiaBinding();
                DetachTacGiaBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvTacGia.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.TenTheLoai = txbTenTheLoai.Text;

            try
            {
                TheLoaiDAO.Instance.AddTheLoai(tl);
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thể loại thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTheLoaiList();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            int maTheLoai = (int)numTheLoaiID.Value;
            string tenTheLoai = txbTenTheLoai.Text;

            TheLoai tl = new TheLoai();
            tl.MaTheLoai = maTheLoai;
            tl.TenTheLoai = tenTheLoai;

            try
            {
                bool result = TheLoaiDAO.Instance.UpdateTheLoai(tl);
                if (result)
                {
                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thể loại không thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thể loại thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTheLoaiList();
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa thể loại này không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    TheLoaiDAO.Instance.DeleteTheLoai((int)numTheLoaiID.Value);
                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thể loại thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadTheLoaiList();
        }

        private void btnResetTheLoai_Click(object sender, EventArgs e)
        {
            LoadTheLoaiList();
            txbTenTheLoai.Clear();
            numTheLoaiID.Value = 0;
        }

        private void btnFindTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTheLoai = txbTenTheLoai.Text;
                TheLoaiList.DataSource = TheLoaiDAO.Instance.FindTheLoai(tenTheLoai);
            }
            catch
            {
                MessageBox.Show("Không thể tìm");
            }
        }

        private void dgvTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachTheLoaiBinding();
                txbTenTacGia.Clear();
            }
            else
            {
                DetachTheLoaiBinding();
                AddTheLoaiBinding();
                DetachTheLoaiBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvTheLoai.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.TenNhaXuatBan = txbNXB.Text;

            try
            {
                NhaXuatBanDAO.Instance.AddNXB(nxb);
                MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhà xuất bản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadNXBList();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.MaNhaXuatBan = (int)numNXBid.Value;
            nxb.TenNhaXuatBan = txbNXB.Text;

            try
            {
                NhaXuatBanDAO.Instance.UpdateNXB(nxb);
                MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật nhà xuất bản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadNXBList();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản này không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    NhaXuatBan nxb = new NhaXuatBan();
                    nxb.MaNhaXuatBan = (int)numNXBid.Value;
                    nxb.TenNhaXuatBan = txbNXB.Text;
                    NhaXuatBanDAO.Instance.DeleteNXB(nxb);
                    MessageBox.Show("Xóa nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa nhà xuất bản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadNXBList();
        }

        private void btnResetNXB_Click(object sender, EventArgs e)
        {
            LoadNXBList();
            numNXBid.Value = 0;
            txbNXB.Clear();
        }

        private void btnFindPushlisher_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNXB = txbNXB.Text;

                nhaxuatbanlist.DataSource = NhaXuatBanDAO.Instance.FindNhaXuatBan(tenNXB);
            }
            catch
            {
                MessageBox.Show("Không thể tìm");
            }
        }

        private void dgvNhaXuatBan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachNXBBinding();
                txbNXB.Clear();
            }
            else
            {
                DetachNXBBinding();
                AddNXBBinding();
                DetachNXBBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvNhaXuatBan.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUtil f = new fReaderSearchUtil((int)type.AuthorMode);
            f.ShowDialog();
            cbTacGia.SelectedValue = Session.temp;
        }

        private void btnNXBSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUtil f = new fReaderSearchUtil((int)type.NXBMode);
            f.ShowDialog();
            cbNhaXuatBan.SelectedValue = Session.temp;
        }

        private void btnGerneSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUtil f = new fReaderSearchUtil((int)type.GerneMode);
            f.ShowDialog();
            cbTheLoai.SelectedValue = Session.temp;
        }
    }
}
