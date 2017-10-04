using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CompatingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if (Math.Abs(firstNumber - secondNumber) >= eps)
                Console.WriteLine("False");
            else if (Math.Abs(firstNumber - secondNumber) < eps)
                Console.WriteLine("True");
        }
    }
}
