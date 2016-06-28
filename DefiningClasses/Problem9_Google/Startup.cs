using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem9_Google
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<string,Person> persons=new Dictionary<string, Person>();
            while (true)
            {
                var elements = Console.ReadLine().Trim().Split();
                if (elements[0] == "End")
                {
                    break;
                }

                var name = elements[0];
                if (!persons.ContainsKey(name))
                {
                    Person person = new Person(name);
                    persons.Add(name,person);
                }

                var command = elements[1];

                if (command == "company")
                {
                    persons[name].AddCompany(elements[2], elements[3], double.Parse(elements[4], CultureInfo.InvariantCulture));
                }

                if (command=="car")
                {
                    persons[name].AddCar(elements[2],elements[3]);
                }

                if (command=="pokemon")
                {
                    persons[name].AddPokemon(new Pokemon(elements[2],elements[3]));
                }

                if (command == "parents")
                {
                    var dateElements = elements[3];
                    persons[name].AddParent(new Parent(elements[2], dateElements));
                }

                if (command == "children")
                {
                    var dateElements = elements[3];
                    persons[name].AddChildren(new Children(elements[2], dateElements));
                }
            }

            var inputName = Console.ReadLine();

            var searchPerson = persons.FirstOrDefault(p => p.Key == inputName);

            Console.WriteLine($"{searchPerson.Value.Name}");
            Console.WriteLine("Company:");
            if (!string.IsNullOrEmpty(searchPerson.Value.Company))
            {
                Console.WriteLine($"{searchPerson.Value.Company} {searchPerson.Value.Possition} {searchPerson.Value.Salary:0.00}");
            }

            Console.WriteLine("Car:");
            if (!string.IsNullOrEmpty(searchPerson.Value.Car))
            {
                Console.WriteLine($"{searchPerson.Value.Car}");
            }
            
            Console.WriteLine("Pokemon:");
            foreach (var pokemon in searchPerson.Value.Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Element}");
            }
            Console.WriteLine("Parents:");
            foreach (var parent in searchPerson.Value.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.BurthDate}");
            }
            Console.WriteLine("Children:");
            foreach (var children in searchPerson.Value.Childrens)
            {
                Console.WriteLine($"{children.Name} {children.BurthDate}");
            }
        }
    }
}
