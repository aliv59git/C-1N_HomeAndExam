using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //42 in Hexadecimal Format is 2a -> 2*16+10 
            Console.WriteLine(0x2a); //control
            char ch = '\u002a';
            Console.WriteLine(ch);
        }
    }
}
