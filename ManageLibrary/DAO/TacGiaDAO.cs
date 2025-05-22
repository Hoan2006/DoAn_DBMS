using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaDAO
    {
        private static TacGiaDAO instance;
        public static TacGiaDAO Instance
        {
            get { if (instance == null) instance = new TacGiaDAO(); return instance; }
            private set { instance = value; }
        }
        public TacGiaDAO() { }

        public DataTable LoadTacGiaList()
        {
            string query = "Select * from VW_TacGia_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void AddTacGia(TacGia tg)
        {
            string query = "SP_Add_Tac_Gia @TenTacGia ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tg.TenTacGia });
        }
        public bool UpdateTacGia(TacGia tg)
        {
            string query = "SP_Update_Tac_Gia @MaTacGia , @TenTacGia ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tg.MaTacGia, tg.TenTacGia });
            return result > 0;
        }
        public DataTable FindTacGia(TacGia tg)
        {
            object tenTacGia = tg.TenTacGia;
            if (tg.TenTacGia == "")
            {
                tenTacGia = DBNull.Value;
            }
            string query = "SP_Find_TacGia @TenTacGia ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTacGia });
            return data;
        }
        public void DeleteTacGia(int maTacGia)
        {
            string query = "SP_Delete_TacGia @MaTacGia ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maTacGia });
        }

        public DataTable TotalAuthors()
        {
            string query = "SELECT * FROM FN_Total_Authors()";
            DataTable total = DataProvider.Instance.ExecuteQuery(query);
            return total;
        }
    }
}
