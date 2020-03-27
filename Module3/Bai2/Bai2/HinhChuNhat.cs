using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HinhChuNhat
    {
        private static double cd, cr;
        public static double ChieuDai
        {
            get { return cd; }
            set { cd = value; }
        }
        public static double ChieuRong
        {
            get { return cr; }
            set { cr = value; }
        }
        public static bool KiemTraHinhChuNhat()
        {
            if(cd<=cr)
            {
                return false;
            }
            return true;
        }
        public static double TinhDienTich()
        {
            return (cd * cr);
        }
    }
}
