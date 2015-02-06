using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter side a of trapezoid: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter height h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trqapezoid's area is: {0}", ((a + b) / 2) * h);
        }
    }
}
