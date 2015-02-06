using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter intiger number n = ");
            int n = int.Parse(Console.ReadLine());
            string sign;
            if (n < 0)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            for (int i = 0; i < Math.Abs(n); i++)
            {
                Console.WriteLine(sign+(i+1));
            }
        }
    }
}
