using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class CashTransaction
    {
        public User user;
        public Transaction transaction;

        public override string ToString()
        {
            return $"Money being transferred to account, {transaction.Amount}, {user.UserName}, {transaction.TransactionDate}, {transaction.Id}"; 
        }

        public decimal execute()
        {
            return user.Balance += transaction.Amount;
        }
    }
}