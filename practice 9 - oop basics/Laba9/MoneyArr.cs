using System;
using System.Collections.Generic;
using System.Text;

namespace Laba9
{
    public class MoneyArr
    {
        Money[] array;

        public int Length
        {
            get { return array.Length; }
        }
        public Money this[int index]
        {
            get 
            { 
                if (index >= 0 && index < array.Length) return array[index];
                else throw new IndexOutOfRangeException();
            }
            set { array[index] = value; }
        }

        public MoneyArr()
        {
            array = new Money[0];
        }
        public MoneyArr(int size)
        {
            array = new Money[size];
            Random rand = new Random();

            for(int i = 0; i < size; i++)
            {
                int roubles = rand.Next(0, 101);
                int kopeks = rand.Next(0, 100);
                array[i] = new Money(roubles, kopeks);
            }
        }
        public MoneyArr(int size, int[] roubles, int[] kopeks)
        {
            array = new Money[size];

            for(int i = 0; i < size; i++)
                array[i] = new Money(roubles[i], kopeks[i]);          
        }

        public static double ArithAverage(MoneyArr array) // среднее арифметическое
        {
            double sum = 0.0;

            for (int i = 0; i < array.Length; i++) 
            {
                double kopeks = array[i].Kopeks * 0.01;
                int roubles = array[i].Roubles;
                double money = roubles + kopeks;
                sum += money;
            }

            double result = sum / array.Length;
            return result;
        }

        public void Show()
        {
            foreach (Money item in array)
            {
                item.Show();
            }
        }
    }
}
