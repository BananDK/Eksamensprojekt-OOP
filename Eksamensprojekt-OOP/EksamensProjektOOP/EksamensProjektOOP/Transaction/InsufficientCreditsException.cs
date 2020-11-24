using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class InsufficientCreditsException : Exception
    {
        User user;
        Product product;

        internal User User
        {
            get { return user; }
            set { user = value; }
        }

        internal Product Product
        {
            get { return product; }
            set { product = value; }
        }s

        public InsufficientCreditsException(User user, Product product, string message)
            : base(message)
        {
            User = user;
            Product = product;
        }
    }
}
