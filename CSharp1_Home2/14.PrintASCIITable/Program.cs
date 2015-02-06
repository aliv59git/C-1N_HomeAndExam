using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.Write("Hex".PadRight(10));
            Console.WriteLine();

            for (int i = 0; i < 256; i++)
            {
                char ch = (char)i;

                string display = string.Empty;
                if (char.IsWhiteSpace(ch))
                {
                    display = ch.ToString();
                    switch (ch)
                    {
                        case '\t': display = "\\t"; break;
                        case ' ': display = "space"; break;
                        case '\n': display = "\\n"; break;
                        case '\r': display = "\\r"; break;
                        case '\v': display = "\\v"; break;
                        case '\f': display = "\\f"; break;
                    }
                }
                else if (char.IsControl(ch))
                {
                    display = "control";
                }
                else
                {
                    display = ch.ToString();
                }

                Console.Write(i.ToString().PadRight(10));
                Console.Write(display.PadRight(10));
                Console.Write(i.ToString("X2"));
                Console.WriteLine();
            }
        }
    }
}
