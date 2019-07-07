using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Model
{
    public class Customer
    {
        private int customerID;
        private string name;
        private int cardNo;
        private Card cardType;
        private double balance;
        private List<double> transaction;

        public int CustomerID { get => customerID; set => customerID = value; }
        public int CardNo { get => cardNo; set => cardNo = value; }
        public string Name { get => name; set => name = value; }
        public Card CardType { get => cardType; set => cardType = value; }
        public double Balance { get => balance; set => balance = value; }
        public List<double> Transaction { get => transaction; set => transaction = value; }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   CustomerID == customer.CustomerID &&
                   CardNo == customer.CardNo &&
                   Name == customer.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerID, CardNo, Name);
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
