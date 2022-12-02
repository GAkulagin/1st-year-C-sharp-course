using System;
using System.Text.RegularExpressions;

namespace MyLibrary
{

    public class Employee : Person, ICloneable, IExecutable
    {
        protected string job;
        protected int salary;

        public string Job
        {
            set
            {
                Regex pattern = new Regex(@"(?i)[а-я]+");
                if (pattern.IsMatch(value))
                    job = value;
                else job = "Incorrect input";
            }
            get { return job; }
        }
        public int Salary
        {
            set
            {
                if (value > 0) salary = value;
                else salary = 0;
            }
            get { return salary; }
        }
        public override Person BasePerson
        {
            get { return new Person(name, age); }
        }

        public Employee() : base()
        {
            job = "";
            salary = 0;
        }
        public Employee(string n, int a, string j, int s) : base(n, a)
        {
            Job = j;
            Salary = s;
        }

        public override void Input()
        {
            base.Input();

            bool check = false;

            do
            {
                Console.WriteLine("Введите должность работника");
                this.Job = Console.ReadLine();

                if (this.job != "Incorrect input") check = true;
                else Console.WriteLine("Неверный ввод данных");

            } while (!check);  // Ввод должности

            check = false;

            do
            {
                int value;

                Console.WriteLine("Введите зарплату работника");
                check = int.TryParse(Console.ReadLine(), out value);
                if (!check) Console.WriteLine("Неверный ввод данных");

                else if (check)
                {
                    this.Salary = value;
                    if (this.salary == 0)
                    {
                        check = false;
                        Console.WriteLine("Неверный ввод данных");
                    }
                    else check = true;
                }
            } while (!check); // Ввод зарплаты
        }
        public override void Show()
        {
            base.Show();
            string output = String.Format("  Должность: {0, -25}  з/п: {1, 6} руб.", job, salary);
            Console.Write(output);
        }

        new public object Clone()
        {
            Employee e = new Employee();

            e.Name = this.Name;
            e.Age = this.Age;
            e.Job = this.Job;
            e.Salary = this.Salary;

            return e;
        }

        public override bool Equals(object obj)
        {
            Employee e = obj as Employee;

            if (e == null) return false;
            else return e.name == this.name && e.job == this.job && e.salary == this.salary && e.age == this.age;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + job.GetHashCode() + salary.GetHashCode() + age.GetHashCode();
        }
        public override string ToString()
        {
            return name + " " + age + " " + job + " " + salary;
        }
    }
}
