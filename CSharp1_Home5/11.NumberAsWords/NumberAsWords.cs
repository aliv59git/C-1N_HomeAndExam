using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number from 0 to 999: ");
        int numb = int.Parse(Console.ReadLine());
        if (numb == 100)
        {
            Console.WriteLine("Hundred");
        }
        else if (numb == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            string hund = "";
            string deci = "";
            string number = "";

            switch (numb / 100)
            {
                case 0: hund = String.Empty; break;
                case 1: hund = "One hundred and "; break;
                case 2: hund = "Two hundred and "; break;
                case 3: hund = "Three hundred and "; break;
                case 4: hund = "Four hundred and "; break;
                case 5: hund = "Five hundred and "; break;
                case 6: hund = "Six hundred and "; break;
                case 7: hund = "Seven hundred and "; break;
                case 8: hund = "Eight hundred and "; break;
                case 9: hund = "Nine hundred and "; break;
            }
            switch ((numb % 100) / 10)
            {
                case 0: deci = ""; break;
                case 1: deci = ""; break;
                case 2: deci = "twenty "; break;
                case 3: deci = "thirty "; break;
                case 4: deci = "fourty "; break;
                case 5: deci = "fifty "; break;
                case 6: deci = "sixty "; break;
                case 7: deci = "seventy "; break;
                case 8: deci = "eighty "; break;
                case 9: deci = "ninety "; break;
            }

            if (numb % 100 < 20)
            {
                switch (numb % 100)
                {
                    case 0: number = ""; break;
                    case 1: number = "one"; ; break;
                    case 2: number = "two"; break;
                    case 3: number = "three"; break;
                    case 4: number = "four"; break;
                    case 5: number = "five"; break;
                    case 6: number = "six"; break;
                    case 7: number = "seven"; break;
                    case 8: number = "eight"; break;
                    case 9: number = "nine"; break;
                    case 10: number = "ten"; break;
                    case 11: number = "eleven"; break;
                    case 12: number = "twelve"; break;
                    case 13: number = "thirteen"; break;
                    case 14: number = "fourteen"; break;
                    case 15: number = "fifteen"; break;
                    case 16: number = "sixteen"; break;
                    case 17: number = "seventeen"; break;
                    case 18: number = "eighteen"; break;
                    case 19: number = "nineteen"; break;
                    default: number = ""; break;
                }
            }
            else
            {
                switch ((numb % 100) % 10)
                {
                    case 0: number = ""; break;
                    case 1: number = "one"; ; break;
                    case 2: number = "two"; break;
                    case 3: number = "three"; break;
                    case 4: number = "four"; break;
                    case 5: number = "five"; break;
                    case 6: number = "six"; break;
                    case 7: number = "seven"; break;
                    case 8: number = "eight"; break;
                    case 9: number = "nine"; break;
                }
            }

            Console.WriteLine(hund + deci + number);
        }
    }
}
