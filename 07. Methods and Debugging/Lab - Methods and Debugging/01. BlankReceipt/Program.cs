using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.Write("\u00A9 ");
            Console.WriteLine("SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
