﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_SwitchDemo
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1, 2, or 3: ");
            int num = int.Parse(Console.ReadLine());

            // else if to solve the number entered (requires program to read over all the else)
            if (num==1)
                Console.WriteLine("ONE ONE ONE");
            else if (num == 2)
                Console.WriteLine("Two Two Two.");
            else if (num==3)
                Console.WriteLine("That's a THREE baby!!!");
            else
                Console.WriteLine("Way to mess it all up budday.");

            // Determine the number entered. (jumps all the else straight to the case needed)
            switch (num)
            {
                case 1:
                    Console.WriteLine("ONE ONE ONE");
                    break;

                case 2:
                    Console.WriteLine("Two Two Two.");
                    break;

                case 3:
                    Console.WriteLine("That's a THREE baby!!!");
                    break;

                default:
                    Console.WriteLine("Way to mess it all up budday.");
                    break;
            }
        }
    }
}
