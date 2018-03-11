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
            double width = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            double anwer = width * higth;

            Console.WriteLine($"{anwer:f2}");


        }
    }
}