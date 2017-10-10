using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumArrLength = GetMaxLength(arr1.Length, arr2.Length);
            int[] sumArr = new int[sumArrLength];



            for (int i = 0; i < sumArrLength; i++)
            {
                int arrLength1 = i % arr1.Length;
                int arrLength2 = i % arr2.Length;
                sumArr[i] = arr1[arrLength1] + arr2[arrLength2];
            }

            for (int i = 0; i < sumArrLength; i++)
            {
                Console.Write($"{sumArr[i]} ");
            }
        }

        private static int GetMaxLength(int length1, int length2)
        {
            if (length1 > length2)
                return length1;
            return length2;
        }
    }
}
