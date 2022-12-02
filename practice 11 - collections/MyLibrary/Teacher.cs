using System;
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class Teacher : Employee, IExecutable, ICloneable
    {
        protected string science;
        protected int seniority;

        public string Science
        {
            set
            {
                Regex pattern = new Regex(@"[а-я]+");
                if (pattern.IsMatch(value))
                    science = value;
                else science = "Incorrect input";
            }
            get { return science; }
        }
        public int Seniority
        {
            set
            {
                if (value >= 0) seniority = value;
                else seniority = -1;
            }
            get { return seniority; }
        }
        public override Person BasePerson
        {
            get { return new Person(name, age); }
        }

        public Teacher() : base()
        {
            science = "";
            seniority = 0;
        }
        public Teacher(string name, int age, string job, int salary, string sc, int s) : base(name, age, job, salary)
        {
            Science = sc;
            Seniority = s;
        }

        new public object Clone()
        {
            Teacher t = new Teacher();

            t.Name = this.Name;
            t.Age = this.Age;
            t.Salary = this.Salary;
            t.Science = this.Science;
            t.Seniority = this.Seniority;
            t.Job = this.Job;

            return t;
        }
        public override void Input()
        {
            base.Input();
            this.Job = "преподаватель";

            bool check = false;

            do
            {
                Console.WriteLine("Введите преподаваемый предмет");
                this.Science = Console.ReadLine();

                if (this.science != "Incorrect input") check = true;
                else Console.WriteLine("Неверный ввод данных");

            } while (!check);  // Ввод предмета

            check = false;

            do
            {
                int value;

                Console.WriteLine("Введите преподавательский стаж в годах");
                check = int.TryParse(Console.ReadLine(), out value);
                if (!check) Console.WriteLine("Неверный ввод данных");

                else if (check)
                {
                    this.Seniority = value;
                    if (this.seniority == -1)
                    {
                        check = false;
                        Console.WriteLine("Неверный ввод данных");
                    }
                    else check = true;
                }
            } while (!check);  // Ввод преподавательского стажа
        }
        public override void Show()
        {
            base.Show();
            string output = String.Format("  Предмет: {0, -25}  Стаж: {1, 2}", science, seniority);
            Console.Write(output);
        }

        public override bool Equals(object obj)
        {
            Teacher t = obj as Teacher;

            if (t == null) return false;
            else return t.name == this.name && t.job == this.job && t.salary == this.salary && t.science == this.science && t.seniority == this.seniority && t.age == this.age;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + job.GetHashCode() + salary.GetHashCode() + science.GetHashCode() + seniority.GetHashCode() + age.GetHashCode();
        }
        public override string ToString()
        {
            return name + " " + age + " " + job + " " + salary + " " + science + " " + seniority;
        }
    }
}
