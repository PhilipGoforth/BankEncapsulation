using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyBankAccount = new BankAccount();
            MyBankAccount.Deposit(5.00);
            MyBankAccount.GetBalance();

        }
    }
}
