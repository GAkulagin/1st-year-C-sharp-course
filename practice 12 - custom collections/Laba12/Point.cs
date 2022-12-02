using MyLibrary;

namespace Laba12
{
    public class UDPoint // Undirectional Point, эл-т однонапрвленного списка
    {
        public Person data;   // информационное поле
        public UDPoint next;  // адрес след. объекта

        public UDPoint()
        {
            data = null;
            next = null;
        }

        public UDPoint(Person d)
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString() + "\n";
        }
    }
}
