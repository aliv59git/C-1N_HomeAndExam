using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter two numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
