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
                Balance = 100,
            };

            CustomerCollection repository = new CustomerCollection();
            List<Customer> list = repository.CustomersList();
            Banking banking = new Banking();
            banking.Customers = list;

            ATM atm = new ATM()
            {
                TotalAmount = 100.99
            };

           
            bool repeat = false;
            do
            {
                int option = (int)KeyboardHelper.ReadNumber("1. Withdraw 2. Deposite 3. Transactions");
                switch (option)
                {
                    case 1:
                        KeyboardHelper.Status(banking.Withdraw(atm, customer));
                        repeat = true;
                        break;
                    case 2:
                        KeyboardHelper.Status(banking.Deposit(atm, customer));
                        repeat = true;
                        break;
                    case 3:
                        print(banking.ViewTransactions(customer));
                        repeat = true;
                        break;
                    case 4:
                        KeyboardHelper.print(banking.Balance(customer));
                        repeat = true;
                        ;
                        break;
                    case 5:
                        Console.WriteLine("Thank you for visiting us.");
                        repeat = false;
                        ;
                        break;

                }
                option = 0;
            } while (repeat);
        }

        public static void print(dynamic value)
        {
            if (value.GetType().Equals(typeof(System.Collections.Generic.List<Transaction>)))
            {
                foreach (var item in value)
                {
                    Console.WriteLine(item.type + " " + item.amount);
                }
            }
            else
            {
                throw new Exception("Something wrong");
            }
        }
    }
}