using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int turn = 0;

            while(peshoHealth>0 && goshoHealth>0)
            {
                turn++;
                if (turn % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if(turn%3==0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
