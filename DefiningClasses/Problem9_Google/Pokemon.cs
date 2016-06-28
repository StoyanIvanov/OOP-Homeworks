namespace Problem9_Google
{
    public class Pokemon
    {
        private string name;
        private string element;

        public Pokemon(string name, string element)
        {
            this.name = name;
            this.element = element;
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public string Element
        {
            get { return this.element; }
            private set { }
        }
    }
}
