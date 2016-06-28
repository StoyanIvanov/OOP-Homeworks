using System;
using System.Drawing;

namespace Problem7_CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine, string weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = string.IsNullOrEmpty(weight) ? "n/a" : weight;
            this.color = string.IsNullOrEmpty(color) ? "n/a" : color;
        }

        public string Model
        {
            get { return this.model; }
            private set { }
        }

        public Engine Engine
        {
            get { return this.engine; }
            private set { }
        }

        public string Weight
        {
            get { return this.weight; }
            private set { }
        }

        public string Color
        {
            get { return this.color; }
            private set { }
        }
    }
}
