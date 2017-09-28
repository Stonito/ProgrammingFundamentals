using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            if(firstNumber > lastNumber)
            {
                int j = firstNumber;
                firstNumber = lastNumber;
                lastNumber = j;
            }
                       

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
