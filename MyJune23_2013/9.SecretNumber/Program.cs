using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.SecretsOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = -n;
            }
            BigInteger temp = n;
            BigInteger specialSum = 0;
            BigInteger count = 1;
            while (temp > 0)
            {
                if (count % 2 == 1)
                {
                    BigInteger numb = temp % 10;
                    specialSum += numb * count * count;
                    temp /= 10;
                    count++;
                }
                if (count % 2 == 0)
                {
                    BigInteger numb = temp % 10;
                    specialSum += numb * numb * count;
                    temp /= 10;
                    count++;
                }
            }
            BigInteger lengthOfAlphaSequence = specialSum % 10;
            if (lengthOfAlphaSequence == 0)
            {
                Console.WriteLine(specialSum);
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            else
            {
                BigInteger r = specialSum % 26;
                char firstLetter = (char)(64 + r + 1);
                string result = "" + firstLetter;
                int number = (int)(65 + r);
                for (int i = 1; i < lengthOfAlphaSequence; i++)
                {
                    number++;
                    if (number > 90)
                    {
                        number = 65;
                    }
                    result += (char)(number);
                }
                Console.WriteLine(specialSum);
                Console.WriteLine(result);
            }
        }
    }
}

