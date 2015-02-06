using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter x coordinate of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter y coordinate of a point: ");
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < 2.0)
            {
                Console.WriteLine(true + ", the point is inside");
            }
            else 
            { 
                Console.WriteLine(false + ", the point is outside");
            }

        }
    }
}
