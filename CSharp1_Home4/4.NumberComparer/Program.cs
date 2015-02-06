using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter two numbers - a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("greater: {0}", a>b ? a : b); 
        }
    }
}
