using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            if (n < 0)
            {
                n = -n;
            }
            while (n != 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    evenSum += (int)(n % 10);
                }
                else 
                { 
                    oddSum += (int)(n % 10);
                }
                n /= 10;
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else
            {
                Console.WriteLine("straight {0}", evenSum);
            }
        }
    }
}
