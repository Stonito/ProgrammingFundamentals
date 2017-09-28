using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(b-a<4)
                Console.WriteLine("No");
            else
            {
                for (int i = a; i <= b-4; i++)
                {
                    for (int j = a+1; j <= b-3; j++)
                    {
                        for (int k = a+2; k <= b-2; k++)
                        {
                            for (int l = a+3; l <= b-1; l++)
                            {
                                for (int o = a+4; o <= b; o++)
                                {
                                    if (i < j && j < k && k < l && l < o)
                                        Console.WriteLine($"{i} {j} {k} {l} {o}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
