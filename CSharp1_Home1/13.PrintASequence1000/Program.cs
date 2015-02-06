using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintASequence1000
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+2+"  ");
                }
                else
                {
                    Console.Write(-(i+2)+"  ");
                }
            }
            Console.WriteLine();
        }
    }
}
