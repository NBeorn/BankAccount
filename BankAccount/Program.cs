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
            //Instantiate all objects
            Client greg = new Client();
            Checking checking = new Checking(1200.00d, 8645);
            Savings savings = new Savings(500.00d, 8431);

            //Set up menu options within loop
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
                    greg.ClientInformation(); //Displays information
                }
                else if (choice == 2)
                {
                    Accounts.AccountType();
                    Console.WriteLine();
                    int accountType = int.Parse(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(checking.AccountBalance()); //Checking version of this method
                    }
                    else if (accountType == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(savings.AccountBalance()); //Savings version of this method
                    }
                }
                else if (choice == 3)
                {
                    Accounts.AccountType();
                    Console.WriteLine();
                    int accountType = int.Parse(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.WriteLine();
                        checking.Deposit();
                        Console.WriteLine();
                    }
                    else if (accountType == 2)
                    {
                        Console.WriteLine();
                        savings.Deposit();
                        Console.WriteLine();
                    }
                }
                else if (choice == 4)
                {
                    Accounts.AccountType();
                    Console.WriteLine();
                    int accountType = int.Parse(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.WriteLine();
                        checking.Withdraw();
                        Console.WriteLine();
                    }
                    else if (accountType == 2)
                    {
                        Console.WriteLine();
                        savings.Withdraw(); //Savings version of this method
                        Console.WriteLine();
                    }
                }
                //Reiterate before looping back so user can close
                Console.WriteLine("\nWhat would you like to do?\n");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThank you for banking with Cross Roads Bank! Have a nice day.");
        }
    }
}
