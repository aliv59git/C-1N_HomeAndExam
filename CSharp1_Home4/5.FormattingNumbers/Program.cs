using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter intiger number 0<= a <=500 : ");
            ushort a = ushort.Parse(Console.ReadLine());
            Console.Write("Please, enter floating point number b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Please, enter floating point number c = ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("|a = ".PadRight(11));
            Console.Write("|a in bin:".PadRight(11));
            Console.Write("|b = ".PadRight(11));
            Console.WriteLine("|c = ".PadRight(11)+"|");
            Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|", a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
            Console.WriteLine();
        }
    }
}
