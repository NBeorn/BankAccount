using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Accounts
    {
        protected double accountNumber;
        protected double accountBalance;
        protected string accountType;

        public string AccountBalance()
        {
            return "Current balance: " + accountBalance;
        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            accountBalance = accountBalance + double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + AccountBalance());
        }

        public void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            accountBalance = accountBalance - double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + AccountBalance());
        }
    }
}
