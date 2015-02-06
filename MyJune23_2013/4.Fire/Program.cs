using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n / 2 - 1));
            Console.Write("##");
            Console.WriteLine(new string('.', n / 2 - 1));
            int dots1 = n / 2 - 1;
            for (int i = dots1-1; i >=0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write("#");
                Console.Write(new string('.', 2*(n/2-1-i)));
                Console.Write("#");
                Console.WriteLine(new string('.', i));
            }
            for (int i = 0; i < n/4; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("#");
                Console.Write(new string('.', 2*(n/2-1-i)));
                Console.Write("#");
                Console.WriteLine(new string('.', i));
            }
            Console.WriteLine(new string('-', n));
            for (int j = 0; j < n/2; j++)
            {
                Console.Write(new string('.', j));
                Console.Write("\\");
                Console.Write(new string('\\', n/2-1-j));
                Console.Write(new string('/', n/2-1-j));
                Console.Write("/");
                Console.WriteLine(new string('.', j));
            }


        }
    }
}
