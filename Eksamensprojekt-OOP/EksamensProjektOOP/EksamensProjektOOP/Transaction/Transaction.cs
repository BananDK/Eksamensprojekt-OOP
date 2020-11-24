using System;
using System.Collections.Generic;
using System.Text;
using EksamensProjektOOP;

namespace EksamensProjektOOP
{
    class Transaction
    {
        private int id;
        private User user;
        private DateTime transactionDate;
        private decimal amount;

        public Transaction(int Id, User User, DateTime TransactionDate, decimal Amount)
        {
            id = Id;
            user = User;
            transactionDate = TransactionDate;
            amount = Amount;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1)
                    id = value;
                throw new ArgumentOutOfRangeException("Number must be 1 or higher");
            }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set
            {
                DateTime.Now.ToShortTimeString();
            }

        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public override string ToString()
        {
            return $"{id}, {user}, {amount}, {transactionDate}";
        }
    }
}
