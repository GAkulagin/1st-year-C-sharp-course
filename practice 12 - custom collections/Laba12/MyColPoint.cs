

namespace Laba12
{
    // Обобщенный двунаправленный список
    public class MyColPoint<T>
    {
        public T data;
        public MyColPoint<T> next;
        public MyColPoint<T> previous;

        public MyColPoint()
        {
            data = default(T);
            next = null;
            previous = null;
        }

        public MyColPoint(T d)
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
