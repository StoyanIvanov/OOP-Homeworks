namespace Problem7_CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = string.IsNullOrEmpty(efficiency) ? "n/a" : efficiency;
        }

        public string Model
        {
            get { return this.model; }
            private set { }
        }

        public int Power
        {
            get { return this.power; }
            private set { }
        }

        public string Displacement
        {
            get
            {
                if (displacement!=0)
                {
                    return displacement.ToString();
                }
                return "n/a";
            }
            private set { }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            private set { }
        }
    }
}
