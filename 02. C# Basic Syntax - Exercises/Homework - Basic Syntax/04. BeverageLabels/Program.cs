using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double allEnergy = energyContent / 100 * volume;
            double allSugar = sugarContent / 100 * volume;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{allEnergy}kcal, {allSugar}g sugars");
        }
    }
}
