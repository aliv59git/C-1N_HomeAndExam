using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BeerTime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter time in format [hh[0-12]:mm AM/PM]");
        DateTime time1 = DateTime.Parse(Console.ReadLine());
        if (time1.Hour >= 13 || time1.Hour < 3)
        {
            Console.WriteLine("Beer time");
        }
        else
        {
            Console.WriteLine("None-beer time");
        }
    }
}
