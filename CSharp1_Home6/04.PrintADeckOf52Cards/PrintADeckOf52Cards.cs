using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintADeckOf52Cards
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 15; i++)
        {
            if (i == 11)
            {
                continue;
            }
            string face = "";
            if (i < 12)
            {
                face = i.ToString();
            }
            else if (i == 12)
            {
                face = "J";
            }
            else if (i == 13)
            {
                face = "D";
            }
            else if (i == 14)
            {
                face = "K";
            }
            else if (i == 15)
            {
                face = "A";
            } 
            for (int suit = 0; suit < 4; suit++)
            {
                switch (suit)
                {
                    case 0: Console.Write("{0} of spaders, ", face); break;
                    case 1: Console.Write("{0} of clubs,  ", face); break;
                    case 2: Console.Write("{0} of hearts,  ", face); break;
                    case 3: Console.Write("{0} of diamonds,  ", face); break;
                    default: Console.Write("Invalid card"); break;
                }
            }
            Console.WriteLine();
        }
    }
}
