using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MuonSachDAO
    {
       
        private static MuonSachDAO instance;
        public static MuonSachDAO Instance
        {
            get { if (instance == null) instance = new MuonSachDAO(); return instance; }
            private set { instance = value; }
        }
        private MuonSachDAO() { }


        public DataTable LoadLichSuMuonSachByTaiKhoan(int maTaiKhoan)
        {
            string query = "exec SP_GetLichSuMuonSachByMaTaiKhoan @MaTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
            return data;
        }

        public bool MuonSach(int maTaiKhoan, int maSach, DateTime ngayMuon, DateTime ngayTra)
        {
            try
            { 
                string query = "exec SP_Reader_MuonSach @MaTaiKhoan , @MaSach , @NgayMuon , @NgayTra";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTaiKhoan, maSach, ngayMuon, ngayTra });
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        public bool UpdateTraSach(int maPhieuMuon)
        {
            string query = "exec SP_UpdateTraSach @MaPhieuMuon";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieuMuon });
            return result > 0;

        }
    }
}
