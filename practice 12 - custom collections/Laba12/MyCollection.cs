using System.Collections;
using System.Collections.Generic;

namespace Laba12
{
    // Двунаправленный список
    public class MyCollection<T> : IEnumerable<T>
    {
        MyColPoint<T> beg = null;

        public MyColPoint<T> Beg
        {
            get { return beg; }
            set { beg = value; }
        }

        public MyColPoint<T> End
        {
            get
            {
                if (beg == null) return beg;

                MyColPoint<T> p = beg;

                while (p.next != null) p = p.next;

                return p;
            }
        }

        public int Count
        {
            get
            {
                if (beg == null) return 0;

                int len = 0;
                MyColPoint<T> p = beg;

                while (p != null)
                {
                    p = p.next;
                    len++;
                }

                return len;
            }
        }


        public MyCollection()
        {
            beg = null;
        }

        public MyCollection(int capacity)
        {
            beg = new MyColPoint<T>();
            MyColPoint<T> p = beg;

            for(int i = 1; i < capacity; i++)
            {
                MyColPoint<T> temp = new MyColPoint<T>();
                p.next = temp;
                temp.previous = p;
                p = temp;
            }
        }

        public MyCollection(params T[] arr)
        {
            if (arr == null) beg = null;

            beg = new MyColPoint<T>(arr[0]);
            MyColPoint<T> p = beg;

            for(int i = 1; i < arr.Length; i++)
            {
                MyColPoint<T> temp = new MyColPoint<T>(arr[i]);
                p.next = temp;
                temp.previous = p;
                p = temp;
            }
        }


        public void Add(int position, T element)
        {
            MyColPoint<T> p = new MyColPoint<T>(element);

            if(beg == null)
            {
                beg = p;

                return;
            }

            if(position > Count)
            {
                MyColPoint<T> last = End;
                last.next = p;
                p.previous = last;

                return;
            }

            if(position == 1)
            {
                p.next = beg;
                beg.previous = p;
                beg = p;

                return;
            }

            int counter = 1;
            MyColPoint<T> temp = beg;

            while(counter != position)
            {
                temp = temp.next;
                counter++;
            }

            // Связать новый и предыдущий эл-ты
            temp.previous.next = p;
            p.previous = temp.previous;
            // Связать новый и текущий эл-ты
            temp.previous = p;
            p.next = temp;         
        }

        public void AddToBegin(T element)
        {
            MyColPoint<T> p = new MyColPoint<T>(element);

            if(beg == null)
            {
                beg = p;
                return;
            }

            p.next = beg;
            beg.previous = p;
            beg = p;
        }

        public void AddToEnd(T element)
        {
            MyColPoint<T> p = new MyColPoint<T>(element);

            if(beg == null)
            {
                beg = p;
                return;
            }

            MyColPoint<T> last = End;
            last.next = p;
            p.previous = last;
        }

        public void Delete()
        {
            while (beg != null) beg = beg.next;
        }

        public bool DeleteElement(T value)
        {
            if(Count == 1 && beg.data.Equals(value))
            {
                beg = null;
                return true;
            }

            if (Count == 1 && !beg.data.Equals(value)) return false;

            if (beg.data.Equals(value))
            {
                beg = beg.next;
                return true;
            }

            MyColPoint<T> temp = beg.next;

            while (!temp.Equals(End))
            {
                if (temp.data.Equals(value))
                {
                    temp.previous.next = temp.next;
                    temp.next.previous = temp.previous;
                    return true;
                }
                temp = temp.next;
            }
            // Здесь temp = end
            if (!temp.data.Equals(value)) return false;
            else
            {
                temp.previous.next = null;
                return true;
            }
        }

        public MyCollection<T> Clone() 
        {
            if (this.Beg == null) return null;

            MyCollection<T> newList = new MyCollection<T>(this.Count);
            newList.Beg.data = this.Beg.data;

            if (this.Count > 1)
            {
                MyColPoint<T> old = this.Beg.next;
                MyColPoint<T> copy = newList.Beg.next;

                while(old != null)
                {
                    copy.data = old.data;
                    old = old.next;
                    copy = copy.next;
                }
            }

            return newList;
        }

        public MyCollection<T> Copy()
        {
            if (this.Beg == null) return null;

            MyCollection<T> newList = new MyCollection<T>(this.Count);
            newList.Beg = this.Beg;

            if (this.Count > 1)
            {
                MyColPoint<T> old = this.Beg.next;
                MyColPoint<T> copy = newList.Beg.next;

                while (old != null)
                {
                    copy = old;
                    old = old.next;
                    copy = copy.next;
                }
            }

            return newList;
        }

        public MyColPoint<T> Find(T value)
        {
            if (beg == null) return null;

            MyColPoint<T> temp = beg;

            while (temp.next != null && !temp.data.Equals(value)) temp = temp.next;

            if (!temp.data.Equals(value)) return null;

            return temp;
        }


        // Реализация интерфейса нумератора
        // Обобщенный интерфейс наследуется от обычного
        // Поэтому нужны два метода
        public IEnumerator<T> GetEnumerator()
        {
            return new MyNumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
