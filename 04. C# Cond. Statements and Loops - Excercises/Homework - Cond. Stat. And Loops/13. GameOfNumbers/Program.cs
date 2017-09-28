using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int totalCombinations = 0;
            int lastI = 0;
            int lastJ = 0;

            int constantN = n;
            int constantM = m;

            if(n>m)
            {
                int k = n;
                m = n;
                n = k;
            }

            for (int i = constantN; i <= constantM; i++)
            {
                for (int j = constantM; j >= constantN; j--)
                {
                    if (i + j == magicalNumber)
                    {
                        lastI = i;
                        lastJ = j;
                    }
                    totalCombinations++;
                }
            }

            if(lastI!=0)
                Console.WriteLine($"Number found! {lastI} + {lastJ} = {magicalNumber}");
            else
                Console.WriteLine($"{totalCombinations} combinations - neither equals {magicalNumber}");
        } 
    }
}
