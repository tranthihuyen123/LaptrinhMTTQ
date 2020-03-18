using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, tong = 0, hieu, nhan, chia, kq;
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            nhan = a * b;
            
            Console.WriteLine("Tong cua " + a + " Va " + b + " La: " + tong);
            Console.WriteLine("Hieu cua " + a + " Va " + b + " La: " + hieu);
            Console.WriteLine("Tich cua " + a + " Va " + b + " La: " + nhan);
 
            Console.ReadLine();
        }
    }
}
