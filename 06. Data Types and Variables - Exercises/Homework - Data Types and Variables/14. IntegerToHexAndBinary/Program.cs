using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string inHex = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(inHex);
            
            string inDecimal = Convert.ToString(input, 2);
            Console.WriteLine(inDecimal);

        }
    }
}
