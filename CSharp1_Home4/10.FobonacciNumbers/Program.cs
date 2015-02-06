using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FobonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter positive intiger number n: ");
            int n = int.Parse(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            int f = 1;
            for (int i = 1; i <n; i++)
            {
                if (i < 2)
                {
                    Console.Write("0, 1, ");
                }
                else if (i < n-1)
                {
                    Console.Write("{0}, ", f);
                    f = f1 + f2;
                    f1 = f2;
                    f2 = f;
                }
                else
                {
                    Console.WriteLine(f);
                }
            }
        }
    }
}
