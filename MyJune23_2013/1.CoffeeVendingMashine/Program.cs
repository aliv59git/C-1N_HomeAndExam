using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CoffeeVendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] coins = { (decimal)0.05, (decimal)0.10, (decimal)0.20, (decimal)0.50, (decimal)1.00 };
            decimal[] arr = new decimal[5];
            decimal sumInTheMashine = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
                sumInTheMashine += arr[i] * coins[i];
            }
            decimal sumAfterChange = sumInTheMashine;
            decimal a = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            if (a >= p)
            {
                if (a == p)
                {
                    Console.WriteLine("Yes {0:F2}", sumInTheMashine);
                }
                else
                {
                    decimal change = a - p;
                    int n4 = (int)(change);
                    if (n4 <= arr[4])
                    {

                        change -= n4;
                        sumAfterChange -= n4;
                    }
                    else
                    {
                        change -= arr[4];
                        sumAfterChange -= arr[4];
                    }

                    int n3 = (int)((change * 100) / 50);
                    if (n3 <= arr[3])
                    {
                        change -= n3 * 0.50m;
                        sumAfterChange -= n3 * 0.50m;
                    }
                    else
                    {
                        change -= arr[3] * 0.50m;
                        sumAfterChange -= arr[3] * 0.50m;
                    }

                    int n2 = (int)((change * 100) / 20);
                    if (n2 <= arr[2])
                    {
                        change -= n2 * 0.20m;
                        sumAfterChange -= n2 * 0.20m;
                    }
                    else
                    {
                        change -= arr[2] * 0.20m;
                        sumAfterChange -= arr[2] * 0.20m;
                    }

                    int n1 = (int)((change * 100) / 10);
                    if (n1 <= arr[1])
                    {
                        change -= n1 * 0.10m;
                        sumAfterChange -= n1 * 0.10m;
                    }
                    else
                    {
                        change -= arr[1] * 0.10m;
                        sumAfterChange -= arr[1] * 0.10m;
                    }
                    int n0 = (int)((change * 100) / 5);
                    if (n0 <= arr[0])
                    {
                        change -= n0 * 0.05m;
                        sumAfterChange -= n0 * 0.05m;
                    }
                    else
                    {
                        change -= arr[0] * 0.05m;
                        sumAfterChange -= arr[0] * 0.05m;
                    }

                    if (change == 0)
                    {
                        Console.WriteLine("Yes {0:F2}", sumAfterChange);
                    }
                    else if (change != 0)
                    {
                        Console.WriteLine("No {0:F2}", sumInTheMashine);
                    }

                }
            }
            else
            {
                Console.WriteLine("More {0:F2}", p - a);
            }
        }
    }
}
