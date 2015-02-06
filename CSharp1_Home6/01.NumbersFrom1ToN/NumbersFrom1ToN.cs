using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter positive intiger number n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(i + 1+" ");
        }
        Console.WriteLine();
    }
}
