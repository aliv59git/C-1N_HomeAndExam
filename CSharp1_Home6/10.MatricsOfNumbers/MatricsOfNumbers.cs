using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatricsOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter intiger number 1 <= n <= 20");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i + j + " ");
            }
            Console.WriteLine();
        }
    }
}
