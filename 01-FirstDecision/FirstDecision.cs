using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstDecision
{
    class FirstDecision
    {
        static void Main(string[] args)
        {
            Console.Write($"Please enter any value: ");
            double myDouble = double.Parse(Console.ReadLine());
            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            if (myDouble > 4.0)
                Console.WriteLine($"The number is > 4");
            if (myDouble < 3.0)
                Console.WriteLine($"The number is < 3");

            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            else
                Console.WriteLine($"The number is < 3");

            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            else if (myDouble < 2.0)
                Console.WriteLine($"The number is < 2");
            else if (myDouble is 3)
                Console.WriteLine($"the number is 3");
            else
                Console.WriteLine($"the number is less than 2 but greater than 3");
        }
    }
}
