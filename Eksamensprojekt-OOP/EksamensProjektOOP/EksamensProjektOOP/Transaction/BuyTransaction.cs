using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class BuyTransaction : Transaction
    {
        public User user;
        public Product product;
        public Transaction transaction;
        private decimal amount;
        internal Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public BuyTransaction(User user, Product product) : base(user, product.Price)
        {
            Product = product;
        }

        public override string ToString()
        {
            return $"Product payment, {transaction.Amount}, {user.UserName}, {product.Name}, {transaction.TransactionDate}";
        }

        public decimal Execute()
        {
            if (product.Active == false)
            {
                throw new InactiveProductException(Product, "Product is inactive");
            }

            if (user.Balance >= product.Price || product.CanBeBoughtOnCredit == true)
            {
                return user.Balance -= transaction.Amount;
            }
            else
            {
                throw new InsufficientCreditsException(User, Product,"Insufficient funds");
            }
        }
    }
}
