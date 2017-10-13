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
        protected double accountBalance = 1200.00d;
        protected string accountType;

        public double AccountBalance
        {
            get { return this.AccountBalance; }
        }

        public string GetAccountBalance()
        {
            return "Current balance: " + accountBalance;
        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            accountBalance = accountBalance + double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + GetAccountBalance());
        }

        public void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            accountBalance = accountBalance - double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + GetAccountBalance());
        }
    }
}
