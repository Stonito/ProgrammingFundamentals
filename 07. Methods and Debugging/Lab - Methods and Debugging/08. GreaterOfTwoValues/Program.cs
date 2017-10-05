using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch(type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    int max = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char biggerChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(biggerChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string biggerString = GetMax(firstString, secondString);
                    Console.WriteLine(biggerString);
                    break;
            }

        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else
                return secondNumber;

        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
                return firstChar;
            else
                return secondChar;

        }

        private static string GetMax(string firstString, string secondString)
        {
            int a = string.Compare(firstString, secondString);
            if (a < 0)
                return secondString;
            else
                return firstString;
        }
    }
}
