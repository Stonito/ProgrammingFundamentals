using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 7)
                Console.WriteLine(daysOfWeek[input - 1]);
            else
                Console.WriteLine("Invalid Day!");
        }
    }
}
