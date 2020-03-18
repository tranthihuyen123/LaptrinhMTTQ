using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, ketqua;
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 1***");
            Console.Write("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            else
            {
                ketqua = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x= " + ketqua);
            }
            Console.ReadLine();
        }
    }
}
