using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storm_level
{
    class Program
    {
        static void Main()
        {
            Console.Write("what is the Wind speed of the storm in MPH as an integer?: ");
            int WindSpeed = int.Parse(Console.ReadLine());

            if (WindSpeed <= 74)
                Console.WriteLine("There is no Storm all is safe");
            else if (WindSpeed >= 75 && WindSpeed <= 95)
                Console.WriteLine("this is considered a Category 1 Storm");
            else if (WindSpeed >= 95 && WindSpeed <= 110)
                Console.WriteLine("this is considered a Category 2 Storm");
            else if (WindSpeed >= 110 && WindSpeed <= 130)
                Console.WriteLine("this is considered a Category 3 Storm");
            else if (WindSpeed >= 130 && WindSpeed <= 155)
                Console.WriteLine("this is considered a Category 4 Storm");
            else
                Console.WriteLine("this is considered a Category 5 Storm");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
