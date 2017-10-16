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
    }
}
