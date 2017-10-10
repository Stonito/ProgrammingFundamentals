using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] newArr = arr;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int[] condensedArr = new int[arr.Length - i - 1];
                for (int j = 0; j < condensedArr.Length; j++)
                {
                    condensedArr[j] = newArr[j] + newArr[j + 1];
                }
                newArr = condensedArr;
            }

            int result = newArr[0];
            Console.WriteLine(result);
        }
    }
}
