using BankApp.Model;
using BankApp.Repository;
using Support.KeyboardHelper;
using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer()
            {
                Balance=0
            };
            Collection repo = new Collection();
            List<Customer> list = repo.CustomersList();
            
            
            ATM atm = new ATM()
            {
                TotalAmount = 10.89,
                Transactions = list
            };
            Banking banking = new Banking();
            banking.Customers = list;
            Console.WriteLine(banking.Deposit(atm,c));
        }
    }
}