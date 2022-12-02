using System;
using System.Collections.Generic;
using System.Text;

namespace Laba9
{
    public class Money
    {
        int roubles;
        int kopeks;

        static int objectsCreated = 0;
        
        public int Kopeks
        {
            get { return kopeks; }
            set
            {
                if (value < 0)
                {
                    Kopeks = 100 + value;
                    Roubles--;             
                }
                else if (value > 0 && value < 100) kopeks = value;
                else
                {
                    roubles += value / 100;
                    kopeks = value % 100;
                }
            }
        }
        public int Roubles
        {
            get { return roubles; }
            set
            {
                if (value < 0)
                {
                    roubles = 0;
                    kopeks = 0;
                }
                else roubles = value;
            }
        }

        public Money()
        {
            roubles = 0;
            kopeks = 0;
            objectsCreated++;
        }
        public Money(int rub, int kop)
        {
            Roubles = rub;
            Kopeks = kop;
            objectsCreated++;
        }

        public void Show()
        {
            Console.WriteLine($"{this.roubles} рублей {this.kopeks} копеек");
        }
        public static void ShowObjectsCounter()
        {
            Console.WriteLine($"Всего создано объектов: {objectsCreated}");
        }

        public Money SubtractKopeks(int deductible)
        {
            Money newPrice = new Money();
            newPrice.Roubles = roubles;
            newPrice.Kopeks = kopeks - deductible;

            return newPrice;
        }

        public static Money operator ++(Money m)
        {
            m.Kopeks++;
            return m;
        }
        public static Money operator --(Money m)
        {
            m.Kopeks--;
            return m;
        }
        public static Money operator -(Money m1, Money m2)
        {
            Money temp = new Money();

            temp.Roubles = m1.roubles;             // иначе 15.90 - 0.99 = 15.00
            temp.Kopeks = m1.kopeks - m2.kopeks;   // копейки вычитаются перед рублями, иначе 15.90 - 16.00 = 0.90
            temp.Roubles -= m2.roubles;            // иначе 15.40 - 1.50 = 14.90
            

            return temp;
        }
        public static Money operator -(Money m, int x)
        {
            Money temp = new Money();
            temp.Roubles = m.roubles;
            temp.Kopeks = m.kopeks - x;

            return temp;
        }
        public static Money operator +(Money m1, Money m2)
        {
            Money temp = new Money();

            temp.Roubles = m1.roubles + m2.roubles;
            temp.Kopeks = m1.kopeks + m2.kopeks;

            return temp;
        }
        public static Money operator +(Money m, int x)
        {
            Money temp = new Money();
            temp.roubles = m.roubles;
            temp.Kopeks = m.kopeks + x;

            return temp;
        }
        public static Money operator +(int x, Money m)
        {
            Money temp = new Money();
            temp.roubles = m.roubles;
            temp.Kopeks = x + m.kopeks;

            return temp;
        }

        public static explicit operator int (Money m)
        {
            return m.roubles;
        }
        public static implicit operator bool (Money m)
        {
            if (m.roubles != 0 || m.kopeks != 0)
                return false;
            else return true;
        }
        public static explicit operator double(Money m)
        {
            return m.roubles + m.kopeks * 0.01;
        }

        public override bool Equals(object obj)
        {
            Money m = obj as Money;
            if (m == null) return false;
            else return m.kopeks == this.kopeks && m.roubles == this.roubles;
        }
    }
}
