using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter four-digit intiger number: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb / 1000 == 0)
            {
                Console.WriteLine("The number cannot start with zero");
            }
            int a = numb / 1000;
            int d = numb % 10;
            int c = (numb / 10) % 10;
            int b = (numb / 100) % 10;
            //Console.WriteLine("a = {0}, b = {1}, c = {2} and d = {3}", a, b, c, d);
            Console.WriteLine("Sum of digits of number is: {0}", a+b+c+d);
            Console.WriteLine("Number in reverse order of digits: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in first position: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchange of second and third digits: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
