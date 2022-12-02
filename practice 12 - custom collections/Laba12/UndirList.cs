using System;
using MyLibrary;

namespace Laba12
{
    public class UDList  // Undirectional list, однонапр. список
    {
        UDPoint beg = null;  // Начальный эл-т списка 

        public UDPoint Beg
        {
            get { return beg; }
            set { beg = value; }
        }

        public int Length
        {
            get
            {
                if (beg == null) return 0;
                int len = 0;
                UDPoint p = beg;
                while (p != null)
                {
                    p = p.next;
                    len++;
                }
                return len;
            }
        }

        // Создать пустой список
        public UDList()
        {
            beg = null;
        }
        // Создать список из указанных элементов
        public UDList(params Person[] mas)
        {
            beg = new UDPoint(mas[0]);
            UDPoint p = beg;

            for (int i = 1; i < mas.Length; i++)
            {
                UDPoint temp = new UDPoint(mas[i]);
                p.next = temp;
                p = temp;
            }
        }

        public bool AddAfter(Person person, string key)
        {
            UDPoint p = new UDPoint(person);

            // Если список пуст
            if(beg == null)
            {
                beg = p;
                return true;
            }
            if(Length == 1 && Beg.data.Name == key)
            {
                beg.next = p;
                return true;
            }
            if (Length == 1 && Beg.data.Name != key)
            {
                return false;
            }
            // Проверить первый эл-т
            if (Beg.data.Name == key)
            {
                p.next = beg.next;  // Связать новый эл-т со вторым эл-том в списке (теперь уже с третьим)
                beg.next = p;       // Связать первый и новый
                return true;
            }
            // Проверить со 2-го по предпоследний эл-ты
            UDPoint temp = beg.next;
            while (temp.next != null && temp.data.Name != key) temp = temp.next;
            // Проверить последний эл-т
            if (temp.data.Name != key) return false;
            // Эл-т найден, вставка
            p.next = temp.next;
            temp.next = p;
            return true;
        }

        public void Print()
        {
            if (beg == null)
            {
                Console.WriteLine("Пустой список");
                return;
            }

            UDPoint p = beg;

            while (p != null)
            {
                Console.Write(p);
                p = p.next;
            }
        }

        public void Delete()
        {
            while (beg != null)
                beg = beg.next;
        }
    }
}
