using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenFigure = Console.ReadLine();

            CalculateArea(chosenFigure);
        }

        private static void CalculateArea(string chosenFigure)
        {
            switch(chosenFigure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * height / 2:F2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{squareSide * squareSide:F2}");
                    break;
                case "rectangle":
                    double aSide = double.Parse(Console.ReadLine());
                    double bSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{aSide * bSide:F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI * radius * radius:F2}");
                    break;

            }
        }
    }
}
