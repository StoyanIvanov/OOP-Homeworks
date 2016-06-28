using System.Collections.Generic;
using System.Linq;

namespace Problem8_PokemonTrainer
{
    public class Trainer
    {

        private string name;
        private int number;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.pokemons = new List<Pokemon>();
            this.name = name;
            this.number = 0;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddBadge(string badge)
        {
            if (pokemons.Where(p => p.Element == badge).ToList().Count>0)
            {
                number++;
            }
            else
            {
                foreach (var pokemon in pokemons)
                {
                    pokemon.Health = pokemon.Health - 10;
                    if (pokemon.Health<=0)
                    {
                        pokemon.Health = 0;
                    }
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public int Number
        {
            get { return this.number; }
            private set { }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            private set { }
        }
    }
}
