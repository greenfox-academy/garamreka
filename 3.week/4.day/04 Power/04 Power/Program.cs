﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(PowerN(3, 4));
            Console.ReadLine();
        }
        public static int PowerN (int n, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return n * (PowerN(n, power - 1));
            }
        }
    }
}
