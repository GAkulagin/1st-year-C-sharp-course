using System;
using System.Text.RegularExpressions;

namespace Laba10
{
    public class Person : IExecutable
    {
        protected string name;

        public string Name
        {
            set
            {
                Regex pattern = new Regex(@"(?i)[а-я]+ (?i)[а-я]+");

                if (pattern.IsMatch(value))
                    name = value;
                else name = "";
            }
            get { return name; }
        }

        public Person()
        {
            name = "";
        }
        public Person(string n)
        {
            Name = n;
        }

        public virtual void Show()
        {
            Console.Write(name + ";    ");
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;

            if (p == null) return false;
            else return p.name == this.name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name = {name}";
        }
    }
}
