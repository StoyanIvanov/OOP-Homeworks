using System;
using System.Collections.Generic;

namespace Problem5_PizzaCalories
{
    public class Topping
    {
        private Dictionary<string, double> types = new Dictionary<string, double> {
            { "meat", 1.2},
            { "veggies", 0.8},
            { "cheese",1.1},
            { "sauce", 0.9}
        };
        private string type;
        private double weight;
        private double coloriesPerGram = 2;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (!types.ContainsKey(value.ToLower()))
                {
                    throw new KeyNotFoundException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value; ;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new IndexOutOfRangeException($"{this.type} weight should be in the range[1..50].");
                }
                this.weight = value;
            }
        }

        public double Calories
        {
            get
            {
                return this.coloriesPerGram;
            }
            protected set
            {
                this.coloriesPerGram = value;
            }
        }

        public double GetCalories()
        {
            return (types[type] * coloriesPerGram * weight);
        }
    }
}
