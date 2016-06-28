using System.Collections.Generic;
using System.Linq;

namespace Problem10_Family_Tree
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string burthDate;
        private List<Parent> parents;
        private List<Children> childrens; 

        public Person()
        {
            this.parents = new List<Parent>();
            this.childrens = new List<Children>();
            this.firstName = "";
            this.lastName = "";
            this.burthDate = "";
        }

        public Person(string firstName, string lastName)
        {
            this.parents = new List<Parent>();
            this.childrens=new List<Children>();
            this.firstName = firstName;
            this.lastName = lastName;
            this.burthDate = "";
        }

        public Person(string burthDate)
        {
            this.parents = new List<Parent>();
            this.childrens = new List<Children>();
            this.firstName = "";
            this.lastName = "";
            this.burthDate = burthDate;
        }

        public string Names
        {
            get { return firstName + " " + lastName; }
            private set
            {
                var names = value.Split();
                firstName = names[0];
                lastName = names[1];
            }
        }

        public string BurthDate
        {
            get { return burthDate; }
            set { }
        }

        public List<Parent> Parents
        {
            get { return parents; }
            private set { }
        }

        public List<Children> Childrens
        {
            get { return this.childrens; }
            private set { }
        }

        public void AddNames(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void AddParent(Parent parent)
        {
            parents.Add(parent);
        }

        public void AddChildren(Children children)
        {
            this.childrens.Add(children);
        }

        public void AddBurthDate(string burthDate)
        {
            this.burthDate = burthDate;
        }

        public void CheckTwoDates(string date1, string date2)
        {
            if (this.burthDate=="")
            {
                this.burthDate = date2;
            }

            if (date2==burthDate)
            {
                var parent=new Parent(date1);
                if (parents.Count(p=>p.BurthDate==date1)==0)
                {
                    this.AddParent(parent);
                }
                
            }

            if (date1==burthDate)
            {
                var children=new Children(date2);
                if (childrens.Count(c => c.BurthDate == date2) == 0)
                {
                    this.AddChildren(children);
                }
                
            }
        }

        public void CheckTwoNames(string name1, string name2)
        {
            if (Names==name1)
            {
                var names = name2.Split();
                var children = new Children(names[0], names[1]);

                if (childrens.Count(c=>c.Names==name2)==0)
                {
                    this.AddChildren(children);
                }
                
            }

            if (Names == name2)
            {
                var names = name1.Split();
                var parent = new Parent(names[0], names[1]);
                if (parents.Count(p => p.Names == name1) == 0)
                {
                    this.AddParent(parent);
                }
            }
        }

        public void CheckDateAndName(string date, string name)
        {
            if (Names==" ")
            {
                Names = name;
            }
            if (this.Names==name)
            {
                var parent = new Parent(date);
                if (parents.Count(p=>p.BurthDate==date)==0)
                {
                    this.AddParent(parent);
                }
                
            }

            if (this.burthDate==date)
            {
                var names = name.Split();
                var children = new Children(names[0], names[1]);
                if (childrens.Count(c => c.Names == name) == 0)
                {
                    this.AddChildren(children);
                }
                
            }
        }

        public void CheckNameAndData(string name, string date)
        {
            if (burthDate=="")
            {
                burthDate = date;
            }
            if (date == this.burthDate)
            {
                var names = name.Split();
                var parent=new Parent(names[0], names[1]);
                if (parents.Count(p=>p.Names==name)==0)
                {
                    this.AddParent(parent);
                } 
            }

            if (name==this.Names)
            {
                var children=new Children(date);
                if (childrens.Count(c => c.BurthDate == date) == 0)
                {
                    this.AddChildren(children);
                }

            }
        }

        public void UpdateData(string firstName, string lastName, string date)
        {
            foreach (var parent in parents)
            {
                if (parent.Names==firstName+" "+ lastName)
                {
                    parent.BurthDate = date;
                }

                if (parent.BurthDate==date)
                {
                    parent.Names=firstName + " "+ lastName;
                }
            }

            foreach (var children in childrens)
            {
                if (children.Names == firstName+" "+lastName)
                {
                    children.BurthDate = date;
                }

                if (children.BurthDate == date)
                {
                    children.Names= firstName + " " + lastName;
                }
            }

            if (Names==firstName+" "+ lastName)
            {
                burthDate = date;
            }

            if (BurthDate==date)
            {
                Names = firstName + " " + lastName;
            }
        }
    }
}
