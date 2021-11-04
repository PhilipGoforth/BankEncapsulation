using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double balance = 0;

        public void Deposit(double deposit)
        {
            balance += deposit;
            Console.WriteLine($"Deposit of ${deposit} added.\n");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Account balance: ${balance}");
        }
    }
}
