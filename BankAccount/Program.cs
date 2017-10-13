using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
           // do
            {
                Client greg = new Client();
                Checking checking = new Checking();
                Savings savings = new Savings();

                int choice;

                Console.WriteLine("Welcome to Cross Roads Bank. Hello " + greg.ClientName);
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());

                while (choice != 5)
                {
                    if (choice == 1)
                    {
                        greg.ClientInformation();
                    }
                    else if (choice == 2)
                    {
                        //greg.GetAccountBalance();
                    }
                    Console.WriteLine("\nWhat would you like to do?\n");
                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();
                    choice = int.Parse(Console.ReadLine());
                }
            }
           // while (exit == "no");
        }
    }
}
