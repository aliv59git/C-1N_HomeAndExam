using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CurrentDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time is: {0}", now);
            DateTime inFuture = now.AddYears(10);
            Console.WriteLine("After 10 years it will be: {0}", inFuture);
        }
    }
}
