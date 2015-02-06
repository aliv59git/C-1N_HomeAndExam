using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter 5 numbers, separated by space: ");
            string[] arr = Console.ReadLine().Split(' ');
            double[] numbers = new double[arr.Length];
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (numbers[i] = double.Parse(arr[i])); 
            }
            Console.WriteLine(sum);
        }
    }
}
