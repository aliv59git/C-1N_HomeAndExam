using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheBiggestOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter three numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggestNumb = double.MinValue;
        if (a > biggestNumb)
        {
            biggestNumb = a;
        }
        if (b > biggestNumb)
        {
            biggestNumb = b;
        }
        if (c > biggestNumb)
        {
            biggestNumb = c;
        }
        Console.WriteLine("The biggest number is: {0}", biggestNumb);
    }
}
