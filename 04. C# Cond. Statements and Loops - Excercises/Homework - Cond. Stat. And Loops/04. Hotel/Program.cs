using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            double discountStudio = 1;
            double discountDouble = 1;
            double discountSuite = 1;
            int newNightsCount = nightsCount;

            if ((month == "September" || month == "October") && nightsCount > 7)
                newNightsCount--;

            if(month=="May"||month=="October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7)
                    discountStudio = 0.95;
            }
            else if (month == "June"|| month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                    discountDouble = 0.9;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCount > 14)
                    discountSuite = 0.85;
            }

            Console.WriteLine($"Studio: {(newNightsCount * studioPrice) * discountStudio:F2} lv.");
            Console.WriteLine($"Double: {(nightsCount * doublePrice) * discountDouble:F2} lv.");
            Console.WriteLine($"Suite: {(nightsCount * suitePrice) * discountSuite:F2} lv.");


        }
    }
}
