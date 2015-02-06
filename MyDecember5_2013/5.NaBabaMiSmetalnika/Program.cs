using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NaBabaMiSmetalnika
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            long l0 = long.Parse(Console.ReadLine());
            long l1 = long.Parse(Console.ReadLine());
            long l2 = long.Parse(Console.ReadLine());
            long l3 = long.Parse(Console.ReadLine());
            long l4 = long.Parse(Console.ReadLine());
            long l5 = long.Parse(Console.ReadLine());
            long l6 = long.Parse(Console.ReadLine());
            long l7 = long.Parse(Console.ReadLine());

            int counter0 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l0 & (long) mask) > 0)
                {
                    counter0++;
                }
            }
            Console.WriteLine(counter0);

            int counter1 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l1 & (long)mask) > 0)
                {
                    counter1++;
                }
            }
            Console.WriteLine(counter1);
            int counter2 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l2 & (long)mask) > 0)
                {
                    counter2++;
                }
            }
            Console.WriteLine(counter2);
            int counter3 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l3 & (long)mask) > 0)
                {
                    counter3++;
                }
            }
            Console.WriteLine(counter3);
            int counter4 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l4 & (long)mask) > 0)
                {
                    counter4++;
                }
            }
            Console.WriteLine(counter4);
            int counter5 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l5 & (long)mask) > 0)
                {
                    counter5++;
                }
            }
            Console.WriteLine(counter5);
            int counter6 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l6 & (long)mask) > 0)
                {
                    counter6++;
                }
            }
            Console.WriteLine(counter6);
            int counter7 = 0;
            for (int i = 0; i < width; i++)
            {
                int mask = 1 << (width - i);
                if ((l7 & (long)mask) > 0)
                {
                    counter7++;
                }
            }
            Console.WriteLine(counter7);




        }
    }
}
