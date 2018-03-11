using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double totalEnergy = (volume * energy) / 100.00;
            double totalSugar = (volume * sugar) / 100.00;
 
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
 
        }
    }
}