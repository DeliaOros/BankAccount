using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    enum Currency
    {
        RON,
        USD,
        EUR
    }
    class BankAccount : ISwitch, IOperationsInAccount
    {
        private string name;
        private readonly Currency currency;
        private readonly DateTime dateOfCreation;

        public bool IsClosed { get; set; }
        public string Name { get; set; }

        public decimal BalanceAccount => CalculateBalanceAccount();


        public bool IsActive
        {
            get
            {
                if (this.IsClosed)
                {
                    return false;
                }

                return true;
            }
        }

        public BankAccount(string name, Currency currency)
        {
            this.name = name;
            this.currency = currency;
            this.dateOfCreation = DateTime.Now;
            Console.WriteLine("The account is now activated.");

        }
        private decimal CalculateBalanceAccount()
        {
            decimal balance = 0.00M;
            decimal deposit = 0.00M;
            decimal withdraw = 0.00M;
            var currentBalance = balance + deposit - withdraw;
            return currentBalance;
        }        

        public void Open()
        {
            //code for opening  
            IsClosed = false;
            Console.WriteLine("This follows an Open account action"); ;
        }

        public void Close()
        {
            //code for closing                
            Console.WriteLine("This follows a close Account action");
            IsClosed = true;
        }

        public void Deposit()
        {
            if (this.IsActive)
            {
                Console.WriteLine("Deposit operation");
            }
            else
            {
                Console.WriteLine("You can't operate an inactive account, account was closed.");
            }

        }

        public void Withdraw()
        {
            if (this.IsActive)
            {
                Console.WriteLine("Withdraw operation");
            }
            else
            {
                Console.WriteLine("You can't operate an inactive account, account was closed.");
            }
        }

        public override string ToString()
        {
            return $"Owner: {this.name}, " +
                   $"Currency: {this.currency}, " +
                   $"Date of creation: {this.dateOfCreation}, " +
                   $"Balance: {this.currency} {this.BalanceAccount.ToString("F")}, " +
                   $"Account is active: {this.IsActive}.";
        }
    }
}
