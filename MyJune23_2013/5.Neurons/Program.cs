using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Neurons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long numb = long.Parse(Console.ReadLine());
                long number = numb;
                if (numb == -1)
                {
                    break;
                }
                long leftIndex = -1;
                long rightIndex = -1;

                for (int j = 0; j < 32; j++)
                {
                    if ((numb & ((long)1<<j))>>j ==1)
                    {
                        if (rightIndex == -1)
                        {
                            rightIndex = j;
                        }
                        leftIndex = j;
                    }
                    
                }

                //Console.WriteLine("{0}, {1}", leftIndex, rightIndex);
                for (int p = (int)rightIndex; p <= leftIndex; p++)
                {
                    long bit = numb & (1 << p);
                    bit = bit >> p;
                    if (bit == 1)
                    {
                        numb ^= (long)(1 << p);
                    }
                    if (bit == 0)
                    {
                        numb = numb | (1 << p);
                    }
                }
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine(numb);
            }



        }

       
    }
}
