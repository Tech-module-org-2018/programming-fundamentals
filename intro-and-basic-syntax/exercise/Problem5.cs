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
            //Defining name of the input params
            string characterName = Console.ReadLine();
            int characterHealth = int.Parse(Console.ReadLine());
            int characterHealthMax = int.Parse(Console.ReadLine());
            int characterEnergy = int.Parse(Console.ReadLine());
            int characterEnergyMax = int.Parse(Console.ReadLine());

            //Calculating health and energy
            int characterHealthLeft = characterHealthMax - characterHealth;
            int characterEnergyLeft = characterEnergyMax - characterEnergy;

            //Getting the final outputs
            Console.WriteLine($"Name: {characterName}");

            Console.Write($"Health: ");
            Console.Write("|");
            Console.Write(new string('|', characterHealth));
            Console.Write(new string('.', characterHealthLeft));
            Console.WriteLine("|");

            Console.Write($"Energy: ");
            Console.Write("|");
            Console.Write(new string('|', characterEnergy));
            Console.Write(new string('.', characterEnergyLeft));
            Console.WriteLine("|");



        }
    }
}