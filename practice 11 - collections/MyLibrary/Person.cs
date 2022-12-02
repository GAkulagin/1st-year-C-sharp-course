using System;
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class Person : IExecutable, ICloneable, IComparable
    {
        protected string name;
        protected int age;

        public string Name
        {
            set
            {
                Regex pattern = new Regex(@"(?i)[а-я]+ (?i)[а-я]+ (?i)[а-я]+");

                if (pattern.IsMatch(value))
                    name = value;
                else name = "Incorrect input";
            }
            get { return name; }
        }
        public int Age
        {
            set 
            {
                if (value >= 1 && value <= 150)
                    age = value;
                else age = 0;
            }
            get { return age; }
        }
        public virtual Person BasePerson
        {
            get { return this; }
        }
        public Person()
        {
            name = "";
            age = 0;
        }
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public object Clone()
        {
            Person p = new Person();

            p.Name = this.Name;
            p.Age = this.Age;

            return p;
        }

        public int CompareTo(object x)
        {
            Person p = (Person)x;
            p = p.BasePerson;

            if (this.name != p.name) return String.Compare(this.name, p.name);
            else
            {
                if (this.GetHashCode() < p.GetHashCode()) return -1;
                if (this.GetHashCode() > p.GetHashCode()) return 1;
                else return 0;
            }
        }

        public virtual void Input()
        {
            bool check = false;
            do
            {
                Console.WriteLine("Введите ФИО человека");
                this.Name = Console.ReadLine();

                if (this.name != "Incorrect input") check = true;
                else Console.WriteLine("Неверный ввод данных");

            } while (!check);

            check = false;
            do
            {
                int value;
                Console.WriteLine("Введите возраст человека");
                check = int.TryParse(Console.ReadLine(), out value);
                if(!check) Console.WriteLine("Неверный ввод данных");
                else
                {
                    this.Age = value;
                    if(age == 0)
                    {
                        check = false;
                        Console.WriteLine("Неверный ввод данных");
                    }
                    else check = true;
                }               

            } while (!check);
        }
        public virtual void Show()
        {
            string output = String.Format("{0, -35}  возраст: {1, 3}", name, age);
            Console.Write(output);
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;

            if (p == null) return false;
            else return p.name == this.name && p.age == this.age;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + age.GetHashCode();
        }
        public override string ToString()
        {
            return name + " " + age;
        }
    }
}

