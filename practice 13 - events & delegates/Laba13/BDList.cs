using System.Collections.Generic;

namespace Laba13
{
    public class BDList<T>
    {
        BDPoint<T> beg = null;

        public BDPoint<T> Beg
        {
            get { return beg; }
            set { beg = value; }
        }

        public BDPoint<T> End
        {
            get
            {
                if (beg == null) return beg;

                BDPoint<T> p = beg;

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
                BDPoint<T> p = beg;

                while (p != null)
                {
                    p = p.next;
                    len++;
                }

                return len;
            }
        }


        public BDList()
        {
            beg = null;
        }

        public BDList(int capacity)
        {
            beg = new BDPoint<T>();
            BDPoint<T> p = beg;

            for (int i = 1; i < capacity; i++)
            {
                BDPoint<T> temp = new BDPoint<T>();
                p.next = temp;
                temp.previous = p;
                p = temp;
            }
        }

        public BDList(params T[] arr)
        {
            if (arr == null) beg = null;

            beg = new BDPoint<T>(arr[0]);
            BDPoint<T> p = beg;

            for (int i = 1; i < arr.Length; i++)
            {
                BDPoint<T> temp = new BDPoint<T>(arr[i]);
                p.next = temp;
                temp.previous = p;
                p = temp;
            }
        }


        public virtual void Add(int position, T element)
        {
            BDPoint<T> p = new BDPoint<T>(element);

            if (beg == null)
            {
                beg = p;

                return;
            }

            if (position > Count)
            {
                BDPoint<T> last = End;
                last.next = p;
                p.previous = last;

                return;
            }

            if (position == 1)
            {
                p.next = beg;
                beg.previous = p;
                beg = p;

                return;
            }

            int counter = 1;
            BDPoint<T> temp = beg;

            while (counter != position)
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

        public virtual void AddToBegin(T element)
        {
            BDPoint<T> p = new BDPoint<T>(element);

            if (beg == null)
            {
                beg = p;
                return;
            }

            p.next = beg;
            beg.previous = p;
            beg = p;
        }

        public virtual void AddToEnd(T element)
        {
            BDPoint<T> p = new BDPoint<T>(element);

            if (beg == null)
            {
                beg = p;
                return;
            }

            BDPoint<T> last = End;
            last.next = p;
            p.previous = last;
        }

        public void Delete()
        {
            while (beg != null) beg = beg.next;
        }

        public bool DeleteElement(T value)
        {
            if (Count == 1 && beg.data.Equals(value))
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

            BDPoint<T> temp = beg.next;

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

        public BDPoint<T> Find(T value)
        {
            if (beg == null) return null;

            BDPoint<T> temp = beg;

            while (temp.next != null && !temp.data.Equals(value)) temp = temp.next;

            if (!temp.data.Equals(value)) return null;

            return temp;
        }

        // Итератор
        public IEnumerator<T> GetEnumerator()
        {
            BDPoint<T> current = beg;

            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }  
    }
}
