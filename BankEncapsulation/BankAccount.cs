using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        public BankAccount()
        {

        }

        private double _balance = 0;

        public void Deposit(double deposit)
        {
            _balance += deposit;
            Console.WriteLine($"Deposit of ${deposit} added.\n");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Account balance: ${_balance}");
        }
    }
}
