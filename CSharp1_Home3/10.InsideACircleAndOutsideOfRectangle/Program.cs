using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.InsideACircleAndOutsideOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter coordinate x of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter coordinate y of a point: ");
            double y = double.Parse(Console.ReadLine());
            bool insideACircle = false;
            bool outsideOfARectangle = false;
            if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 1.5)
            {
                insideACircle = true;
            }
            float top = 1.0f;
            float left = -1.0f;
            float width = 6.0f;
            float height = 2.0f;
            if (!(x >= left && x <= left + width && y <= top && y >= top - height))
            {
                outsideOfARectangle = true;
            }
            Console.WriteLine("Is the Point inside a circle and ouside of a rectangle? {0}", insideACircle & outsideOfARectangle);
        }
    }
}
