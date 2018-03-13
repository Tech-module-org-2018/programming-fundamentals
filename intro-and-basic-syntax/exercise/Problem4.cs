//CONFIRMES FROM MitkoGeorgievGeorgiev
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            //Read name from Console
            string name = Console.ReadLine();

            //Read all ingredients
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            //Calculate total energy and total shugar
            double totalEnergy = (volume * energyContent) / 100.00;
            double totalSugar = (volume * sugarContent) / 100.00;

            //Print the result
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
 
        }
    }
}