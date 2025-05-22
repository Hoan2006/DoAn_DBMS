using DAO;
using DTO;
using LibraryManagement.DAO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAccount : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource ScheduleList = new BindingSource();
        private DataGridViewCell previousCell;

        public fAccount()
        {
            InitializeComponent();

            dgvAccount.DataSource = accountList;
            dgvSchedule.DataSource = ScheduleList;

            DetachAccountBinding();
            DetachScheduleBinding();

            LoadAccountProfile();
            LoadAccountList();
            LoadScheduleList();

            // Nếu tài khoản đăng nhập có role là "ThuThu" thì disable các nút thay đổi lịch
            if (Session.loginAccount.VaiTro == "ThuThu")
            {
                DisableScheduleModificationButtons();
            }
        }

        //Binding
        private void DetachAccountBinding()
        {
            inpAccName.DataBindings.Clear();
            inpAccEmail.DataBindings.Clear();
            numAccID.DataBindings.Clear();
            dtpAccNgaySinh.DataBindings.Clear();
            inpAccPass.DataBindings.Clear();
            rbtnNam.DataBindings.Clear();
            rbtnNu.DataBindings.Clear();
            inpAccPhone.DataBindings.Clear();
            cbAccRole.DataBindings.Clear();
            inpAccAddress.DataBindings.Clear();
        }

        private void AddAccountBinding()
        {
            inpAccName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "HoTen"));
            inpAccEmail.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email"));
            numAccID.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MaTaiKhoan"));
            dtpAccNgaySinh.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "NgaySinh"));
            inpAccPass.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MatKhau"));
            var maleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            maleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value == "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNam.DataBindings.Add(maleBinding);

            var femaleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            femaleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value != "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNu.DataBindings.Add(femaleBinding);
            inpAccPhone.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "SoDienThoai"));
            cbAccRole.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "VaiTro"));
            inpAccAddress.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DiaChi"));
        }

        private void AddScheduleBinding()
        {
            dtpLibDay.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "NgayLam"));
            cbLibName.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "HoTen"));
            cbLibCa.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "Ca"));
            numLibID.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "MaLichLamViec"));
        }

        private void DetachScheduleBinding()
        {
            dtpLibDay.DataBindings.Clear();
            cbLibName.DataBindings.Clear();
            cbLibCa.DataBindings.Clear();
            numLibID.DataBindings.Clear();
        }

        // Tab1
        private void LoadAccountProfile()
        {
            TaiKhoan tk = Session.loginAccount;

            lbMaTaiKhoan.Text = tk.MaTaiKhoan.ToString();
            lbHoTen.Text = tk.HoTen;
            lbNgaySinh.Text = tk.NgaySinh.ToShortDateString();
            lbGioiTinh.Text = tk.GioiTinh.ToString();
            lbEmail.Text = tk.Email;
            lbDiaChi.Text = tk.DiaChi;
            lbVaiTro.Text = tk.VaiTro;
            lbSoDienThoai.Text = tk.SoDienThoai;
        }

        // Tab2
        private void LoadAccountList()
        {
            accountList.DataSource = TaiKhoanDAO.Instance.LoadAccountList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DetachAccountBinding();

            LoadAccountList();

            numAccID.Value = 0;
            inpAccName.Clear();
            inpAccPass.Clear();
            inpAccEmail.Clear();
            dtpAccNgaySinh.Value = DateTime.Now;
            cbAccRole.SelectedItem = null;
            inpAccAddress.Clear();
            inpAccPhone.Clear();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void DisableScheduleModificationButtons()
        {
            // Disable các nút cho phép thay đổi lịch (thêm, xóa, cập nhật)
            btnLibCreate.Enabled = false;
            btnLibDelete.Enabled = false;
            btnLibUpdate.Enabled = false;
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                numAccID.Value = 0;
                inpAccName.Clear();
                inpAccPass.Clear();
                inpAccEmail.Clear();
                dtpAccNgaySinh.Value = DateTime.Now;
                cbAccRole.SelectedItem = null;
                inpAccAddress.Clear();
                inpAccPhone.Clear();
                rbtnNam.Checked = false;
                rbtnNu.Checked = false;
            }
            else
            {
                DetachAccountBinding();
                AddAccountBinding();
                DetachAccountBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvAccount.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.MatKhau = inpAccPass.Text;
                tk.Email = inpAccEmail.Text;
                tk.NgaySinh = dtpAccNgaySinh.Value;
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
                tk.DiaChi = inpAccAddress.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                else
                {
                    tk.GioiTinh = "Nữ";
                }

                tk.SoDienThoai = inpAccPhone.Text;

                TaiKhoanDAO.Instance.AddAccount(tk);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                DetachAccountBinding();
                int accID = (int)numAccID.Value;

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    TaiKhoanDAO.Instance.DeleteAccount(accID);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                DetachAccountBinding();

                TaiKhoan tk = new TaiKhoan();
                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.MatKhau = inpAccPass.Text;
                tk.Email = inpAccEmail.Text;
                tk.NgaySinh = dtpAccNgaySinh.Value;
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
                tk.DiaChi = inpAccAddress.Text;
                tk.SoDienThoai = inpAccPhone.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                else
                {
                    tk.GioiTinh = "Nữ";
                }

                TaiKhoanDAO.Instance.UpdateAccount(tk);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (tk.MaTaiKhoan == Session.loginAccount.MaTaiKhoan)
                {
                    Session.loginAccount = tk;
                }

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindAcc_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();

                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.Email = inpAccEmail.Text;
                if (cbAccRole.SelectedItem != null)
                {
                    tk.VaiTro = cbAccRole.SelectedItem.ToString();
                }
                tk.DiaChi = inpAccAddress.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                if (rbtnNu.Checked)
                {
                    tk.GioiTinh = "Nữ";
                }

                tk.SoDienThoai = inpAccPhone.Text;


                accountList.DataSource = TaiKhoanDAO.Instance.FindAccountByAdvanced(tk);
            }
            catch
            {
                MessageBox.Show("Không có kết quả", "Find account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tab 3
        private string maTaiKhoan = null;

        private DateTime setWeekstart;
        private DateTime setWeekend;
        private bool changeWeek = false;
        private DateTime today = DateTime.Now;

        private void PersonalSchedule()
        {
            if (Session.loginAccount.VaiTro == "ThuThu")
            {
                maTaiKhoan = Session.loginAccount.MaTaiKhoan.ToString();
            }
        }

        private void LoadThisWeek()
        {
            if (!changeWeek)
            {
                int weekstart = 1 - (int)today.DayOfWeek;
                int weekend = 7 - (int)today.DayOfWeek;

                dtpMonday.Value = today.AddDays(weekstart);
                dtpSunday.Value = today.AddDays(weekend);

                setWeekstart = dtpMonday.Value;
                setWeekend = dtpSunday.Value;
            }
            else
            {
                setWeekstart = dtpMonday.Value;
                setWeekend = dtpSunday.Value;
            }
            ScheduleList.DataSource = LichLamViecDAO.Instance.LoadLichLamViecList(setWeekstart, setWeekend, maTaiKhoan);
        }

        private void LoadScheduleList()
        {
            cbLibName.DataSource = TaiKhoanDAO.Instance.LoadLibrarian();
            cbLibName.DisplayMember = "HoTen";
            cbLibName.ValueMember = "MaTaiKhoan";
            cbLibName.SelectedItem = null;

            changeWeek = false;
            PersonalSchedule();
            LoadThisWeek();
        }

        private void btnAllSchedule_Click_1(object sender, EventArgs e)
        {
            maTaiKhoan = null;
            LoadThisWeek();
        }

        private void btnResetSchedule_Click(object sender, EventArgs e)
        {
            maTaiKhoan = null;
            PersonalSchedule();
            cbLibName.SelectedIndex = -1;
            cbLibCa.SelectedIndex = -1;
            numLibID.Value = 0;
            dtpLibDay.Value = DateTime.Now;
            changeWeek = false;
            LoadThisWeek();
        }

        private void btnFindSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                maTaiKhoan = cbLibName.SelectedValue.ToString();
                LoadThisWeek();
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            changeWeek = true;
            dtpMonday.Value = dtpMonday.Value.AddDays(7);
            dtpSunday.Value = dtpMonday.Value.AddDays(6);
            LoadThisWeek();
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            changeWeek = true;
            dtpMonday.Value = dtpMonday.Value.AddDays(-7);
            dtpSunday.Value = dtpMonday.Value.AddDays(6);
            LoadThisWeek();
        }

        private void dtpSunday_ValueChanged(object sender, EventArgs e)
        {
            changeWeek = true;

            LoadThisWeek();
        }

        private void dtpMonday_ValueChanged(object sender, EventArgs e)
        {
            changeWeek = true;

            LoadThisWeek();
        }

        private void dgvSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachScheduleBinding();
                cbLibName.SelectedItem = null;
                cbLibCa.SelectedItem = null;
                dtpLibDay.Value = DateTime.Now;
                numLibID.Value = 0;
            }
            else
            {
                DetachScheduleBinding();
                AddScheduleBinding();
                DetachScheduleBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnLibDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DetachScheduleBinding();

                int id = (int)numLibID.Value;
                LichLamViecDAO.Instance.DeleteSchedule(id);

                LoadScheduleList();
            }
            catch
            {
                MessageBox.Show("Hãy chọn đối tượng cần xóa", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLibUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DetachScheduleBinding();

                LichLamViec newLLV = new LichLamViec();
                newLLV.MaLichLamViec = (int)numLibID.Value;
                newLLV.NgayLam = dtpLibDay.Value;
                newLLV.Ca = cbLibCa.SelectedItem.ToString();
                newLLV.MaTaiKhoan = (int)cbLibName.SelectedValue;
                LichLamViecDAO.Instance.UpdateSchedule(newLLV);

                LoadScheduleList();
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật do trùng lịch làm việc", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLibCreate_Click(object sender, EventArgs e)
        {
            try
            {
                LichLamViec newLLV = new LichLamViec();

                newLLV.NgayLam = dtpLibDay.Value;
                newLLV.Ca = cbLibCa.SelectedItem.ToString();
                newLLV.MaTaiKhoan = (int)cbLibName.SelectedValue;

                LichLamViecDAO.Instance.AddNewSchedule(newLLV);
                LoadScheduleList();
            }
            catch
            {
                MessageBox.Show("Không thể tạo do trùng lịch làm việc", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
