using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Plese, enter three intiger numbers: n, min and max (min <= max)");
        int n = int.Parse(Console.ReadLine());
        int minValue = int.Parse(Console.ReadLine());
        int maxValue = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", rnd.Next(minValue, maxValue+1));
        }
        Console.WriteLine();
    }
}
