using System;

namespace Problem4_ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new IndexOutOfRangeException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Cost
        {
            get { return this.cost; }
            private set
            {
                if (value<0)
                {
                    throw new IndexOutOfRangeException("Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}
