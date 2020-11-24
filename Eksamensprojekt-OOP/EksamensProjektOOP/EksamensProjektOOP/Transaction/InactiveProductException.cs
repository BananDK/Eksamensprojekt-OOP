using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class InactiveProductException : Exception
    {
        Product product;

        internal Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public InactiveProductException(Product product, string message)
            : base(message)
        {
            Product = product;
        }
    }
}
