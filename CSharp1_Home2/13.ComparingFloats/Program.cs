using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.00000001;
            double b = 5.00000003;
            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine("a and b are equal (with precision eps = 0.000001)");
            }
            else 
            {
                Console.WriteLine("a and b are differen (with precision eps = 0.000001)");
            }

            double a1 = 0.0000007;
            double b1 = 0.00000007;
            if (Math.Abs(a1 - b1) < 0.000001)
            {
                Console.WriteLine("a1 and b1 are equal (with precision eps = 0.000001)");
            }
            else
            {
                Console.WriteLine("a1 and b1 are differen (with precision eps = 0.000001)");
            }

            double a2 = 4.999999;
            double b2 = 4.000008;
            if (Math.Abs(a2 - b2) < 0.000001)
            {
                Console.WriteLine("a2 and b2 are equal (with precision eps = 0.000001)");
            }
            else
            {
                Console.WriteLine("a2 and b2 are differen (with precision eps = 0.000001)");
            }



        }
    }
}
