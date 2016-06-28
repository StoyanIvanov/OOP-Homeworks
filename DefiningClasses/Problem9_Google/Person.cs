using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Problem9_Google
{
    public class Person
    {
        private string name;
        private string companyName;
        private double salary;
        private string possition;
        private string car;
        private List<Parent> parents;
        private List<Children> childrens;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.name = name;
            this.parents = new List<Parent>();
            this.childrens = new List<Children>();
            this.pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public string Company {
            get { return this.companyName; }
            private set { }
        }

        public double Salary {
            get { return salary; }
            private set { }
        }

        public string Possition
        {
            get { return this.possition; }
            private set { }
        }

        public string Car
        {
            get { return this.car; }
            private set { }
        }

        public List<Parent> Parents {
            get { return this.parents;}
            private set { }
        }

        public List<Children> Childrens
        {
            get { return this.childrens; }
            private set { }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            private set { }
        }

        public void AddCompany(string companyName, string possition, double salary)
        {
            this.companyName = companyName;
            this.possition = possition;
            this.salary = salary;
        }

        public void AddCar(string car, string carModel)
        {
            this.car = car + " " + carModel;
        }

        public void AddParent(Parent parent)
        {
            this.parents.Add(parent);
        }

        public void AddChildren(Children children)
        {
            this.childrens.Add(children);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

    }
}
