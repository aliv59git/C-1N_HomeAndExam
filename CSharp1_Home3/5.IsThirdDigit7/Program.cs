using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IsThirdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter intiger number: ");
            int n = int.Parse(Console.ReadLine());
            if ((Math.Abs(n) % 1000) / 100 == 7)
            {
            Console.WriteLine("Third digit 7? "+ true);
            }
            else
            {
                Console.WriteLine("Third digit 7? " + false);
            }
        }
    }
}
