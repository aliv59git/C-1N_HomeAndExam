using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HowOld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter you birthday: [year.month.day]");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You are entered: {0}", birthday);
            DateTime now = DateTime.Now;
            Console.WriteLine("Now is: {0}", now);
            Console.WriteLine();
            if (now.DayOfYear - birthday.DayOfYear < 0)
            {
                Console.WriteLine("You are {0} years old.", now.Year - birthday.Year - 1);
                Console.WriteLine("After 10 years you will be {0} years old.", now.AddYears(10).Year - birthday.Year - 1);
            }
            else
            {
                Console.WriteLine("You are {0} years old.", now.Year - birthday.Year);
                Console.WriteLine("After 10 years you will be {0} years old.", now.AddYears(10).Year - birthday.Year);

            }
        }
    }
}
