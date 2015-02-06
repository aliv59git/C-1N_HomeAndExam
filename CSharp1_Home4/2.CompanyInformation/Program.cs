using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter required information: Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string age = Console.ReadLine();
            Console.Write("Manager phone: ");
            string phone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(companyName+"\nAddress: "+companyAddress+"\nTel."+companyPhoneNumber+"\nFax: "+faxNumber+"\nWeb site: "+webSite+"\nManager: "+firstName+" "+lastName+" (age: "+age+", tel. "+phone+")");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();
        }
    }
}
