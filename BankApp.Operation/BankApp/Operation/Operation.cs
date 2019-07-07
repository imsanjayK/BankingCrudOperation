using Support.KeyboardHelper;
using System;
using System.Collections.Generic;
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

        public bool Deposit(ATM atm,Customer currentCustomer)
        {
             
            if ( validateCustomer(atm,currentCustomer) )
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

        public bool validateCustomer(ATM atm, Customer currentCustomer)
        {
            
            foreach (var customer in Customers)
            {
                if (customer.Equals(currentCustomer))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
