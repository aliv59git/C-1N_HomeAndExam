using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AmericanPie
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong d = ulong.Parse(Console.ReadLine());
            ulong completePies = (a * d + b * c) / (b * d);
            if (completePies > 0)
            {
                Console.WriteLine(completePies);
            }
            else
            {
                Console.WriteLine("{0:F20}", ((decimal)a * (decimal)d + (decimal)b * (decimal)c) / ((decimal)b * (decimal)d));
            }
            Console.WriteLine("{0}/{1}", a*d+b*c, b*d);


        }
    }
}
