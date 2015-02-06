using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter intiger number: ");
        long n = long.Parse(Console.ReadLine());
        List<long> arr = new List<long>();

        while ((n / 2) != 0)
        {
            arr.Add(n % 2);
            n /= 2;
            if (n / 2 == 0)
            {
                arr.Add(n % 2);
            }
        }
        long[] array = new long[arr.Count];
        arr.Reverse();
        arr.CopyTo(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}
