using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                    numberOfIngredients++;
                }
            }
        }
    }
}
