using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int numberCount = int.Parse(Console.ReadLine());

            const char search = 'p';
            bool hasMatch = false;

            int a = 5;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;

                    int endIndex = numberCount;

                    if (endIndex >= text.Length - i)
                    {
                        endIndex = text.Length - i - 1;
                    }
                    string matchedString = text.Substring(i, endIndex + 1);
                    Console.WriteLine(matchedString);
                    i += numberCount;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
