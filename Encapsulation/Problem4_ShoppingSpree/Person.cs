using System;
using System.Collections.Generic;

namespace Problem4_ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double money)
        {
            products=new List<Product>();
            this.Name = name;
            this.Money = money;
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

        public double Money
        {
            get { return this.money; }
            private set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products
        {
            get { return products; }
        }

        public bool BayProduct(Product product)
        {
            if (money >= product.Cost)
            {
                money = money - product.Cost;
                products.Add(product);
                return true;
            }
            else
            {
                Startup.PrintConsoleMessage($"{this.name} can't afford {product.Name}");
            }
            return false;
        }
    }
}
