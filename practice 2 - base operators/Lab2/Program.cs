using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Kulagin
{
    class Task1  // Дана последовательность из n целых чисел. Найти количество четных элементов этой последовательности
    {
        static void Main(string[] args)
        {
            string str;              // хранилище для вводимых данных
            uint value;              // длина последовательности
            bool checkValue;         // "флажок" для проверки ввода value
            int number;              // хранилище для числа
            int positiveCount = 0;   // счетчик четных чисел

            // ввод длины последовательности
            do
            {
                Console.WriteLine("Введите целое неотрицательное число - длину последовательности");
                str = Console.ReadLine();
                checkValue = uint.TryParse(str, out value);
                if (checkValue)
                    value = uint.Parse(str);
                else Console.WriteLine("Ошибка! Невозможная длина последовательности");
            } while (!checkValue);

            // ввод и обработка последовательности
            if (value == 0)
                Console.WriteLine("Последовательность пуста");
            else
            {
                Console.WriteLine("Введите " + value + " целых чисел");
                for (int i = 0; i < value; i++)
                {
                    do
                    {
                        str = Console.ReadLine();
                        checkValue = int.TryParse(str, out number);
                        if (checkValue)
                            number = int.Parse(str);
                        else Console.WriteLine("Ошибка! Невозможно преобразовать элемент");
                    } while (!checkValue);

                    if (number % 2 == 0)
                        positiveCount++;
                }

                // вывод данных
                if (positiveCount == 0)
                    Console.WriteLine("Четных чисел нет");
                else Console.WriteLine("Количество четных чисел: " + positiveCount);
            }
        }
    }
}