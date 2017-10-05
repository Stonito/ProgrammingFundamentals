using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            int result = MultiplyEvensByOdds(input);
            Console.WriteLine(result);
        }

        private static int MultiplyEvensByOdds(int input)
        {
            int sumEvens = GetSumOfEvens(input);
            int sumOdds = GetSumOfOdds(input);
            int result = sumEvens * sumOdds;
            return result;

        }

        private static int GetSumOfOdds(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int currentDigit = input % 10;
                if (currentDigit % 2 != 0)
                    sum += currentDigit;
                input = (input - currentDigit) / 10;
            }
            return sum;
        }

        private static int GetSumOfEvens(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int currentDigit = input % 10;
                if (currentDigit % 2 == 0)
                    sum += currentDigit;
                input = (input - currentDigit) / 10;
            }
            return sum;
        }
    }
}
