using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8_PokemonTrainer
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, Trainer> trainers=new Dictionary<string, Trainer>();
            while (true)
            {
                var command = Console.ReadLine();

                if (command== "Tournament")
                {
                    break;
                }

                if (command!= "Tournament" || command!= "Fire" || command!= "Electricity")
                {
                    var elements = command.Trim().Split();
                    var name = elements[0];
                    var pokemonName = elements[1];
                    var pokemonElement = elements[2];
                    var pokemonHealth = int.Parse(elements[3]);

                    Pokemon pokemon=new Pokemon(pokemonName,pokemonElement,pokemonHealth);
                    if (trainers.ContainsKey(name))
                    {
                        trainers[name].AddPokemon(pokemon);
                    }
                    else
                    {
                        trainers.Add(name,new Trainer(name));
                        trainers[name].AddPokemon(pokemon);
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    trainer.Value.AddBadge(command);
                }
            }

            var result = trainers.OrderByDescending(t => t.Value.Number).ToList();

            foreach (var trainer in result)
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Number} {trainer.Value.Pokemons.Where(p=>p.Health>0).ToList().Count}");
            }
        }
    }
}
