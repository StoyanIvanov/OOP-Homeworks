using System.Runtime.CompilerServices;

namespace Problem10_Family_Tree
{
    public class Parent
    {
        private string firstName;
        private string lastName;
        private string burthDate;

        public Parent(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.burthDate = "";
        }

        public Parent(string burthDate)
        {
            this.firstName = "";
            this.lastName = "";
            this.burthDate = burthDate;
        }

        public string Names
        {
            get { return firstName + " " + lastName; }
            set
            {
                var names = value.Split();
                firstName = names[0];
                lastName = names[1];
            }
        }

        public string BurthDate
        {
            get { return burthDate; }
            set { this.burthDate = value; }
        }

        public void AddNames(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
