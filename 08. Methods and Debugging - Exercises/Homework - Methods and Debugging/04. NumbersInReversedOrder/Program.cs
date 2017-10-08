using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintInReversedOrder(number);
        }

        private static void PrintInReversedOrder(string number)
        {
            string reversedString = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedString += number[i];
            }

            Console.WriteLine(reversedString);
        }
    }
}
