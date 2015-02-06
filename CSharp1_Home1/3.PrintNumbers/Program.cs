using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(a);
                if (i != 0)
                {
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(0);
                    }
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
