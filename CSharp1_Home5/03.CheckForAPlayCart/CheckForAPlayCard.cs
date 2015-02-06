using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter sign for a play card. Is valid card sign?: ");
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.KeyChar == '2' || key.KeyChar == '3'||key.KeyChar == '4' || key.KeyChar == '5'||key.KeyChar == '6' || key.KeyChar == '7'||key.KeyChar == '8' || key.KeyChar == '9'||key.KeyChar=='J'||key.KeyChar=='Q'||key.KeyChar=='K'||key.KeyChar=='A')
        {
            Console.WriteLine();
            Console.WriteLine("Yes");
        }
        else if (key.KeyChar == '1')
        {
            ConsoleKeyInfo key1 = Console.ReadKey();
            if (key1.KeyChar == '0')
            {
                Console.WriteLine();
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("No");
        }
    }
}
