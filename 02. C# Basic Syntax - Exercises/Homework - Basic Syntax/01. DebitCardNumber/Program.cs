using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.Write($"{firstNumber:D4} ");
            Console.Write($"{secondNumber:D4} ");
            Console.Write($"{thirdNumber:D4} ");
            Console.Write($"{fourthNumber:D4} ");
        }
    }
}
