using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = int.Parse(Console.ReadLine());
                if(n%2!=0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
                else
                    Console.WriteLine("Please write an odd number.");
            }
        }
    }
}
