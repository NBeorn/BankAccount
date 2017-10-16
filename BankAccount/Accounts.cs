using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Accounts
    {
        protected double accountNumber;
        protected double accountBalance;
        protected static int accountType;

        public abstract string AccountBalance(); //so Checking and Savings can have unique versions containing different starting values

        public virtual void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            Console.WriteLine();
            accountBalance = accountBalance + double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + AccountBalance()); //since AccountBalance() is unique to Savings and Checking, it knows which value to use
        }

        public virtual void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            Console.WriteLine();
            accountBalance = accountBalance - double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + AccountBalance());
        }

        public static void AccountType()
        {
            Console.WriteLine("\nFor which account?");
            Console.WriteLine("1. Checking");
            Console.WriteLine("2. Savings");
        }
    }
}
