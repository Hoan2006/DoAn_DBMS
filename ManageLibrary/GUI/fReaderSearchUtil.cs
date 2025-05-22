using DAO;
using DTO;
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
    public partial class fReaderSearchUtil : Form
    {
        private DataTable clone;
        public fReaderSearchUtil(int type)
        {
            InitializeComponent();
            switch (type)
            {
                case 0:
                    dgvSearch.DataSource = SachDAO.Instance.LoadTacGia();
                    clone = SachDAO.Instance.LoadTacGia();
                    break;
                case 1:
                    dgvSearch.DataSource = SachDAO.Instance.LoadNhaXuatBan();
                    clone = SachDAO.Instance.LoadTacGia();
                    break;
                case 2:
                    dgvSearch.DataSource = SachDAO.Instance.LoadTheLoai();
                    clone = SachDAO.Instance.LoadTacGia();
                    break;
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text.Trim();

            DataTable filtered = clone.Clone();

            foreach (DataRow row in clone.Rows)
            {
                if (row["TenTacGia"].ToString().ToLower().Contains(keyword.ToLower()))
                {
                    filtered.ImportRow(row);
                }
            }

            dgvSearch.DataSource = filtered;
        }

        private void dgvSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSearch.Rows[e.RowIndex];

            Session.temp = (int)selectedRow.Cells[0].Value;

            this.Close();
        }
    }
}
