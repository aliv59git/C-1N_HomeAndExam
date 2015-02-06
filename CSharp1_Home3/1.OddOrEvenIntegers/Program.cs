using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter integer number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Your number is ODD.");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("Your number is EVEN.");
            }
            else
            {
                Console.WriteLine("You are entered wrong number!");
            }
        }
    }
}
