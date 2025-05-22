using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool Register(TaiKhoan tk)
        {
            try
            { 
            string query = "SP_Add_New_Account @MaTaiKhoan , @HoTen , @MatKhau , @DiaChi , @NgaySinh , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.MatKhau, tk.DiaChi, tk.NgaySinh, tk.Email, tk.SoDienThoai, tk.VaiTro, tk.GioiTinh });

            // Create Login, User, and Grant Role queries
            string CreateLoginQuery = $"CREATE LOGIN [{tk.Email}] WITH PASSWORD = '{tk.MatKhau}'";
                string CreateUserQuery = $"CREATE USER [{tk.Email}] FOR LOGIN [{tk.Email}]";
                string GrantRoleQuery = $"EXEC sp_addrolemember '{tk.VaiTro}', [{tk.Email}]";

                // Execute the queries for login, user, and role
                DataProvider.Instance.ExecuteNonQuery(CreateLoginQuery);
                DataProvider.Instance.ExecuteNonQuery(CreateUserQuery);
                DataProvider.Instance.ExecuteNonQuery(GrantRoleQuery);

                Session.loginAccount = tk; // Store the account in the session

                return true; // Registration successful
            }
            catch (Exception ex)
            {
                Console.WriteLine("Registration failed: " + ex.Message);
                return false;
            }
        }


        public bool CheckLogin(string email, string password)
            {
            string query = "exec SP_Login @Email , @MatKhau";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email, password });
            if (data.Rows.Count > 0)
            {
                return true;
                
            }
            return false;
            }
    

        public TaiKhoan GetTaiKhoanByEmail(string email)
        {
            string query = "EXEC SP_Get_Account_Profile @Email";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            if (data.Rows.Count > 0)
            {
                return new TaiKhoan(data.Rows[0]);
            }
            return null;
        }


        public DataTable GetAllMaTaiKhoan()
        {
            string query = "select* from VW_GetAllMaTaiKhoan;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool Login(string email, string matKhau)
        {
            string query = "SP_Login @Email , @MatKhau ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email, matKhau });

            return result.Rows.Count > 0;
        }

        public DataTable LoadAccountList()
        {
            string query = "SELECT * FROM VW_Account_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public TaiKhoan GetAccountProfile(string email)
        {
            string query = "SP_Get_Account_Profile @Email ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }

        public bool ChangeAccountPassword(string email, string newPass, string confirm, string oldPass)
        {
            string query = "SP_Change_Account_Password @Email , @MatKhauMoi , @XacNhan , @MatKhauCu ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { email, newPass, confirm, oldPass });



            return result > 0;
        }

        public bool UpdateProfile(TaiKhoan tk)
        {
            string query = "SP_Account_Profile @MaTaiKhoan , @HoTen , @DiaChi , @NgaySinh , @SoDienThoai , @GioiTinh ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.DiaChi, tk.NgaySinh, tk.SoDienThoai, tk.GioiTinh });

            return result > 0;
        }

        public void AddAccount(TaiKhoan tk)
        {
            string query = "SP_Add_New_Account @MaTaiKhoan , @HoTen , @MatKhau , @DiaChi , @NgaySinh , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.MatKhau, tk.DiaChi, tk.NgaySinh, tk.Email, tk.SoDienThoai, tk.VaiTro, tk.GioiTinh });
        }

        public void DeleteAccount(int maTaiKhoan)
        {
            string query = "SP_Delete_Account @MaTaiKhoan ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
        }

        public bool UpdateAccount(TaiKhoan tk)
        {
            string query = "SP_Update_Account @MaTaiKhoan , @HoTen , @MatKhau , @DiaChi , @NgaySinh , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.MatKhau, tk.DiaChi, tk.NgaySinh, tk.Email, tk.SoDienThoai, tk.VaiTro, tk.GioiTinh });

            return result > 0;
        }

        public DataTable FindAccountByAdvanced(TaiKhoan tk)
        {
            object maTaiKhoan = tk.MaTaiKhoan;
            object hoTen = tk.HoTen;
            object email = tk.Email;
            object vaiTro = tk.VaiTro;
            object gioiTinh = tk.GioiTinh;
            object diaChi = tk.DiaChi;
            object soDienThoai = tk.SoDienThoai;
            if (tk.MaTaiKhoan == 0)
            {
                maTaiKhoan = DBNull.Value;
            }
            if (tk.HoTen == "")
            {
                hoTen = DBNull.Value;
            }
            if (tk.Email == "")
            {
                email = DBNull.Value;
            }
            if (tk.VaiTro == null)
            {
                vaiTro = DBNull.Value;
            }
            if (tk.GioiTinh == null)
            {
                gioiTinh = DBNull.Value;
            }
            if (tk.DiaChi == "")
            {
                diaChi = DBNull.Value;
            }
            if (tk.SoDienThoai == "")
            {
                soDienThoai = DBNull.Value;
            }

            string query = "SP_Find_Account_By_Advanced @MaTaiKhoan , @HoTen , @DiaChi , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan, hoTen, diaChi, email, soDienThoai, vaiTro, gioiTinh });
            return data;
        }

        public DataTable LoadLibrarian()
        {
            string query = "Select * from VW_Librarian_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public int TotalAccounts()
        {
            string query = "SELECT * FROM FN_Total_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalHighQualityStudentAccounts()
        {
            string query = "SELECT * FROM FN_Total_High_Quality_Student_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalMassStudentAccounts()
        {
            string query = "SELECT * FROM FN_Total_Mass_Student_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalGraduateStudentAccounts()
        {
            string query = "SELECT * FROM FN_Total_Graduate_Student_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalLecturerAccounts()
        {
            string query = "SELECT * FROM FN_Total_Lecturer_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalLibrarianAccounts()
        {
            string query = "SELECT * FROM FN_Total_Librarian_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }

        public int TotalAdministratorAccounts()
        {
            string query = "SELECT * FROM FN_Total_Administrator_Accounts()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
    }
}
