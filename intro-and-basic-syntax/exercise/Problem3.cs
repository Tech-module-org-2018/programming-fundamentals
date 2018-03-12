using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            // We receive from the console number of miles (parse to double)
            double miles = double.Parse(Console.ReadLine());
            
            // We calculate miles to kilometers (double), changed name answer to resultMiles
            double resultMiles = miles * 1.60934;
            
            // We print answer to the 2nd decimal place.
            Console.WriteLine($"{resultMiles:f2}"); 
        }
    }
}
