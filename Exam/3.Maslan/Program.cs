using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Maslan
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            int numbOfTransformation = 0;
            BigInteger[] numbers = new BigInteger[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = 1;
            }
            int k = 0;

            numbers[0] = n;

            while (numbers[k] != numbers[k + 1])
            {
                BigInteger temp = numbers[k]/10;
                k++;

                while (temp > 0)
                {
                    int sum = 0;
                    //Console.WriteLine(sum);
                    string tmp = temp.ToString();
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += (tmp[j] - 48);
                        }
                    }
                    if (sum > 0)
                    {
                        numbers[k] *= sum;
                    }
                    temp /= 10;

                    if (numbers[k] == 1)
                    {
                        numbOfTransformation++;
                        Console.WriteLine(numbOfTransformation);
                        Console.WriteLine(numbers[k]);
                        return;
                    }

                }
                //Console.WriteLine(string.Join(", ", numbers));
                numbOfTransformation++;
                if (numbOfTransformation == 11)
                {
                    Console.WriteLine(numbers[k-1]);
                    return;
                }
                //Console.WriteLine(numbOfTransformation);
                //Console.WriteLine(k);
            }
            Console.WriteLine(numbOfTransformation-1);
            Console.WriteLine(numbers[k-1]);

        }
    }
}
