using System;

namespace Lab2Task3
{
    class task3  // Найти кол-во цифр в десятичном числе K.
    {
        static void Main(string[] args)
        {
            string input;             // хранилище для вводимых данных
            int number;               // число
            int amountOfDigits = 0;   // кол-во цифр в числе
            bool checkInput;          // проверка правильности ввода

            // ввод данных
            Console.WriteLine("Введите целое число");
            do
            {
                input = Console.ReadLine();
                checkInput = int.TryParse(input, out number);
                if (checkInput)
                    number = int.Parse(input);
                else Console.WriteLine("Ошибка! Число введено неверно");
            } while (!checkInput);

            // подсчет цифр в числе
            if (number == 0)
                amountOfDigits = 1;
           else while(number != 0)
            {
                number /= 10;
                amountOfDigits++;
            }

            // вывод данных
            Console.WriteLine("Количество цифр в введенном числе: " + amountOfDigits);
        }
    }
}
