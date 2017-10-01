using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i <= maxNumber; i++)
            {
                if (i / 10== 0)
                {
                    bool TrueOrFalse = i == 5 || i == 7;
                    Console.WriteLine($"{i} -> {TrueOrFalse}");
                }
                else
                {
                    int newI = i;
                    int sumOfDigits = 0;
                    while(newI!=0)
                    {
                        sumOfDigits += newI % 10;
                        newI /= 10;
                    }

                    bool TrueOrFalse = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                    Console.WriteLine($"{i} -> {TrueOrFalse}");

                }
            }
        }
    }
}
