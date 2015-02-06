using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter intiger or double number or string: ");
        Console.Write("Please, choice a type:\n1 --> int \n2 --> double\n3 --> string");
        Console.WriteLine();
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.Write("Please, enter an intiger number: "); break;
            case 2: Console.Write("Please, enter a double number: "); break;
            case 3: Console.Write("Please, enter a string: "); break;
            default: Console.Write("Invalid entrance!"); break;
        }
        int intNumb;
        double doubleNumb;
        string str = Console.ReadLine();
        if (!(int.TryParse(str, out intNumb)))
        {
            if (!(double.TryParse(str, out doubleNumb)))
            {
                Console.WriteLine(str+"*");
            }
            else
            {
                Console.WriteLine(doubleNumb+1);
            }
        }
        else
        {
            Console.WriteLine(intNumb+1);
        }
    }
}
