using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfTriangle = double.Parse(Console.ReadLine());
            double heightOfTriangle = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(widthOfTriangle, heightOfTriangle);
            Console.WriteLine(triangleArea);

        }

        private static double GetTriangleArea(double widthOfTriangle, double heightOfTriangle)
        {
            return widthOfTriangle * heightOfTriangle / 2;
        }
    }
}
