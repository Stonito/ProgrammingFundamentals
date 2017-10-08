using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double maxx1 = x1;
            double maxy1 = y1;
            double maxx2 = x2;
            double maxy2 = y2;

            double firstLine = CalculateLine(x1, y1, x2, y2);

            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double secondLine = CalculateLine(x1, y1, x2, y2);

            if (secondLine > firstLine)
            {
                maxx1 = x1;
                maxy1 = y1;
                maxx2 = x2;
                maxy2 = y2;
            }

            PrintCoordinatesOfCloserPoint(maxx1, maxy1, maxx2, maxy2);
        }

        private static double CalculateLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        private static void PrintCoordinatesOfCloserPoint(double x1, double y1, double x2, double y2)
        {
            if (x1 * x1 + y1 * y1 > x2 * x2 + y2 * y2)
            {
                double tempX = x1;
                double tempY = y1;
                x1 = x2;
                y1 = y2;
                x2 = tempX;
                y2 = tempY;
            }
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }

    }
}
