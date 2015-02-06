using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter positive intiger number 1 < n < 100");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNumber = 1;
        BigInteger divisor = 1;
        for (int k = 2; k <=n; k++)
        {
            catalanNumber *= (n + k);
            divisor *= k;
            int maxDivider = (int)(Math.Sqrt(k));
            for (int j = 2; j <= maxDivider; j++)
            {
                if ((catalanNumber % j == 0) && (divisor % j == 0))
                {
                    catalanNumber /= j;
                    divisor /= j;
                }
            }
        }
        catalanNumber = catalanNumber/divisor;
        Console.WriteLine(catalanNumber);
    }
}
