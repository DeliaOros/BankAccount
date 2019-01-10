using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount regularAccount = new BankAccount("CompanyX", Currency.RON);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(regularAccount.ToString());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(regularAccount.BalanceAccount);
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Close();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Open();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Deposit();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Withdraw();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Close();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(regularAccount.IsClosed);
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Deposit();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Withdraw();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(regularAccount.IsActive);
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Open();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Deposit();
            Console.WriteLine("----------------------------------------------------");
            regularAccount.Deposit();





        }
    }
}
