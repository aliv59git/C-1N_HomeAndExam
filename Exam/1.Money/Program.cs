using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal price = ((decimal)(n * s) / 400) * p;
            Console.WriteLine("{0:F3}", price);
        }
    }
}
