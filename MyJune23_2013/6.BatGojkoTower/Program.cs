using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BatGojkoTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int k = 0;
            int h = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                Console.Write(new string('.', h - 1 - i));
                Console.Write('/');
                if (count==0)
                {
                    Console.Write(new string('-', 2*i));
                    k++;
                    count = k;
                }
                else
                {
                    Console.Write(new string('.', 2*i));
                    count--;
                }
                Console.Write("\\");
                Console.WriteLine(new string('.', h - 1 - i));
            }
        }
    }
}
