using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DAO
{
    public class PhieuMuonSachDAO
    {
        private static PhieuMuonSachDAO instance;
        public static PhieuMuonSachDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuonSachDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuMuonSachDAO() { }
        public DataTable getAllPhieuMuonSach()
        {
            string query = "SELECT * FROM VW_AllPhieuMuonSach";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public DataTable getPhieuMuonSachByMaTaiKhoan(int maTaiKhoan)
        {
            string query = "exec SP_GetPhieuMuonSachByMaTaiKhoan @MaTaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
        }

        public DataTable getPhieuMuonSachByTinhTrang(string tinhTrang)
        {
            string query = "exec SP_GetPhieuMuonSachByTinhTrang @TinhTrang";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tinhTrang });
        }
    }
}
