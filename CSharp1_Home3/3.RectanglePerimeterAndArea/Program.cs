using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RectanglePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter rectangle's width: ");
            float recWidth = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter rectangle's height: ");
            float recHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter of your rectangle is: {0}", 2 * recWidth + 2 * recHeight);
            Console.WriteLine("And your rectangle has area: {0}", recWidth * recHeight);
        }
    }
}
