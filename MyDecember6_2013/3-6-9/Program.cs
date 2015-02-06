using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong r = 0;
            ulong result;

            switch (b)
            {
                case 3: r = (ulong)(a + c); break;
                case 6: r = (ulong)(a * c); break;
                case 9: r = (ulong) (a % c); break;
                default: Console.WriteLine("Invalid number"); break;
            }
            if (r % 3 == 0)
            {
                result = r / 3;
                Console.WriteLine(result);
            }
            else
            {
                result = r % 3;
                Console.WriteLine(result);
            }
            Console.WriteLine(r);

        }
    }
}
