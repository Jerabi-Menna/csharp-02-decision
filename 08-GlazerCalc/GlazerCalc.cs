using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GlazerCalc
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthString, heightString;

            Console.Write("Give the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n ");
                Console.WriteLine("Using minimum of 0.5");
                width = MIN_WIDTH;
            }

            else if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large.\n\n");
                Console.WriteLine("Using maximum of 5.0");
                width = MAX_WIDTH;
            }

            Console.Write("Give the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n");
                Console.WriteLine("Using minimum of .75");
                height = MIN_HEIGHT;
            }
            else if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n");
                Console.WriteLine("Using maximum of 3.0");
                height = MAX_HEIGHT;
            }

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");
        }
    }
}
