using System;
using System.Text.RegularExpressions;

namespace Laba10
{
    public class Employee : Person, IComparable, ICloneable
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
                else job = "";
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

        public Employee() : base() 
        {
            job = "";
            salary = 0;
        }
        public Employee(string n, string j, int s) : base(n) 
        {
            Job = j;
            Salary = s;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($"Должность: {job};    з/п: {salary} руб.  ");
        }

        public int CompareTo(object x)
        {
            string str = (string)x;

            if (this.Name == str) return 0;
            else return -1;
        }
        public object Clone()
        {
            Employee e = new Employee();

            e.Name = this.Name;
            e.Job = this.Job;
            e.Salary = this.Salary;

            return e;
        }

        public override bool Equals(object obj)
        {
            Employee e = obj as Employee;

            if (e != null) return false;
            else return e.name == this.name && e.job == this.job && e.salary == this.salary;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + job.GetHashCode() + salary.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name = {name}, job = {job}, salary = {salary}";
        }
    }
}
