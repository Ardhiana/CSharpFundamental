﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("its Afternoon");
            }
            else
            {
                Console.WriteLine("Its Evening.");
            }
        
        }
    }
}
