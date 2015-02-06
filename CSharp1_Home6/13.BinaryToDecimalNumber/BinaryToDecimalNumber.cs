using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter binary intiger number");
        string str = Console.ReadLine();
        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            arr[i] = ch-48;
        }

        long deciNumber = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            deciNumber += (long)(arr[i] * Math.Pow(2, (arr.Length - 1 - i)));
        }
        Console.WriteLine(deciNumber);
    }
}
