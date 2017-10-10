using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int allElements = int.Parse(Console.ReadLine());
            int summedElements = int.Parse(Console.ReadLine());

            long[] arr = new long[allElements];
            arr[0] = 1;


            for (int i = 1; i < allElements; i++)
            {
                long sum = 0;

                for (int j = i - summedElements; j <= i - 1; j++)
                {
                    if (j < 0)
                        continue;
                    sum += arr[j];
                }
                arr[i] = sum;
            }

            for (int i = 0; i < allElements; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
