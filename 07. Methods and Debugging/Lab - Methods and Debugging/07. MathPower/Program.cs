using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            int a = 2;
            double result = CalculatePower(number, power);
            Console.WriteLine(result);
        }

        private static double CalculatePower(double number, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
