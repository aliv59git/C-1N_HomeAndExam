using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomizeNumbers1ToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter positive intiger number n");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            bool success = true;
            while (success)
            {
                int randNumb = rand.Next(0, n);
                if (arr[randNumb] == 0)
                {
                    arr[randNumb] = (i + 1);
                    success = false;
                }
            }

        }
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0} ", arr[j]);
        }
        Console.WriteLine();
    }
}
