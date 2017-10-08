using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string currentNumberInString = i.ToString();
                if (IsPalindrome(currentNumberInString) && IsSumOfDigitsDivisibleBy7(i) && IsHoldingAtleastOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsHoldingAtleastOneEvenDigit(int number)
        { 
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                    return true;
                number /= 10;
            }
            return false;

        }

        private static bool IsSumOfDigitsDivisibleBy7(int number)
        {

            int sumOfDigits = 0;
            while (number >= 1)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 7 == 0)
                return true;
            else
                return false;

        }

        private static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - i - 1])
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
