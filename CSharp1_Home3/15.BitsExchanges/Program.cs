using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class Program
    {
        private static int p;
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter unsigned intiger number: ");
            uint numb = uint.Parse(Console.ReadLine());
            Console.WriteLine("Your number is: {0}", numb);
            Console.WriteLine("Your number in binary is: \n{0}", Convert.ToString(numb, 2).PadLeft(32, '0'));
            for (int p = 3; p < 6; p++)
            {
                //Getting bit at position p
                uint mask = (uint)1 << p;
                uint bitP = (numb & mask) >> p;
                //getting bit at position 21+p
                mask = (uint)1 << (21 + p);
                uint bit21AndP = (numb & mask) >> (21 + p);
                if (bitP == 0)
                {
                    mask = ~((uint)1 << (21 + p));
                    numb = numb & mask;
                }
                else if (bitP == 1)
                {
                    mask = (uint)1 << (21 + p);
                    numb = numb | mask;
                }

                if (bit21AndP == 0)
                {
                    mask = ~((uint)1 << p);
                    numb = numb & mask;
                }
                else if (bit21AndP == 1)
                {
                    mask = (uint)1 << p;
                    numb = numb | mask;
                }
            }
            Console.WriteLine("Your modified number in binary is: \n{0}", Convert.ToString(numb, 2).PadLeft(32, '0'));
            Console.WriteLine("Result is: {0}", numb);
        }
    }
}
