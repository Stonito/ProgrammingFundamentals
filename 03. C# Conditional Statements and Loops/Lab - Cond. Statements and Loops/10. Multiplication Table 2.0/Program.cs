using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToMultiply = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberToMultiply} X {multiplier} = {numberToMultiply * multiplier}");

            int newMultiplier = multiplier + 1;

            for (int i = newMultiplier; i <= 10; i++)
            {
                Console.WriteLine($"{numberToMultiply} X {i} = {numberToMultiply * i}");
            }
        }
    }
}
