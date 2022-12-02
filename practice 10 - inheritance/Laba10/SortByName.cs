using System;
using System.Collections;

namespace Laba10
{
    public class SortByName : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Student s1 = (Student)x;
            Student s2 = (Student)y;

            return String.Compare(s1.Name, s2.Name);
        }
    }
}
