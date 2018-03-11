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
            double width = double.Parse(Console.ReadLine());

	    //adding height
            double higth = double.Parse(Console.ReadLine());

	    //adding result
            double anwer = width * higth;
		
            //output result
            Console.WriteLine($"{anwer:f2}");


        }
    }
}