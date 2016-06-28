
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
    public class Startup
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < inputLines; i++)
            {
                var inputElements = Console.ReadLine().Trim().Split();
                Person person = new Person(inputElements[0], int.Parse(inputElements[1]));
                persons.Add(person);
            }

            var result = persons.Where(p => p.Age > 30).OrderBy(p => p.Name);
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }


        }
    }

}
