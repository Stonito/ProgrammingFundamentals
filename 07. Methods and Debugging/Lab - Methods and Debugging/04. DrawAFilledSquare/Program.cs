using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeadRow(n);
            PrintMiddleRow(n);
            PrintHeadRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write('-');
                Console.WriteLine();
            }
        }

        private static void PrintHeadRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
