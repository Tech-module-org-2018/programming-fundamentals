using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding width
            double sideA = double.Parse(Console.ReadLine());

            //adding height
            double sideB = double.Parse(Console.ReadLine());

            //adding result
            double rectangleArea = sideA * sideB;

            //output result
            Console.WriteLine($"{rectangleArea:f2}");


        }
    }
}
