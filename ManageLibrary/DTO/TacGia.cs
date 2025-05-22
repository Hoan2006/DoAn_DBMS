using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        public TacGia(int maTacGia, string tenTacGia) 
        {
            this.MaTacGia = maTacGia;
            this.TenTacGia = tenTacGia;
        }

        public TacGia() { }

        private int maTacGia;
        private string tenTacGia;

        public TacGia(DataRow row)
        {
            this.maTacGia = (int)row["MaTacGia"];
            this.tenTacGia = row["TenTacGia"].ToString();
        }

        public int MaTacGia
        {
            get
            {
                return maTacGia;
            }

            set
            {
                maTacGia = value;
            }
        }

        public string TenTacGia
        {
            get
            {
                return tenTacGia;
            }

            set
            {
                tenTacGia = value;
            }
        }
    }
}
