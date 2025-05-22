using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return instance; }
            private set { instance = value; }
        }

        private SachDAO()
        {

        }
        public DataTable LoadBookList()
        {
           

            string query = "SELECT * FROM VW_Book_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        /*public DataTable LoadBookListByBorrowedOrPenaltyID(int muon, int phat)
        {
            if (muon != 0)
            {
                string query = "SELECT * FROM dbo.FN_Reader_Borrowed_Detail( @MaPhieuMuon , @MaPhieuPhat )";
                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { muon, DBNull.Value });
                return data;
            }
            else
            {
                string query = "SELECT * FROM dbo.FN_Reader_Borrowed_Detail( @MaPhieuMuon , @MaPhieuPhat )";
                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { DBNull.Value, phat });
                return data;
            }
        }*/
        public DataTable LoadTacGia()
        {
            string query = "Select * from VW_TacGia_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadNhaXuatBan()
        {
            string query = "Select * from VW_NhaXuatBan_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadTheLoai()
        {
            string query = "Select * from VW_TheLoai_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable LoadSachByName(string TenSach)
        {
            string query = "exec SP_TimKiemSachTheoTenSach @TenSach";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenSach });
            return data;
        }
        public DataTable LoadSachByTheLoai(string TenTheLoai)
        {
            string query = "exec SP_TimKiemSachTheoTheLoai @TenTheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTheLoai });
            return data;
        }


        public DataTable LoadSachByNhaXuatBan(int MaNhaXuatBan)
        {
            string query = "exec SP_TimKiemSachTheoMaNhaXuatBan1 @MaNhaXuatBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhaXuatBan });
            return data;
        }

        public DataTable LoadSachByTacGia(int MaTacGia)
        {
            string query = "exec SP_TimKiemSachTheoMaTacGia @MaTacGia";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaTacGia });
            return data;
        }
        public void DeleteBook(int maSach)
        {
            string query = "SP_Delete_Book @MaSach ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maSach });
        }

        public void AddBook(Sach s)
        {
            string query = "SP_Add_New_Book @MaTacGia , @MaTheLoai , @MaNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan , @GiaSach , @SoLuong ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { s.MaTacGia, s.MaTheLoai, s.MaNhaXuatBan, s.TenSach, s.LoaiTaiLieu, s.NamXuatBan, s.GiaSach, s.SoLuong });
        }

        public bool UpdateBook(Sach s)
        {
            string query = "SP_Update_Book @MaTacGia , @MaTheLoai , @MaNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan , @GiaSach , @SoLuong ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { s.MaTacGia, s.MaTheLoai, s.MaNhaXuatBan, s.TenSach, s.LoaiTaiLieu, s.NamXuatBan, s.GiaSach, s.SoLuong });
            return result > 0;
        }

        public DataTable FindBookByAdvanced(Sach s)
        {
            object tacGia = s.TenTacGia;
            object theLoai = s.TenTheLoai;
            object nhaXuatBan = s.TenNhaXuatBan;
            object tenSach = s.TenSach;
            object loaiTaiLieu = s.LoaiTaiLieu;
            object namXuatBan = s.NamXuatBan;

            if (s.TenTacGia == "")
            {
                tacGia = DBNull.Value;
            }
            if (s.TenTheLoai == "")
            {
                theLoai = DBNull.Value;
            }
            if (s.TenNhaXuatBan == "")
            {
                nhaXuatBan = DBNull.Value;
            }
            if (s.TenSach == "")
            {
                tenSach = DBNull.Value;
            }
            if (s.LoaiTaiLieu == "")
            {
                loaiTaiLieu = DBNull.Value;
            }
            if (s.NamXuatBan == 0)
            {
                namXuatBan = DBNull.Value;
            }
            string query = "SP_Find_Book_By_Advanced @TenTacGia , @TenTheLoai , @TenNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tacGia, theLoai, nhaXuatBan, tenSach, loaiTaiLieu, namXuatBan });
            return data;
        }

        public int TotalAvailableBooks()
        {
            string query = "SELECT * FROM FN_Total_Available_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalBorrowedBooks()
        {
            string query = "SELECT * FROM FN_Total_Borrowed_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalDamagedOrLostBooks()
        {
            string query = "SELECT * FROM FN_Total_Damaged_Or_Lost_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalBooks()
        {
            string query = "SELECT * FROM FN_Total_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }


    }
}
