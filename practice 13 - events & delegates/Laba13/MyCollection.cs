using System;

namespace Laba13
{

    public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);

    public class MyCollection<T> : BDList<T>
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BDPoint<T> this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count) throw new IndexOutOfRangeException();
                else
                {
                    if (index == 0) return this.Beg;
                    if (index == this.Count - 1) return this.End;

                    BDPoint<T> temp = this.Beg;
                    int val = 0;

                    while (temp.next != null && val != index)
                    {
                        temp = temp.next;
                        val++;
                    }

                    return temp;
                }
            }
            set
            {
                if (index == 0) this.Beg.data = value.data;
                if (index == this.Count - 1) this.End.data = value.data;

                else
                {
                    BDPoint<T> temp = this.Beg;
                    int val = 0;

                    while (temp.next != null && val != index)
                    {
                        temp = temp.next;
                        val++;
                    }

                    temp.data = value.data;
                }

                OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this[index], Name, "Element changed"));
            }
        }


        public MyCollection() : base()
        {
            name = "empty";
        }

        public MyCollection(string n, int capacity) : base(capacity)
        {
            name = n;
        }

        public MyCollection(string n, params T[] array) : base(array)
        {
            name = n;
        }


        public override void Add(int position, T element)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(element, Name, "Element added"));
            base.Add(position, element);
        }

        public override void AddToBegin(T element)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(element, Name, "Element added"));
            base.AddToBegin(element);
        }

        public override void AddToEnd(T element)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(element, Name, "Element added"));
            base.AddToEnd(element);
        }

        public bool Remove(int index)
        {
            if (this == null || index > this.Count - 1) return false;

            // Генерация события через обработчик
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this[index], this.Name, "Element deleted"));

            BDPoint<T> temp = this[index];

            bool deleted = this.DeleteElement(temp.data);

            return deleted;
        }


        // События
        public event CollectionHandler CollectionCountChanged;     // Добавление или удаление эл-та
        public event CollectionHandler CollectionReferenceChanged; // Эл-т был изменен

        // Обработчики событий
        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionCountChanged != null)
                CollectionCountChanged(source, args);
        }
        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChanged != null)
                CollectionReferenceChanged(source, args);
        }
    }
}
