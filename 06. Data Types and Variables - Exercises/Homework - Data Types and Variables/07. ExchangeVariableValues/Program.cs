using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVariable = int.Parse(Console.ReadLine());
            int secondVariable = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {firstVariable}\nb = {secondVariable}");

            int temp = firstVariable;
            firstVariable = secondVariable;
            secondVariable = temp;

            Console.WriteLine($"After:\na = {firstVariable}\nb = {secondVariable}");

        }
    }
}
