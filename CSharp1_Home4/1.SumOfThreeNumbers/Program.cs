using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter real number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter real number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter real number c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum of entered numbers is: {0}", a+b+c);
        }
    }
}
