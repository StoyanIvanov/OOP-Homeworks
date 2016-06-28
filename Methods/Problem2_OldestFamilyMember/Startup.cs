using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Problem2_OldestFamilyMember
{
    public class Startup
    {
        static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var numberOfLine = int.Parse(Console.ReadLine());
            Family family=new Family();

            for (int i = 0; i < numberOfLine; i++)
            {
                var inputLine = Console.ReadLine().Trim().Split();
                Person person=new Person(inputLine[0], int.Parse(inputLine[1]));
                family.AddMember(person);
            }

            var result = family.GetOldestMember();
            Console.WriteLine($"{result.Name} {result.Age}");

        }
    }

    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }

        public Person GetOldestMember()
        {
            Person olderPerson = persons.OrderByDescending(p => p.Age).FirstOrDefault();
            return olderPerson;
        }
    }

    public class Person
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string  Name {
            get { return name; }
            private set { }
        }

        public int Age
        {
            get { return age; }
            private set { }
        }
    }
}
