using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(254.ToString("x2"));
            int numbInHexa = 0xfe;
            Console.WriteLine(numbInHexa);
            Console.WriteLine("Is 254 in hexadecimal format as 0xfe? 254 = {0}?", numbInHexa);
        }
    }
}
