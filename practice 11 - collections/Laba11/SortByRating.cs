using System.Collections;
using MyLibrary;

namespace Laba11
{
    class SortByRating : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Student s1 = (Student)x;
            Student s2 = (Student)y;

            return s1.Rating.CompareTo(s2.Rating);
        }
    }
}
