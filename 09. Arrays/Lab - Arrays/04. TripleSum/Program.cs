using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool flag = false;
            

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] == arr[i] + arr[j])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                            flag = true;
                            break;
                        }
                    }
                }
            }

            if(!flag)
                Console.WriteLine("No");

        }
    }
}
