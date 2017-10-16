using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Accounts
    {
        public Savings(double accountBalance, double accountNumber)
        {
            this.accountBalance = accountBalance;
            this.accountNumber = accountNumber;
        }

        public override string AccountBalance()
        {
            return "Savings Balance: $" + Math.Round(accountBalance, 2);
        }

        public override void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            Console.WriteLine();
            double withdraw = double.Parse(Console.ReadLine());
            if ((accountBalance - withdraw < 0))
            {
                Console.WriteLine("\nInvalid withdrawal, cannot overdraft savings.");
            }
            else
            {
                accountBalance = accountBalance - withdraw;
                Console.WriteLine("\n" + AccountBalance());
            }
        }
    }
}
