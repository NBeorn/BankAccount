using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Accounts //must derive from accounts for AccountBalance() to work, and to use accountBalance and accountNumber
    {
        public Checking(double accountBalance, double accountNumber)
        {
            this.accountBalance = accountBalance;
            this.accountNumber = accountNumber;
        }

        public override string AccountBalance()
        {

            return "Account Number: " + accountNumber + "\nChecking Balance: $" + Math.Round(accountBalance, 2);

        }
    }
}
