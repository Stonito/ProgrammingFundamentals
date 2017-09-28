using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int caloriesTotal = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch(ingredient)
                {
                    case "cheese":
                        caloriesTotal += 500;
                        break;
                    case "tomato sauce":
                        caloriesTotal += 150;
                        break;
                    case "salami":
                        caloriesTotal += 600;
                        break;
                    case "pepper":
                        caloriesTotal += 50;
                        break;
                    default:
                        break;

                }

            }

            Console.WriteLine($"Total calories: {caloriesTotal}");
        }
    }
}
