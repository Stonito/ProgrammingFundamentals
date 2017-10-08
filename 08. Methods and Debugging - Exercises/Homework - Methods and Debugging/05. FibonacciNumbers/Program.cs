using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            b = FindNthFibonacciNumber(a, b, fibonacciNumber);
            Console.WriteLine(b);
        }

        private static int FindNthFibonacciNumber(int a, int b, int fibonacciNumber)
        {
            for (int i = 1; i < fibonacciNumber; i++)
            {
                int next = a + b;
                a = b;
                b = next;
            }
            return b;
        }
    }
}
