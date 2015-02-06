using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter radius r = ");
            string rad = Console.ReadLine();
            double radius;
            if (double.TryParse(rad, out radius))
            {
                if (radius < 0)
                {
                    Console.WriteLine("Invalid number: {0}", rad);
                }
                else
                {
                    Console.WriteLine("Perimeter is: {0:0.00} and area is: {1:F2}", 2 * Math.PI * radius, Math.PI * radius * radius);
                }
            }
            else
            {
                Console.WriteLine("Invalid number: {0}", rad);
            }
        }
    }
}
