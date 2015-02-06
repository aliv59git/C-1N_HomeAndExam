using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = false;
            Console.WriteLine(isFemale);
            Console.WriteLine(isFemale = true ? false : true);
        }
    }
}
