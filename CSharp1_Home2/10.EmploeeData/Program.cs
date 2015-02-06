using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {

            string employeeFirstName = "Pesho";
            string employeeLastName = "Ivanov";
            byte employeeAge = 37;
            ulong employeeIDNumber = 8306112507;
            uint employeeUniqueNumber = 27569999;
            Console.WriteLine("The first employee is {0} {1}. It is {2} year old and has Personal ID Number {3} and Unique Number {4}.", employeeFirstName, employeeLastName, employeeAge, employeeIDNumber, employeeUniqueNumber);
        }
    }
}
