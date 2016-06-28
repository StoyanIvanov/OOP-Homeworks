using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_AnimalClinic
{
    public class Animal
    {
        private string name;
        private string bread;

        public Animal(string name, string bread)
        {
            this.name = name;
            this.bread = bread;
        }

        public string Name
        {
            get { return this.name; }
            private set { }
        }

        public string Bread
        {
            get { return this.bread; }
            private set { }
        }
    }
}
