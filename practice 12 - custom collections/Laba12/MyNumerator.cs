using System.Collections;
using System.Collections.Generic;

namespace Laba12
{
    class MyNumerator<T> : IEnumerator<T>
    {
        MyColPoint<T> beg;      // Первый эл-т нумератора
        MyColPoint<T> current;  // Текущий эл-т нумератора

        public T Current
        {
            get { return current.data; }
        }

        // Это свойство нужно для реализации наследования 
        object IEnumerator.Current
        {
            get { return current; }
        }

        // Создание объекта нумератора
        public MyNumerator(MyCollection<T> list)
        {
            beg = list.Beg;
            current = null;
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (current == null) current = beg;
            else current = current.next;

            return current != null;
        }

        public void Reset()
        {
            current = beg;
        }
    }
}
