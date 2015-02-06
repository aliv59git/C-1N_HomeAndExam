using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.QuotesAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOne = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(strOne);
            string strTwo = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(strTwo);
        }
    }
}
