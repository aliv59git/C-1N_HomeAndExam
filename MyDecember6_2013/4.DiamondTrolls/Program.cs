using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots1 = (n+1)/2;
            int dots2 = n / 2;
            Console.Write(new string('.', (n+1)/2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', (n + 1) / 2));
            dots1--;
            while (dots1 > 0)
            {
                Console.Write(new string('.', dots1));
                Console.Write("*");
                Console.Write(new string('.', dots2));
                Console.Write("*");
                Console.Write(new string('.', dots2));
                Console.Write("*");
                Console.WriteLine(new string('.', dots1));
                dots1--;
                dots2++;
            }
            Console.WriteLine(new string('*', 2 * n + 1));
            dots2 = n - 2;
            dots1 = 1;
            while (dots2 >= 0)
            {
                Console.Write(new string('.', dots1));
                Console.Write("*");
                Console.Write(new string('.', dots2));
                Console.Write("*");
                Console.Write(new string('.', dots2));
                Console.Write("*");
                Console.WriteLine(new string('.', dots1));
                dots1++;
                dots2--;
            }
            Console.Write(new string('.', dots1));
            Console.Write("*");
            Console.WriteLine(new string('.', dots1));
        }
    }
}
