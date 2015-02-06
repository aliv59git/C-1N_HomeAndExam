using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter value 0 or 1: ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter position: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is: \n{0}", Convert.ToString(n, 2).PadLeft(16, '0'));
            int mask = 1 << p;
            int result;
            if (v == 0)
            {
                result = n & (~mask);
            }
            else
            {
                result = n | mask;
            }
            Console.WriteLine("Your modified number is: \n{0}", Convert.ToString(result, 2).PadLeft(16, '0'));
            //Console.WriteLine("As decimal intigers: n = {0} and result = {1}", n, result);
        }
    }
}
