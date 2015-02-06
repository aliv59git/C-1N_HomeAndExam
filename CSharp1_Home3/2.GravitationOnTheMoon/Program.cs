using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your wehght: ");
            float result = float.Parse(Console.ReadLine());
            Console.WriteLine("On the Moon your wieght will be approximately {0}", Math.Round(result*0.17, 3));
        }
    }
}
