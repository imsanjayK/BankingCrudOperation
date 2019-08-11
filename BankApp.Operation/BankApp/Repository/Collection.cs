﻿using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Repository
{
    class CustomerCollection
    {
        public List<Customer> CustomersList()
        {
            List<Customer> list = new List<Customer>();
            list.Add( new Customer
            {
                CustomerID = 124,
                Name = "sanjay ",
                CardNo = 123456,
                CardType = Card.MASTER,
                Balance = 123,
                //Transaction = new List<double>()
            });

            Customer customer = new Customer();
            customer.CustomerID = 123;
            customer.CardNo = 123456;
            customer.Name = "Sanjay";
            customer.Balance = 89;
            customer.CardType = Card.MASTER;

            Customer customer2 = new Customer();
            customer2.CustomerID = 124;
            customer2.CardNo = 123456;
            customer2.Name = "Sanjay";
            customer2.Balance = 89;
            customer2.CardType = Card.MASTER;

            list.Add(customer);
            list.Add(customer2);


            return list;
        }
    }
}
