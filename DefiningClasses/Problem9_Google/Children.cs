using System;

namespace Problem9_Google
{
    public class Children
    {
        private string name;
        private string burthDate;

        public Children(string name, string burthDate)
        {
            this.name = name;
            this.burthDate = burthDate;
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public string BurthDate
        {
            get { return burthDate; }
            private set { }
        }
    }
}
