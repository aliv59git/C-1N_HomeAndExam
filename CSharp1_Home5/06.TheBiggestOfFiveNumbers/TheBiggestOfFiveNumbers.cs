using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter five numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double bigNumb = a;
        if (b > bigNumb)
        {
            bigNumb = b;
        }
        if (c > bigNumb)
        {
            bigNumb = c;
        }
        if (d > bigNumb)
        {
            bigNumb = d;
        }
        if (e > bigNumb)
        {
            bigNumb = e;
        }
        Console.WriteLine("The biggest number is: {0}", bigNumb);
    }
}
