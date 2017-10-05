using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesFahrenheit = double.Parse(Console.ReadLine());
            double degreesCelsium = FahrenheitToCelsium(degreesFahrenheit);
            Console.WriteLine($"{degreesCelsium:F2}");
        }

        private static double FahrenheitToCelsium(double degreesFahrenheit)
        {
            return (degreesFahrenheit - 32) * 5 / 9;
        }
    }
}
