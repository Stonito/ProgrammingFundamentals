using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string chosenCharacteristic = Console.ReadLine();

            CalculateCharacteristic(sideOfCube, chosenCharacteristic);
        }

        private static void CalculateCharacteristic(double sideOfCube, string chosenCharacteristic)
        {
            switch(chosenCharacteristic)
            {
                case "face":
                    Console.WriteLine($"{Math.Sqrt(sideOfCube * sideOfCube + sideOfCube * sideOfCube):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Sqrt(3 * sideOfCube * sideOfCube):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{sideOfCube * sideOfCube * sideOfCube:F2}");
                    break;
                case "area":
                    Console.WriteLine($"{sideOfCube * sideOfCube * 6:F2}");
                    break;
                default:
                    break;
            }
        }
    }
}
