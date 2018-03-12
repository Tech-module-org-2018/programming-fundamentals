using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           // We receive first integer from the console
            int n1 = int.Parse(Console.ReadLine());
         
          // We receive second integer from the console
            int n2 = int.Parse(Console.ReadLine());
         
          // We receive third integer from the console
            int n3 = int.Parse(Console.ReadLine());
         
          // We receive fourth integer from the console
            int n4 = int.Parse(Console.ReadLine());
         
          // We print debit card number in 4-digit format
            Console.WriteLine($"{n1:d4} {n2:d4} {n3:d4} {n4:d4}");
 
        }
    }
}
