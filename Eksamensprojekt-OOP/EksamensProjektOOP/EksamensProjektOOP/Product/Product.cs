using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class Product
    {
        private int id;
        private string name;
        private decimal price;
        private bool active;
        private bool canBeBoughtOnCredit;

        //constructor
        public Product(int ID, string Name, decimal Price, bool Active, bool CanBeBoughtOnCredit)
        {
            id = ID;
            name = Name;
            price = Price;
            active = Active;
            canBeBoughtOnCredit = CanBeBoughtOnCredit;
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (value >= 1)
                    id = value;
                throw new ArgumentOutOfRangeException("Number must be 1 or higher");
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        name = value;
                    }
                }
                catch (ArgumentNullException)
                {
                    // ?
                }
            }   
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public bool CanBeBoughtOnCredit
        {
            get { return canBeBoughtOnCredit; }
            set { canBeBoughtOnCredit = value; }
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Price}";
        }
    }
}
