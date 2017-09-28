using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input >= 3.00)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("Failed!");
        }
    }
}
