using System;

namespace Problem9_Google
{
    public class Parent
    {
        private string name;
        private string burthDate;

        public Parent(string name, string burthDate)
        {
            this.name = name;
            this.burthDate = burthDate;
        }

        public string Name
        {
            get { return this.name; }
            set { }
        }

        public string BurthDate
        {
            get { return burthDate; }
            private set { }
        }

    }
}
