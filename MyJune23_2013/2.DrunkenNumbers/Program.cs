using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long number = 0;
            long beersM = 0;
            long beersV = 0;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                number = long.Parse(str);
                if (number < 0)
                {
                    number = -number;
                }
                long number1 = number;
                int count = 0;
                while (number1 > 0)
                {
                    int digit = (int)number1 % 10;
                    number1 /= 10;
                    count++;
                }

                long number2 = number;
                if (count % 2 == 0)
                {
                    for (int j = 0; j < (count / 2); j++)
                    {
                        beersV += (int)number2 % 10;
                        number2 /= 10;
                    }
                    for (int j = 0; j < (count / 2); j++)
                    {
                        beersM += (int)number2 % 10;
                        number2 /= 10;
                    }
                }
                else
                {
                    for (int j = 0; j < count / 2; j++)
                    {
                        beersV += (int)number2 % 10;
                        number2 /= 10;
                    }
                    beersV += (int)number2 % 10;
                    beersM += (int)number2 % 10;
                    number2 /= 10;
                    for (int j = 0; j < count / 2; j++)
                    {
                        beersM += (int)number2 % 10;
                        number2 /= 10;
                    }
                }


            }
            if (beersM > beersV)
            {
                Console.WriteLine("M {0}", beersM - beersV);
            }
            else if (beersM < beersV)
            {
                Console.WriteLine("V {0}", beersV - beersM);
            }
            else
            {
                Console.WriteLine("No {0}", beersV + beersM);
            }
        }
    }
}
