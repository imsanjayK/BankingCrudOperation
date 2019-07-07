using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Repository
{
    class Collection
    {
        public List<Customer> CustomersList()
        {
            List<Customer> list = new List<Customer>() { };
            list.Add(new Customer
            {
                CustomerID = 123,
                Name = "Sanjay kumar",
                CardNo = 12345,
                Transaction = { 0 },
                Balance = 0
                
            });
            list.Add(new Customer
            {
                CustomerID = 123,
                Name = "Sanjay kumar",
                CardNo = 12345,
                Transaction = { 0 },
                Balance = 0
            });

            return list;
        }

    }
}