using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this program is for often repeated code to copy and paste
namespace Code_Snippets
{
    class Program
    {
        static void Main(string[] args)
        {
            //stop console from exiting automatically
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

            //write and read
            Console.WriteLine("");
            Console.ReadLine();

            //write and read with a parsed double
            Console.WriteLine("");
            double.Parse(Console.ReadLine());
        }
    }
}
