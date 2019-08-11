using Support.KeyboardHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BankApp.Model
{
    interface IBanking
    {
        bool Deposit(ATM atm, Customer customer);
       // Customer GetCustomer(int customerId);
    }
    class Banking : IBanking
    {

        private List<Customer> customers;
        public List<Customer> Customers { get => customers; set => customers = value; }

        public bool Deposit(ATM atm, Customer currentCustomer)
        {

            if (validateCustomer(atm, currentCustomer))
            {
                var depositAmount = KeyboardHelper.ReadNumber("Deposite Amount:");
                atm.TotalAmount += depositAmount;
                atm.Transactions.Add(currentCustomer);
                currentCustomer.Transaction.Add(depositAmount);
                currentCustomer.Balance += depositAmount;
                return true;
            }
            return false;
        }

        public List<Customer> Customers { get => customers; set => customers = value; }

        public bool Withdraw(ATM atm, Customer currentCustomer)
        {

            if (validateCustomer(atm, currentCustomer))
            {
                var depositAmount = KeyboardHelper.ReadNumber("Deposite Amount:");
                atm.TotalAmount -= depositAmount;
                atm.Transactions.Add(currentCustomer);
                currentCustomer.Transaction.Add(depositAmount);
                currentCustomer.Balance += depositAmount;
                return true;
            }
            return false;
        }

        public bool validateCustomer(ATM atm, Customer currentCustomer)
        {
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //var c = Customers.Where(customer => customer.Equals(currentCustomer));
            //if (c.Contains(currentCustomer) && c.Count<Customer>() == 1)
            //{
            //    stopWatch.Stop();
            //    time = stopWatch.Elapsed;
            //    return true;
            //}
            //foreach (var customer in Customers)
            //{
            //    if (customer.Equals(currentCustomer))
            //    {
            //        stopWatch.Stop();
            //        time = stopWatch.Elapsed;
            //        return true;
            //    }
            //}
            //time = stopWatch.Elapsed;
            //return false;

            var validCustomer = Customers.Where(customer => customer.Equals(currentCustomer));
            if ( validCustomer.Count<Customer>() == 1 && validCustomer.Contains(currentCustomer) )
            {
                return true;
            }
            return false;
        }
    }
}
