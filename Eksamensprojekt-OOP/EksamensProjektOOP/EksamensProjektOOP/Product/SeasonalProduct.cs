using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class SeasonalProduct
    {
        private int id;
        private string name;
        private decimal price;
        private bool active;
        private bool canBeBoughtOnCredit;
        DateTime seasonStartDate;
        DateTime seasonEndDate;

        //Constructor
        public SeasonalProduct(int Id, string Name, decimal Price, bool Active, bool CanBeboughtOnCredit, DateTime SeasonStartdate, DateTime SeasonEndDate)
        {
            id = Id;
            name = Name;
            price = Price;
            active = Active;
            canBeBoughtOnCredit = CanBeboughtOnCredit;
            seasonStartDate = SeasonStartdate;
            seasonEndDate = SeasonEndDate;
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

        public DateTime SeasonStartDate
        {
            get { return seasonStartDate; }
            set { seasonStartDate = value; }
        }

        public DateTime SeasonEndDate
        {
            get { return seasonEndDate; }
            set { seasonEndDate = value; }
        }
    }
}