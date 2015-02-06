using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortNumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter three real numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}

