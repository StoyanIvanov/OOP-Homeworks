namespace Problem6_RawData
{
    public class Tire
    {
        private double tirePressure;
        private int tireAge;

        public Tire(double tirePressur, int tireAge)
        {
            this.tirePressure = tirePressur;
            this.tireAge = tireAge;
        }

        public double Presure
        {
            get { return tirePressure; }
            private set { }
        }

    }
}
