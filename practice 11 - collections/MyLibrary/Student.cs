using System;

namespace MyLibrary
{

    public class Student : Person, ICloneable, IExecutable
    {
        protected int kurs;
        protected int rating;

        public int Kurs
        {
            set
            {
                if (value >= 1 && value <= 4)
                    kurs = value;
                else kurs = 0;
            }
            get { return kurs; }
        }
        public int Rating
        {
            set
            {
                if (value > 0)
                    rating = value;
                else rating = 0;
            }
            get { return rating; }
        }
        public override Person BasePerson
        {
            get { return new Person(name, age); }
        }

        public Student() : base()
        {
            kurs = 0;
            rating = 0;
        }
        public Student(string n, int a, int k, int r) : base(n, a)
        {
            Kurs = k;
            Rating = r;
        }

        public override void Input()
        {
            base.Input();

            bool check = false;

            do
            {
                int value;

                Console.WriteLine("Введите курс обучения");
                check = int.TryParse(Console.ReadLine(), out value);
                if (!check) Console.WriteLine("Неверный ввод данных");

                else
                {
                    this.Kurs = value;
                    if (this.kurs == 0)
                    {
                        check = false;
                        Console.WriteLine("Неверный ввод данных");
                    }
                    else check = true;
                }
            } while (!check);  // ввод курса

            check = false;

            do
            {
                int value;

                Console.WriteLine("Введите рейтинг студента");
                check = int.TryParse(Console.ReadLine(), out value);
                if (!check) Console.WriteLine("Неверный ввод данных");

                else if (check)
                {
                    this.Rating = value;
                    if (this.rating == 0)
                    {
                        check = false;
                        Console.WriteLine("Неверный ввод данных");
                    }
                    else check = true;
                }
            } while (!check);  // ввод рейтинга
        }
        public override void Show()
        {
            base.Show();
            string output = String.Format("  Курс: {0}    Рейтинг: {1, 3}", kurs, rating);
            Console.Write(output);
        }

        new public object Clone()
        {
            Student s = new Student();

            s.Name = this.Name;
            s.Age = this.Age;
            s.Kurs = this.Kurs;
            s.Rating = this.Rating;

            return s;
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;

            if (s == null) return false;
            else return s.name == this.name && s.kurs == this.kurs && s.rating == this.rating && s.age == this.age;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + age.GetHashCode() + kurs.GetHashCode() + rating.GetHashCode();
        }
        public override string ToString()
        {
            return name + " " + age + " " + kurs + " " + rating;
        }
    }
}

