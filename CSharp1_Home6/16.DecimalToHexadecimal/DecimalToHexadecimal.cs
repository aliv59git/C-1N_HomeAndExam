using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter intiger number: ");
        long n = long.Parse(Console.ReadLine());
        List<string> arr = new List<string>();

        while ((n / 16) != 0)
        {
            if (n % 16 < 10)
            {
                arr.Add((n % 16).ToString());
            }
            else if (n % 16 == 10)
            {
                arr.Add("A");
            }
            else if (n % 16 == 11)
            {
                arr.Add("B");
            }
            else if (n % 16 == 12)
            {
                arr.Add("C");
            }
            else if (n % 16 == 13)
            {
                arr.Add("D");
            }
            else if (n % 16 == 14)
            {
                arr.Add("E");
            }
            else if (n % 16 == 15)
            {
                arr.Add("F");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            n /= 16;
            if (n / 16 == 0)
            {
                if (n % 16 < 10)
                {
                    arr.Add((n % 16).ToString());
                }
                else if (n % 16 == 10)
                {
                    arr.Add("A");
                }
                else if (n % 16 == 11)
                {
                    arr.Add("B");
                }
                else if (n % 16 == 12)
                {
                    arr.Add("C");
                }
                else if (n % 16 == 13)
                {
                    arr.Add("D");
                }
                else if (n % 16 == 14)
                {
                    arr.Add("E");
                }
                else if (n % 16 == 15)
                {
                    arr.Add("F");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
        string[] array = new string[arr.Count];
        arr.Reverse();
        arr.CopyTo(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();

    }
}
