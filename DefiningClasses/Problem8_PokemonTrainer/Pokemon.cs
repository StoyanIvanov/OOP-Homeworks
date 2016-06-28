namespace Problem8_PokemonTrainer
{
    public class Pokemon
    {

        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public string Element
        {
            get { return element; }
            private set { }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
