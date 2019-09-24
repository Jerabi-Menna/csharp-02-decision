using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tax_Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = .05, total= 0;

            Console.Write("what is the total sales before tax?: ");
            double sales = double.Parse(Console.ReadLine());

            Console.Write("what is the province you live in?:");
            string province = Console.ReadLine();

            switch(province)
                {
                case "AB":
                    tax = .05 * sales;
                    total = sales + tax;
                    break;
                
                case "BC":
                    tax = .12 * sales;
                    total = sales + tax;
                    break;
                
                case "SK":
                    tax = .11 * sales;
                    total = sales + tax;
                    break;
                
                case "MB":
                    tax = .13 * sales;
                    total = sales + tax;
                    break;

                case "ON":
                    tax = .13 * sales;
                    total = sales + tax;
                    break;

                case "QC":
                    tax = .14975 * sales;
                    total = sales + tax;
                    break;

                case "NL":
                    tax = .15 * sales;
                    total = sales + tax;
                    break;

                case "NB":
                    tax = .15 * sales;
                    total = sales + tax;
                    break;

                case "NS":
                    tax = .15 * sales;
                    total = sales + tax;
                    break;
                case "PE":
                    tax = .15 * sales;
                    total = sales + tax;
                    break;
                case "YT":
                    tax = .05 * sales;
                    total = sales + tax;
                    break;
                case "NT":
                    tax = .05 * sales;
                    total = sales + tax;
                    break;
                case "NU":
                    tax = .05 * sales;
                    total = sales + tax;
                    break;
                default:
                    Console.WriteLine("\nInvalid province, using default of 5% total taxes");
                    tax = .05 * sales;
                    total = sales + tax;
                    break;
                }
            Console.WriteLine($"\nyour total was {total:c}, your tax was {tax:c}, and your purchase total was {sales:c}");
        }
    }
}
