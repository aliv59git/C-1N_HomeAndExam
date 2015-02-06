using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter number n and after that more n numbers, separated by space:");
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            double sum = 0;
            for (int i = 1; i < str.Length; i++)
            {
                sum += double.Parse(str[i]);
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
