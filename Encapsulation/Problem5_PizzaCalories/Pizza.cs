using System.Collections.Generic;
using System;
namespace Problem5_PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dought;

        public Pizza(string name, Dough dought)
        {
            this.Name = name;
            this.dought = dought;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The pizza name cannot be null or empty string");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings()
        {
            return toppings.Count;
        }

        public double TotalCalories()
        {
            double calories = dought.GetCalories();

            foreach (var topping in toppings)
            {
                calories = calories + topping.GetCalories();
            }
            return calories;
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }
    }
}
