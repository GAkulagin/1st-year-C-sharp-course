using MyLibrary;

namespace Laba12
{
    public class BDPoint  // Эл-т двунаправленного списка
    {
        public Person data;
        public BDPoint next;
        public BDPoint previous;

        public BDPoint()
        {
            data = null;
            next = null;
            previous = null;
        }

        public BDPoint(Person d)
        {
            data = d;
            next = null;
            previous = null;
        }

        public override string ToString()
        {
            return data.ToString() + "\n";
        }
    }
}
