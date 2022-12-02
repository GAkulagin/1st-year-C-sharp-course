using System;

namespace Lab2Task2
{
    class Task2 //Дана последовательность целых чисел, за которой следует 0.  
                //Найти сумму элементов с нечетными номерами из этой последовательности
    {
        static void Main(string[] args)
        {
            string input;              // хранилище для вводимых данных
            int value;                 // хранилище для допустимых значений
            bool checkValue;           // "флажок" для проверки ввода данных
            int sumOfOddNumbers = 0;   // искомая сумма
            int position = 1;          // позиция элемента

            // ввод и обработка последовательности
            Console.WriteLine("Введите последовательность целых чисел, оканчивающуюся нулем");
            do
            {
                do
                {
                    input = Console.ReadLine();
                    checkValue = int.TryParse(input, out value);
                    if (checkValue)
                        value = int.Parse(input);
                    else Console.WriteLine("Ошибка! Невозможно преобразовать элемент");
                } while (!checkValue);

                if (position % 2 != 0)
                    sumOfOddNumbers += value;
                position++;
            } while (value != 0);

            // вывод данных
            if(sumOfOddNumbers == 0)
                Console.WriteLine("Последовательность пуста");
            else Console.WriteLine("Сумма чисел последовательности, стоящих на нечетных местах, равна " + sumOfOddNumbers);
        }
    }
}
