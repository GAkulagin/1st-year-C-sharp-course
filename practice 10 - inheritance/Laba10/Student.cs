    using System;

namespace Laba10
{
    public class Student : Person, ICloneable
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

        public Student() : base()
        {
            kurs = 0;
            rating = 0;
        }
        public Student(string n, int k, int r) : base(n)
        {
            Kurs = k;
            Rating = r;
        }

        public override void Show()
        {
            base.Show();
            Console.Write($"Курс: {kurs};    Mесто в рейтинге: {rating}");
        }

        public object Clone()
        {
            Student s = new Student();

            s.Name = this.Name;
            s.Kurs = this.Kurs;
            s.Rating = this.Rating;

            return s;
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;

            if (s != null) return false;
            else return s.name == this.name && s.kurs == this.kurs && s.rating == this.rating;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + kurs.GetHashCode() + rating.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name = {name}, kurs = {kurs}, rating = {rating}";
        }
    }
}
    
