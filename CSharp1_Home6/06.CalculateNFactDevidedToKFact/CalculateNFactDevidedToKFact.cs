using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateNFactDevidedToKFact
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter two intiger numbers n and k (1 < k < n < 100)");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int division = 1;
        if (!((k >= n) || (k < 1) || (n >= 100))) 
        {
            while (n > k)
            {
                division *= n;
                n--;
            }
            Console.WriteLine(division);
        }
        else
        {
            Console.WriteLine("Invalid numbers!");
        }

    }
}
