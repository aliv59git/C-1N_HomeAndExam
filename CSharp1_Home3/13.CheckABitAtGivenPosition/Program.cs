using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter unsigned intiger number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter position to extract: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            if ((number & mask) >> position == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
