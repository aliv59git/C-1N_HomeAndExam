using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.EncodingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            BigInteger result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if ((int)letter == 64)
                {
                    Console.WriteLine(result);
                    return;
                }

                if (((int)letter <= 57) && ((int)letter > 47))
                {
                    result *= ((int)letter - 48);
                }
                if (((int)letter <= 90) && ((int)letter > 64))
                {
                    result += ((int)letter - 65);
                }
                if (((int)letter <= 122) && ((int)letter > 96))
                {
                    result += ((int)letter - 97);
                }
                if((int)letter<=47||((int)letter>57 && (int)letter<64)||((int)letter>90 &&(int)letter<=96)||(int)letter>122)
                {
                    result %= m;
                }


            }

        }
    }
}
