using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSpace = n - 2;
            int rightSpace = n - 2;
            int rightVert = n - 1 - 2;
            Console.Write(new string(':', n));
            Console.WriteLine(new string(' ', n-1));
            for (int i = 1; i < n-1; i++)
            {
                Console.Write(':');
                Console.Write(new string(' ', leftSpace));
                Console.Write(':');
                Console.Write(new string('|', i-1));
                Console.Write(':');
                Console.Write(new string(' ', rightSpace-i));
                Console.WriteLine();
            }
            Console.Write(new string(':', n));
            Console.Write(new string('|', n-2));
            Console.WriteLine(':');

            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(new string(' ',  i));
                Console.Write(':');
                Console.Write(new string('-', leftSpace));
                Console.Write(':');
                Console.Write(new string('|', n-2-i));
                Console.Write(':');
                Console.WriteLine();
            }
            Console.Write(new string(' ', n - 1));
            Console.WriteLine(new string(':', n));

        }
    }
}
