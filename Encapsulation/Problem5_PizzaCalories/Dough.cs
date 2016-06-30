using System.Collections.Generic;
using System;
namespace Problem5_PizzaCalories
{
    public class Dough
    {
        private Dictionary<string, double> types = new Dictionary<string, double> {
            { "white", 1.5},
            { "wholegrain", 1.0},
            { "crispy",0.9},
            { "chewy", 1.1},
            { "homemade",1.0}
        };
        private List<string> inputTypes;
        private double weight;
        private double caloriesPerGram = 2;

        public Dough()
        {
            this.inputTypes = new List<string>();
        }

        public Dough(double weight)
        {
            this.inputTypes = new List<string>();
            this.Weight = weight;
        }

        public List<string> Type
        {
            get { return this.inputTypes; }
            private set { }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new IndexOutOfRangeException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double Calories
        {
            get
            {
                return this.caloriesPerGram;
            }
            protected set
            {
                this.caloriesPerGram = value;
            }
        }

        public double GetCalories()
        {
            double calories = caloriesPerGram * weight;

            foreach (var type in inputTypes)
            {
                calories = calories * types[type];
            }

            return calories;
        }

        public void AddDought(string dought)
        {
            dought = dought.ToLower();
            if (!types.ContainsKey(dought))
            {
                throw new KeyNotFoundException("Invalid type of dough.");
            }

            this.inputTypes.Add(dought);


        }
    }
}
