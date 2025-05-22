using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai
    {
        public TheLoai(int maTheLoai, string tenTheLoai)
        {
            this.MaTheLoai = maTheLoai;
            this.TenTheLoai = tenTheLoai;
        }

        public TheLoai(DataRow row)
        {
            this.MaTheLoai = (int)row["MaTheLoai"];
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }

        public TheLoai()
        {
        }

        private int maTheLoai;
        private string tenTheLoai;

        public int MaTheLoai
        {
            get
            {
                return maTheLoai;
            }

            set
            {
                maTheLoai = value;
            }
        }

        public string TenTheLoai
        {
            get
            {
                return tenTheLoai;
            }

            set
            {
                tenTheLoai = value;
            }
        }
    }
}