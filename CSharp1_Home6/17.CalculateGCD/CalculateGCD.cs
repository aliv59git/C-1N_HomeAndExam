using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter two intiger numbers a!=0 and b!=0 : ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a * b == 0)
        {
            Console.WriteLine("Invalid number!");
        }
        string GreatestCommonDivisor = "GCD ("+a+", " + b +")";
        if (Math.Abs(a) < Math.Abs(b))
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        bool sign = false;
        if ((a < 0 && b > 0) || (a > 0 && b < 0))
        {
            sign = true;
        }
        int r;
        int gcd;
        while (true)
        {
            r = a % b;
            if (r == 0)
            {
                gcd = b;
                break;
            }
            a = b;
            b = r;
        }
        if (sign)
        {
            gcd = Math.Abs(gcd);
        }
        Console.WriteLine(GreatestCommonDivisor +" = " + gcd);
    }
}
