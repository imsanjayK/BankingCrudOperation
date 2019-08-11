using BankApp.Model;
using BankApp.Repository;
using Support.KeyboardHelper;
using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                CustomerID = 124,
                Name = "sanjay ",
                CardNo = 123456,
                //CardType = Card.MASTER,
                Balance = 123,
               // Transaction = new List<double>()
            };

            CustomerCollection repository = new CustomerCollection();
            List<Customer> list = repository.CustomersList();
            Banking banking = new Banking();
            banking.Customers = list;

            ATM atm = new ATM()
            {
                TotalAmount = 100.99
            };
            Console.WriteLine("tff"+customer.CardType+"em");
            // var valid = banking.validateCustomer(atm, customer);
            var deposit = banking.Deposit(atm, customer);
           
        }
    }
}