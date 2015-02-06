using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromIntiger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter ushort intiger number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter position to extract: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            Console.WriteLine((number & mask) >> position);
        }
    }
}
