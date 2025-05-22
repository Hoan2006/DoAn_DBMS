using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiDAO(); return instance; }
            private set { instance = value; }
        }

        private TheLoaiDAO() { }

        public DataTable LoadTheLoaiList()
        {
            string query = "SELECT * FROM VW_TheLoai_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void AddTheLoai(TheLoai tl)
        {
            string query = "SP_Add_New_TheLoai @TenTheLoai ";

            DataProvider.Instance.ExecuteQuery(query, new object[] { tl.TenTheLoai });
        }

        public void DeleteTheLoai(int maTheLoai)
        {
            string query = "SP_Delete_TheLoai @MaTheLoai ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maTheLoai });
        }

        public bool UpdateTheLoai(TheLoai tl)
        {
            string query = "SP_Update_TheLoai @MaTheLoai , @TenTheLoai ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tl.MaTheLoai, tl.TenTheLoai });

            return result > 0;
        }

        public DataTable FindTheLoai(string tenTheLoai)
        {
            object TenTheLoai = tenTheLoai;
            if (tenTheLoai == "")
            {
                TenTheLoai = DBNull.Value;
            }
            string query = "SP_Find_TheLoai @TenTheLoai ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTheLoai });
            return data;
        }

        public DataTable TotalCategories()
        {
            string query = "SELECT * FROM FN_Total_Categories()";
            DataTable total = DataProvider.Instance.ExecuteQuery(query);
            return total;
        }


    }
}