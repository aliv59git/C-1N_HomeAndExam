using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DivisionBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter iniger number to check if it can be devided (without reminder) by 7 and 5: )");
            int numb = int.Parse(Console.ReadLine());
            if ((numb % 7 == 0) && (numb % 5 == 0))
            {
                Console.WriteLine("Devided by 7 and 5? "+ true);
            }
            else
            {
                Console.WriteLine("Devided by 7 and 5? " + false);
            }
        }
    }
}
