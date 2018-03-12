//CONFIRMED from svetlozarned

using System;
using System.Text;
using System.Threading.Tasks;
 
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           // We receive first integer from the console
            int firstNum = int.Parse(Console.ReadLine());
         
          // We receive second integer from the console
            int secondNum = int.Parse(Console.ReadLine());
         
          // We receive third integer from the console
            int thirdNum = int.Parse(Console.ReadLine());
         
          // We receive fourth integer from the console
            int fourthNum = int.Parse(Console.ReadLine());
         
          // We print debit card number in 4-digit format
            Console.WriteLine($"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {fourthNum:d4}");
 
        }
    }
}
