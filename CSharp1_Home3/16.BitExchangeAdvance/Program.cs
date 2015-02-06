using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitExchangeAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter unsigned intiger number: ");
            uint numb = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter initial bit of First sequence to exchange p: ");
            int pValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter initial bit of second sequence to exchange q: ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number of bits k to exchange: ");
            int k = int.Parse(Console.ReadLine());
            //?? correct input not overlapping sequences
            if (pValue < 0 || pValue + k > 32 || q < 0 || q + k > 32 || k < 0|| numb < 0 || numb>uint.MaxValue)
            {
                Console.WriteLine("Argumets out of range!");
                return;
            }
            else if (pValue + k > q || q + k > pValue)
            {
                Console.WriteLine("Sequence overlapping!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid Arguments!");
            }
            
            Console.WriteLine("Your number is: {0}", numb);
            Console.WriteLine("Your number in binary is: \n{0}", Convert.ToString(numb, 2).PadLeft(32, '0'));
            for (int p = pValue; p < pValue+k; p++)
            {
                //Getting bit at position p
                uint mask = (uint)1 << p;
                uint bitP = (numb & mask) >> p;
                //getting bit at position (q-pValue)+p
                mask = (uint)1 << (q - pValue + p);
                uint bit21AndP = (numb & mask) >> (q-pValue + p);
                if (bitP == 0)
                {
                    mask = ~((uint)1 << (q - pValue + p));
                    numb = numb & mask;
                }
                else if (bitP == 1)
                {
                    mask = (uint)1 << (q - pValue + p);
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
