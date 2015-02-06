using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n + 1));
            Console.Write(new string('*', n - 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();
            int countLine = 1;
            int dots1 = n - 1;
            int k = 1;
            while (dots1 > 1)
            {
                Console.Write(new string('.', dots1));
                Console.Write('*');
                Console.Write(new string('.', n - 1 + 2 * k));
                Console.Write('*');
                Console.Write(new string('.', dots1));
                Console.WriteLine();
                k += 2;
                dots1 -= 2;
                countLine++;
            }
            for (int i = 0; i < n - 1 - countLine; i++)
            {
                Console.Write(".*");
                Console.Write(new string('.', 3 * n - 3));
                Console.Write("*.");
                Console.WriteLine();
            }
            Console.Write(".*");
            for (int i = 0; i < (3 * n - 4) / 2; i++)
            {
                Console.Write("@.");
            }
            Console.Write('@');
            Console.WriteLine("*.");
            Console.Write(".*");
            for (int i = 0; i < (3 * n - 4) / 2; i++)
            {
                Console.Write(".@");
            }
            Console.Write('.');
            Console.WriteLine("*.");

            for (int i = 0; i < n - 1 - countLine; i++)
            {
                Console.Write(".*");
                Console.Write(new string('.', 3 * n - 3));
                Console.Write("*.");
                Console.WriteLine();
            }
            dots1 += 2;
            while (dots1 < n)
            {
                Console.Write(new string('.', dots1));
                Console.Write('*');
                Console.Write(new string('.', 3 * n + 1 - 2 * (dots1 + 1)));
                Console.Write('*');
                Console.Write(new string('.', dots1));
                Console.WriteLine();
                dots1 += 2;
            }

            Console.Write(new string('.', n + 1));
            Console.Write(new string('*', n - 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();

        }
    }
}
