﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle();
            objRectangle.Length = 3;
            objRectangle.Width = 4;
            objRectangle.CalArea();
            Console.WriteLine("Gia tri: " +objRectangle.Area);
            Console.ReadLine();
        }
        }
    }
