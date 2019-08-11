using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Model
{
    class Customer
    {
        private int customerID;
        private string name;
        private int cardNo;
        private Card cardType;
        private double balance;
        private List<Transaction> transactions;

        public int CustomerID { get => customerID; set => customerID = value; }
        public int CardNo { get => cardNo; set => cardNo = value; }
        public string Name { get => name; set => name = value; }
        public Card CardType { get => cardType; set => cardType = value; }
        public double Balance { get => balance; set => balance = value; }
        public List<Transaction> Transactions { get => transactions; set => transactions = value; }
        public Customer()
        {
            Transactions = new List<Transaction>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   CustomerID == customer.CustomerID &&
                   CardNo == customer.CardNo &&
                   Name.ToLower().Trim() == customer.Name.ToLower().Trim();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerID, CardNo, Name);
        }
    }
    public class Transaction
    {
        public string type { set; get; }
        public double amount { set; get; }

        public Transaction(string type, double amount)
        {
            this.type = type;
            this.amount = amount;
        }
    }

    public enum Card
    {
        RUPEE,
        MASTER,
        VISA,
        UNKNOW

    }
}
