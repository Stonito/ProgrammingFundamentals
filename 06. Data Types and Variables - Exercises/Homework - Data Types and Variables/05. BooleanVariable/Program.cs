using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool trueOrFalse = Convert.ToBoolean(input);

            if(trueOrFalse)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
