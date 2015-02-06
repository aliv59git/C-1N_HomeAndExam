using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine('\u00A9'); 
            char cr = '\u00A9';
            Console.WriteLine("Please, enter intiger number n: ");
            int n = Int32.Parse(Console.ReadLine());
            int k;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write(cr);
                if (i == 0)
                {
                    k = i;
                }
                else
                {
                    k = 1;
                }
                Console.Write(new string(' ', 2 * i - k));
                Console.Write(new string(cr, k));
                Console.WriteLine();
            }
            Console.Write(cr);
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(" " + cr);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
