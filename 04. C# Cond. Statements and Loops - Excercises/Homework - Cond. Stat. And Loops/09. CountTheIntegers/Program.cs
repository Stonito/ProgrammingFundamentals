using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDigits = 0;

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine(numberOfDigits);
                    break;
                }
                numberOfDigits++;
            }
        }
    }
}
