using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int chieudai, chieurong, chuvi, dientich;
            Console.Clear();
            Console.Write("Nhap vao chieu dai: ");
            chieudai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            chieurong = Convert.ToInt32(Console.ReadLine());
            chuvi = (chieudai + chieurong)*2;
            dientich = chieurong * chieudai;
            Console.WriteLine("Chu vi= " + chuvi);
            Console.WriteLine("Dien tich= " + dientich);
            Console.ReadLine();

        }
    }
}
