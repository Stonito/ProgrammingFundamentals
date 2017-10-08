using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggerNumber = GetMax(firstNumber, secondNumber);
            biggerNumber = GetMax(biggerNumber, thirdNumber);
            Console.WriteLine(biggerNumber);

        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }
    }
}
