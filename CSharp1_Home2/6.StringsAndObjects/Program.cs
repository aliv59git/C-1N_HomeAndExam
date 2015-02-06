using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOne = "Hello";
            string strTwo = "World";
            object objOne = strOne + " " + strTwo;
            Console.WriteLine(objOne);
            string strThree = (string)objOne;
            Console.WriteLine(strThree);
        }
    }
}
