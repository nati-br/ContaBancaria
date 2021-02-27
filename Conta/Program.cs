using System;
using Conta.Entities;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            /* UPCASTING E DOWNCASTING
             * 
             * Account acc = new Account(1001, "Alex", 0.0);
             BunisessAccount bacc = new BunisessAccount(1002, "Maria", 0.0,500);

             // UPCASTING

             Account acc1 = bacc;
             Account acc2 = new BunisessAccount (1003, "bob",0.0, 200.0);
             Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

             //DOWNCASTING

             BunisessAccount acc4 = (BunisessAccount)acc2;
             acc4.Loan(100.0);

             if (acc3 is BunisessAccount)
             {
                 //BunisessAccount acc5 = (BunisessAccount)acc3;
                 BunisessAccount acc5 = acc3 as BunisessAccount;
                 acc5.Loan(200.0);
                 Console.WriteLine("Loan!");
             }
             if(acc3 is SavingsAccount)
             {
                 SavingsAccount acc5 = (SavingsAccount)acc3;
                 acc5.UpdateBalance();
                 Console.WriteLine("Update!");
             }
            */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "ANa", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(".");
        }

    }
}
