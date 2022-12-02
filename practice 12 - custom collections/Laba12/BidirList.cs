using System;
using MyLibrary;

namespace Laba12
{
    public class BDList  // Bidirectional List, двунаправленный список
    {
        BDPoint beg = null;

        public BDPoint Beg
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
                BDPoint p = beg;
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

        public BDList(params Person[] arr)
        {
            beg = new BDPoint(arr[0]);
            BDPoint p = beg;

            for(int i = 1; i < arr.Length; i++)
            {
                BDPoint temp = new BDPoint(arr[i]);
                p.next = temp;
                temp.previous = p;
                p = temp;
            }
        }

        public void Delete()
        {
            while (beg != null)
            {
                beg = beg.next;
            }
        }

        public void DeleteByKurs(int kurs)
        {
            if (beg == null)
            {
                Console.WriteLine("Список пустой");
                return;
            }

            if(Length == 1)
            {
                Student s = beg.data as Student;

                if (s != null && s.Kurs == kurs)
                {
                    beg = beg.next;
                }
                else Console.WriteLine("Нет элементов для удаления");
                return;
            }

            BDPoint p = beg.next;
            while(p.next != null)
            {
                Student s = p.data as Student;

                if(s != null && s.Kurs == kurs)
                {
                    p.previous.next = p.next;
                    p.next.previous = p.previous;
                }
                p = p.next;
            }

            Student student = p.data as Student;
            if (student != null && student.Kurs == kurs)
            {
                p.previous.next = null;
            }
        }

        public void Print()
        {
            if (beg == null)
            {
                Console.WriteLine("Пустой список");
                return;
            }

            BDPoint p = beg;

            while (p != null)
            {
                Console.Write(p);
                p = p.next;
            }
        }
    }
}
