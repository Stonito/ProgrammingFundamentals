using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());

            

            switch (proffession)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {broi * 0.7:F2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {broi * 1:F2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {broi * 1:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {broi * 1.7:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffession} has to pay {broi*1.2:F2}.");
                    break;
            }
        }
    }
}
