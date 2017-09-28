using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall;
            double price = 0;

            if(peopleCount<=50)
            {
                hall = "Small Hall";
                price = 2500;

            }
            else if(peopleCount <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (peopleCount <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                price = 0.95 * price;
            }
            else if (package == "Gold")
            {
                price += 750;
                price = 0.90 * price;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price = 0.85 * price;
            }

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price/peopleCount:F2}$");
        }
    }
}
