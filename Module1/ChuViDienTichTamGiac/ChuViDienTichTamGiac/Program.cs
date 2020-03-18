using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float p = 0;
            double s = 0;
            Console.WriteLine("***CHU VI DIEN TICH TAM GIAC***");

            Console.Write("Nhap canh a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = float.Parse(Console.ReadLine());
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                p = a + b + c;
                Console.WriteLine("Chu vi cua tam giac la: " + p);
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Dien tich cua tam giac la: " + s);

            }
            else
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
            Console.ReadLine();
        }
    }
}
    
