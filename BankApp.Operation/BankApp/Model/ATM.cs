using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Model
{
    class ATM
    {
        private double totalAmount;
        private List<Customer> transactions;

        public List<Customer> Transactions { get => transactions; set => transactions = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
