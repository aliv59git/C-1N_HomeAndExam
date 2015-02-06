using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -18;
            int b = 3;
            Console.WriteLine("Values of variable are: a = {0} and b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After exchange values of variable are:  a = {0} and b = {1}", a, b);
        }
    }
}
