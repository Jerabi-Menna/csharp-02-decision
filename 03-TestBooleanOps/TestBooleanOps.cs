﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TestBooleanOps
{
    class TestBooleanOps
    {
        static void Main(string[] args)
        {
            // Prompt for and read in an integer
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            // Display message if number is divisible by 2 and 3.
            if (num % 2 == 0 && num % 3 == 0)
            // && = and
            {
                Console.WriteLine($"{num} is divisible by 2 and 3.");
            }
            if (num % 2 == 0 || num % 3 == 0)
            // || is or
            {
                Console.WriteLine($"{num} is divisible by 2 OR 3.");
            }

            if (num % 2 == 0 ^ num % 3 == 0)
            // ^ is XOR
            {
                Console.WriteLine($"{num} is divisible by 2 XOR 3.");
            }
        }
    }
}
