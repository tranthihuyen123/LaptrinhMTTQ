using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat constructor");
        }
        public override void Talk()
        {
            Console.WriteLine("Cat talk");
        }
    }
}
