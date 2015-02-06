using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OnesAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            string str = Convert.ToString(n, 2).PadLeft(32, '0');
            string str1 = str.Substring(16, 16);
            //first row
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]-48 == 0)
                {
                    Console.Write("###");
                }
                else
                {
                    Console.Write(".#.");
                }
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            //second row
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]-48 == 0)
                {
                    Console.Write("#.#");
                }
                else
                {
                    Console.Write("##.");
                }
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            //third row
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]-48 == 0)
                {
                    Console.Write("#.#");
                }
                else
                {
                    Console.Write(".#.");
                }
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            //fourth row
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]-48 == 0)
                {
                    Console.Write("#.#");
                }
                else
                {
                    Console.Write(".#.");
                }
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            //fifth row
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]-48 == 0)
                {
                    Console.Write("###");
                }
                else
                {
                    Console.Write("###");
                }
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
