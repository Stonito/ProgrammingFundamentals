using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintPrimesInGivenRange(start, end);
        }
        private static void PrintPrimesInGivenRange(int start, int end)
        {
            bool flag = true;
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && flag)
                {
                    Console.Write($"{i}");
                    flag = false;
                }
                else if (isPrime)
                {
                    Console.Write($", {i}");
                }
            }
        }
    }
}
