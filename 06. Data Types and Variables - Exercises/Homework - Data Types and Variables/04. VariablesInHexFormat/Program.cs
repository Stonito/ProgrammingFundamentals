using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariablesInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int inDecimal = Convert.ToInt32(input, 16);

            Console.WriteLine(inDecimal);
        }
    }
}
