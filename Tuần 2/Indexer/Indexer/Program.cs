﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerClass b = new IndexerClass();
            b[3] = 256;
            b[5] = 1024;
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i, b[1]);
                Console.ReadLine();
            }
        }
    }
}
