using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            KhachHang objKH = new KhachHang();
            Console.WriteLine("Ten KH: " + objKH.tenKH);
            Console.ReadLine();

            Square objSquare = new Square();
            objSquare.Side = 5;
            Console.WriteLine(" Gia tri cua mSide: " +objSquare.Side);
            Console.ReadLine();

            
          
          
        
        }
    }
}
