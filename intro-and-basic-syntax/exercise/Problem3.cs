using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the console number of miles (parse to double)
            double miles = double.Parse(Console.ReadLine());
            
            // We calculate miles to kilometers (double)
            double answer = miles * 1.60934;
            
            // We print answer to the 2nd decimal place.
            Console.WriteLine($"{answer:f2}"); 
        }
    }
}
