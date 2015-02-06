using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersDividableByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two positive intiger numbers: ");
            int start = int.Parse(Console.ReadLine());
            int divisor = 5;
            int p = 0;
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if(i % divisor == 0)
                {
                    Console.Write("{0}, ", i);
                    p += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} numbers, between {1} and {2}, that the reminder of the division by {3} is 0.", p, start, end, divisor);
        }
    }
}
