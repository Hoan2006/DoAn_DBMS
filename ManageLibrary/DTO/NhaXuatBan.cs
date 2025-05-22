using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        private int manhaxuatban;
        private string tennhaxuatban;

        public int MaNhaXuatBan
        {
            get { return manhaxuatban; }
            set { manhaxuatban = value; }
        }
        public string TenNhaXuatBan
        {
            get { return tennhaxuatban; }
            set { tennhaxuatban = value; }
        }
        public NhaXuatBan(int manhaxuatban, string tennhaxuatban)
        {
            this.MaNhaXuatBan = manhaxuatban;
            this.TenNhaXuatBan = tennhaxuatban;
        }
        public NhaXuatBan(DataRow row)
        {
            this.MaNhaXuatBan = (int)row["MaNhaXuatBan"];
            this.TenNhaXuatBan = row["TenNhaXuatBan"].ToString();
        }
        public NhaXuatBan()
        {
        }
    }
}
