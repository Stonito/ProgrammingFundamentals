using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            ReverseArrayOfStrings(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ' ');
            }
        }

        private static void ReverseArrayOfStrings(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }
    }
}
