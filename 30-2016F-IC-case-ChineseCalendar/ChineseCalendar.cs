using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2016F_IC_case_ChineseCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What year were you born? (will only work for 1900 or later: ");
            int Year = int.Parse(Console.ReadLine());

            int ChangeYear = (Year - 1900) % 12;

            switch (ChangeYear)
            {
                case 0:
                    Console.WriteLine("You are a sneaky rat");
                    break;

                case 1:
                    Console.WriteLine("You are a Hardy OOx");
                    break;

                case 2:
                    Console.WriteLine("You are a Majestic Tiger");
                    break;

                case 3:
                    Console.WriteLine("You are an agile rabbit");
                    break;

                case 4:
                    Console.WriteLine("You are a powerful dragon");
                    break;

                case 5:
                    Console.WriteLine("You are a slithering snake");
                    break;

                case 6:
                    Console.WriteLine("You are a rapid horse");
                    break;

                case 7:
                    Console.WriteLine("You are a leaping goat");
                    break;

                case 8:
                    Console.WriteLine("You are a swinging monkey");
                    break;

                case 9:
                    Console.WriteLine("You are a morning rooster");
                    break;

                case 10:
                    Console.WriteLine("You are a barking dog");
                    break;

                case 11:
                   Console.WriteLine("You are a Healthy Pig");
                    break;

                default:
                    Console.WriteLine("Invalid Entry?");
                    break;
            }
        }
    }
}
