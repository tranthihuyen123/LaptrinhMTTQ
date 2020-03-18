using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal objA = new Animal();
            Cat objC = new Cat();
            objA = objC; ;
            objA.Talk();
            Console.Read();
        }
    }
}
