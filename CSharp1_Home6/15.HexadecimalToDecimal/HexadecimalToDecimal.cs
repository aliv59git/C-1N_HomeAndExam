using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter hexadecimal intiger number:");
        string str = Console.ReadLine();
        long deciNumb = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if ((int)str[i] < 58 && (int)str[i]>47)
            {
                deciNumb += (long)(((int)str[i] - 48) * Math.Pow(16, (str.Length - i - 1)));
            }
            else if (((int)str[i] > 64) && (int)str[i] < 71)
            {
                deciNumb += (long)(((int)str[i] - 55) * Math.Pow(16, (str.Length - i - 1)));
            }
            else if (((int)str[i] > 96) && (int)str[i] < 103)
            {
                deciNumb += (long)(((int)str[i] - 87) * Math.Pow(16, (str.Length - i - 1)));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        Console.WriteLine(deciNumb);
    }
}
