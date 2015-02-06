using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter coefficients of quadratic equation ax^2+bx+c: a = ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", -b/(2*a));
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots");
            }
            else
            {
                Console.WriteLine("x1 = {0} and x2 = {1}", (-b - Math.Sqrt(d)) / (2 * a), (-b + Math.Sqrt(d)) / (2 * a));
            }
        }
    }
}
