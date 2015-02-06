using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersNotDivisibleBy3And7
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter positive number n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 7 == 0 || (i + 1) % 3 == 0)
            {
                continue;
            }
            Console.Write(i + 1 + " ");
        }
        Console.WriteLine();
    }
}
