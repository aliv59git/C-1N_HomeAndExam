using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger number to check if it is prime: ");
            int n = int.Parse(Console.ReadLine());
            int maxDevider = (int)Math.Floor(Math.Sqrt(n));
            //Console.WriteLine(maxDevider);
            bool isPrime = true;
            for (int i = 2; i <= maxDevider; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("Is Prime: {0}", isPrime);
        }
    }
}
