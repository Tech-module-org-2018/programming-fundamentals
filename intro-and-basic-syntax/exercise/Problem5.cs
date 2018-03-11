using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());
            int healthLeft = healthMax - health;
            int energyLeft = energyMax - energy;

            Console.WriteLine($"Name: {name}");

            Console.Write($"Health: ");
            Console.Write("|");
            Console.Write(new string('|', health));
            Console.Write(new string('.', healthLeft));
            Console.WriteLine("|");

            Console.Write($"Energy: ");
            Console.Write("|");
            Console.Write(new string('|', energy));
            Console.Write(new string('.', energyLeft));
            Console.WriteLine("|");



        }
    }
}