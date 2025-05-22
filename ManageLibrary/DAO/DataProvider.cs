using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions; // Đừng quên include namespace này
namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        //Đường dẫn
        //(Phat)    Data Source=LAPTOP-M3L0LSMS;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True
        //(Trung)
        //(Hoan)    Data Source=LAPTOP-L7BVASSV\MAY1;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True
        //(Van)     Data Source=MSI\MSSQLSERVER02;Initial Catalog=Library;Integrated Security=True


        //private string connectionStr = $"Data Source=LAPTOP-M3L0LSMS;Initial Catalog=LibraryReader;User ID={DTO.Session.loginAccount.Email};Password={DTO.Session.loginAccount.MatKhau};TrustServerCertificate=True";

        SqlConnection connection;

        private string GetConnectionString()
        {
            if (DTO.Session.loginAccount == null)
            {
                return @"Data Source=LAPTOP-L7BVASSV\MAY1;Initial Catalog=QLTV;Integrated Security=True;TrustServerCertificate=True";
            }

            return $"Data Source=LAPTOP-L7BVASSV\\MAY1;Initial Catalog=QLTV;User ID={DTO.Session.loginAccount.Email};Password={DTO.Session.loginAccount.MatKhau};TrustServerCertificate=True";
        }


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;
        }

    }
}