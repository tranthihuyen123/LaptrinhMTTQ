using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class KhachHang
    {
        //thuoc tinh
        public string maKH;
        public string tenKH;

        //static
        private static string diachi;

        //phuong thuc
        public void InThongTinKH()
        {

        }
        public void InThongTinKH(String tenKH)
        {

        }
        public void InThongTinKH(int id)
        {

        }
        public KhachHang()
        {
            this.maKH = "0";
            this.tenKH = "ABC";
        }

        public KhachHang(string maKH, string tenKH)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
        }
    }
}
