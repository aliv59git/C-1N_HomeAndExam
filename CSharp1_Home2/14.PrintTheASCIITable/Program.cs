using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 80));
            Console.OutputEncoding = Encoding.ASCII;
            Console.WriteLine("With ASCII Encoding");
            Console.WriteLine(new string('-', 80));
            for (int i = 0; i < 256; i++)
            {
                Console.Write(i + "->" + (char)i + "   ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("With Unicode Encoding");
            Console.WriteLine(new string('-', 80));

            for (int i = 0; i < 256; i++)
            {
                Console.Write(i+"->"+(char)i+"   ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',80));
            Console.WriteLine("With UTF-8 Encoding");
            Console.WriteLine(new string('-', 80));
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(i+"->"+(char)i+"   ");
            }
            Console.WriteLine();
        }
    }
}
