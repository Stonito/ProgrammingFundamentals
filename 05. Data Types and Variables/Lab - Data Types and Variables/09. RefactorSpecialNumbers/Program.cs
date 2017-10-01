using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int  maxNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNumber; i++)
            {

                int currentNumber = i;
                int sumOfDigits = 0;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                bool TrueOrFalse = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine("{0} -> {1}", currentNumber, TrueOrFalse);
                i = currentNumber;
            }
        }
    }
}
