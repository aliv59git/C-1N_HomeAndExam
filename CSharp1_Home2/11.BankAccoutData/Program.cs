using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccoutData
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountFName = "Ivan";
            string accountMName = "Stojanov";
            string accountLName = "Ivanov";
            decimal accountBalance = 2345.34m;
            string accountBankName = "Bulbank";
            string accountIBAN = "BASF1234556787OP";
            ulong accountCKartOne = 123456789012;
            ulong accountCKartOTwo = 234567890123;
            ulong accountCKartOThree = 345678901234;
            Console.WriteLine("The bank account of {0} {1} {2}: \nBalance: {3}\nBank name: {4}\nIBAN: {5}\nHe/She has credit carts:\n{6}\n{7}\n{8}", accountFName, accountMName, accountLName, accountBalance, accountBankName, accountIBAN, accountCKartOne, accountCKartOTwo, accountCKartOThree);
        }
    }
}
