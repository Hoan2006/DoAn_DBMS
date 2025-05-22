using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Session
    {
        public static TaiKhoan loginAccount { get; set; }


        public static Sach sachMuon { get; set; }

        public static int temp { get; set; }
        public static List<int> booksID { get; set; } = new List<int>();
        public static List<string> booksName { get; set; } = new List<string>();
    }
}
