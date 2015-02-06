using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateBinomCoefficients
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter two intiger numbers n and k (1 < k < n < 100)");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int binomCoefficient = 1;
        int numb = 1;
        int difference = n - k;
        if (!((k < 1) || (k >= n) || (n >= 100)))
        {
            if (difference > k)
            {
                difference = k + difference;
                k = difference - k;
                difference = difference - k;
            }
            while (n > k)
            {
                binomCoefficient *= n;
                n--;
            }
            while (difference > 0)
            {
                numb *= difference;
                difference--;
            }
            Console.WriteLine("The binom coefficient n!/k!(n-k)! = {0}", binomCoefficient/numb);
        }
        else
        {
            Console.WriteLine("Invalid numbers!");
        }
    }
}
