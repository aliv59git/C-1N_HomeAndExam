using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            Console.WriteLine("This is null intiger: {0}", nullInt);
            Console.WriteLine("This is nullOrDefault intiger: {0}", nullInt.GetValueOrDefault());
            string str = null;
            string str1 = " ";
            string str2 = "null";
            Console.WriteLine("Add to nullInt: {0}", nullInt + str);
            Console.WriteLine("Add to nullInt: {0}", nullInt + str1);
            Console.WriteLine("Add to nullInt: {0}", nullInt + str2);
            double? doubleNull = null;
            Console.WriteLine("This is null double: {0}", doubleNull);
            Console.WriteLine("This is nullOrDefault double: {0}", doubleNull.GetValueOrDefault());
            Console.WriteLine("Add to doubleNull: {0}", doubleNull + str);
            Console.WriteLine("Add to doubleNull: {0}", doubleNull + str1);
            Console.WriteLine("Add to doubleNull: {0}", doubleNull + str2);
        }
    }
}
