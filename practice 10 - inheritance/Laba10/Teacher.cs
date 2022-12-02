using System;
using System.Text.RegularExpressions;

namespace Laba10
{
    public class Teacher : Employee
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
                else science = "";
            }
            get { return science; }
        }
        public int Seniority
        {
            set
            {
                if (value > 0) seniority = value;
                else seniority = 0;
            }
            get { return seniority; }
        }

        public Teacher() : base()
        {
            science = "";
            seniority = 0;
        }
        public Teacher(string name, string job, int salary, string sc, int s) : base(name, job, salary)
        {
            Science = sc;
            Seniority = s;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($"Предмет: {science};    Стаж: {seniority}");
        }

        public override bool Equals(object obj)
        {
            Teacher t = obj as Teacher;

            if (t == null) return false;
            else return t.name == this.name && t.job == this.job && t.salary == this.salary && t.science == this.science && t.seniority == this.seniority;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + job.GetHashCode() + salary.GetHashCode() + science.GetHashCode() + seniority.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name = {name}, job = {job}, science = {science}, seniority = {seniority}, salary = {salary}";
        }
    }
}
