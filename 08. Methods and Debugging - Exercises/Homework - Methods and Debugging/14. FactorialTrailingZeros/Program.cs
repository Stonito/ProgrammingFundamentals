using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(input);
            int trailingZeros = CalculateTrailingZeros(factorial);
            Console.WriteLine(trailingZeros);
        }

        private static int CalculateTrailingZeros(BigInteger factorial)
        {
            int trailingZeros = 0;
            while (factorial >= 1)
            {
                if (factorial % 10 == 0)
                    trailingZeros++;
                else
                    return trailingZeros;
                factorial /= 10;
            }
            return trailingZeros;
        }

        private static BigInteger CalculateFactorial(int input)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
