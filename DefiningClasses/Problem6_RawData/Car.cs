using System.Collections.Generic;
using System.Xml;

namespace Problem6_RawData
{
    public class Car
    {
        private string carName;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string carName, Engine engine, Cargo cargo, Tire tire1, Tire tire2, Tire tire3, Tire tire4)
        {
            this.tires=new List<Tire>();
            this.carName = carName;
            this.engine = engine;
            this.cargo = cargo;
            this.tires.Add(tire1);
            this.tires.Add(tire2);
            this.tires.Add(tire3);
            this.tires.Add(tire4);
        }

        public string Name
        {
            get { return this.carName; }
            private set { }
        }

        public Engine Engine
        {
            get { return this.engine; }
            private set { }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            private set { }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
            private set { }
        }
    }
}
