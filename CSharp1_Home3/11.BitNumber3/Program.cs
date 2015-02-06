using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBitNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter unsigned intiger number: ");
            ushort numb = ushort.Parse(Console.ReadLine());
            ushort mask = 1 << 3;
            Console.WriteLine((numb & mask) >> 3);
        }
    }
}
