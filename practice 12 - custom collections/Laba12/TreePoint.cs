using MyLibrary;

namespace Laba12
{
    public class TreePoint
    {
        public Person data;
        public TreePoint left;
        public TreePoint right;

        public TreePoint()
        {
            data = null;
            left = null;
            right = null;
        }

        public TreePoint(Person d)
        {
            data = d;
            left = null;
            right = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
