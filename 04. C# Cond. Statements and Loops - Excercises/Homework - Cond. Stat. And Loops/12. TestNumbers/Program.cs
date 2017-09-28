using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoudary = int.Parse(Console.ReadLine());

            int sum = 0;
            int totalCombinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += 3 * (i * j);
                    totalCombinations++;
                    if (sum>=maxSumBoudary)
                    {
                        Console.WriteLine($"{totalCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoudary}");
                        return;
                    }
                    

                }
            }

            Console.WriteLine($"{totalCombinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
