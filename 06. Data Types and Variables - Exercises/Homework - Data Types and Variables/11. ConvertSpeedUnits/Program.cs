using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours * 3600 + minutes * 60 + seconds;

            float metersPerSecond = meters / totalSeconds;
            Console.WriteLine(metersPerSecond);

            float kilometersPerHour = (meters / 1000) / (totalSeconds / 3600);
            Console.WriteLine(kilometersPerHour);

            float miles = meters / 1609;
            float milesPerHour = miles / (totalSeconds / 3600);
            Console.WriteLine(milesPerHour);
        }
    }
}
