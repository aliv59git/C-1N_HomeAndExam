using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrailinZerosInNFact
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter intiger number n");
        int n = int.Parse(Console.ReadLine());
        int trailingZeroes = 0;
        int k = 0;
        int numb = n;
        while (numb / 5 != 0)
        {
            k++;
            numb /= 5;
        }
        //Console.WriteLine(k);
        // 5^k < n < 5^(k+1)
        for (int i = 1; i <= k ; i++)
        {
            int divisor = 1;
            for (int j = 0; j < i; j++)
            {
                divisor *= 5;
            }
            trailingZeroes += (n / divisor);
        }
        Console.WriteLine("Trailing zeroes in n! = {0}", trailingZeroes);
    }
}
