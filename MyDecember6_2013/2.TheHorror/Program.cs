using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            long counter = 0;
            long sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if ((48 <= str[i]) && (str[i] <=57))
                    {
                        sum += (str[i] - 48);
                        counter++;
                    }

                }
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
