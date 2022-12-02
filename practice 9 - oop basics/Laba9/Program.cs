using System;

namespace Laba9
{
    public class Program
    {
        static int CheckInteger(int minBorder, int maxBorder, string message) // ограничение сверху и снизу
        {
            int value;
            bool checkValue;

            do
            {
                Console.WriteLine(message);
                checkValue = int.TryParse(Console.ReadLine(), out value);

                if (!checkValue)
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                else if ((value > maxBorder) || (value < minBorder))
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                    checkValue = false;
                }

            } while (!checkValue);

            return value;
        }
        static int CheckInteger(int minBorder, string message)  // ограничение снизу
        {
            int value;
            bool checkValue;

            do
            {
                Console.WriteLine(message);
                checkValue = int.TryParse(Console.ReadLine(), out value);

                if (!checkValue)
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                else if (value < minBorder)
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                    checkValue = false;
                }

            } while (!checkValue);

            return value;
        }

        static int MainMenu()
        {
            Console.WriteLine("1 - Работа с объектом");
            Console.WriteLine("2 - Работа с массивом объектов");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();

            int choice = CheckInteger(0, 2, "Выберите действие");

            return choice;
        }
        static void ObjectMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 -  Создать объект");
            Console.WriteLine("2 -  Вычесть копейки (метод класса)");
            Console.WriteLine("3 -  Вычесть копейки (статическая функция)");
            Console.WriteLine("4 -  Уменьшить денежную сумму на копейку");
            Console.WriteLine("5 -  Увеличить денежную сумму на копейку");
            Console.WriteLine("6 -  Вывести количество рублей");
            Console.WriteLine("7 -  Проверить, равна ли денежная сумма нулю");
            Console.WriteLine("8 -  Прибавить копейки (целое число, объект класса)");
            Console.WriteLine("9 -  Прибавить копейки (объект класса, целое число)");
            Console.WriteLine("10 - Вычитание денежных сумм");
            Console.WriteLine("11 - Вывести количество созданных объектов");
            Console.WriteLine("0 -  Завершить работу");
            Console.WriteLine();
        }
        static void CollectionMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 -  Создать массив из случайных чисел");
            Console.WriteLine("2 -  Создать массив вручную");
            Console.WriteLine("3 -  Найти среднее арифметическое эл-тов массива");
            Console.WriteLine("0 -  Завершить работу");
            Console.WriteLine();
        }

        static void InputCollection(int size, out int[] roubles, out int[] kopeks)
        {
            roubles = new int[size];
            kopeks = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Элемент {i + 1} из {size}:");
                roubles[i] = CheckInteger(0, "Введите рубли:");
                kopeks[i] = CheckInteger(0, "Введите копейки:");
                Console.WriteLine();
            }
        }

        public static Money SubstractKopeks(Money price, int kopeks)
        {
            price -= kopeks;
            return price;
        }
        public static double GetArithAverage(MoneyArr array)
        {
            Money sum = new Money();

            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            double result = (double)sum;
            result /= array.Length;
            result = Math.Round(result, 2, MidpointRounding.AwayFromZero);

            return result;
        }

        static void Decision(Money price, string[] phrases)  //  Для работы с объектом
        {
            int choice;

            do
            {
                ObjectMenu();
                choice = CheckInteger(0, 11, phrases[0]);  // "Выберите действие"

                switch (choice)
                {
                    case 1:
                        {
                            int roubles = CheckInteger(0, phrases[1]);     // "Введите рубли:"
                            int kopeks = CheckInteger(0, phrases[2]);  // "Введите копейки:"
                            price = new Money(roubles, kopeks);

                            Console.Write(phrases[3]);                     // "Введенная денежная сумма: "
                            price.Show();

                            break;
                        }
                    case 2:
                        { 
                            int kopeks = CheckInteger(0, phrases[4]);  // "Введите значение:"
                            Money newPrice = price.SubtractKopeks(kopeks);

                            price = newPrice;

                            price.Show();

                            break;
                        }
                    case 3:
                        {
                            int kopeks = CheckInteger(0, phrases[4]);  // "Введите значение:"
                            Money newPrice = SubstractKopeks(price, kopeks);

                            price = newPrice;

                            Console.WriteLine(phrases[8]);             // "Вычитание произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 4:
                        {
                            price--;

                            Console.WriteLine(phrases[8]);            // "Вычитание произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 5:
                        {
                            price++;

                            Console.WriteLine(phrases[10]);           // "Сложение произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 6:
                        {
                            int value = (int)price;

                            Console.WriteLine($"{value} рублей");

                            break;
                        }
                    case 7:
                        {
                            if (price) Console.WriteLine(phrases[5]);  // "Денежная сумма равна нулю"
                            else Console.WriteLine(phrases[6]);        // "Денежная сумма не равна нулю"

                            break;
                        }
                    case 8:
                        {
                            int kopeks = CheckInteger(0, phrases[4]);  // "Введите значение:"

                            price += kopeks;                   

                            Console.WriteLine(phrases[10]);           // "Сложение произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 9:
                        {
                            int kopeks = CheckInteger(0, phrases[4]); // "Введите значение:"

                            price = kopeks + price;

                            Console.WriteLine(phrases[10]);           // "Сложение произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 10:
                        {
                            int roubles = CheckInteger(0, phrases[1]);     // "Введите рубли:"
                            int kopeks = CheckInteger(0, phrases[2]);  // "Введите копейки:"
                            Money money = new Money(roubles, kopeks);

                            price -= money;

                            Console.WriteLine(phrases[8]);            // "Вычитание произведено"
                            Console.Write(phrases[9]);                // "Результат:  "
                            price.Show();

                            break;
                        }
                    case 11:
                        {
                            Money.ShowObjectsCounter();

                            break;
                        }
                }
            } while (choice != 0);

            if (choice == 0)
                return;
        }
        static void Decision(MoneyArr array, string[] phrases) // Для работы с коллекцией объектов
        {
            int choice;

            do
            {
                CollectionMenu();
                choice = CheckInteger(0, 3, phrases[0]);

                switch (choice)
                {
                    case 1:
                        {
                            int size = CheckInteger(0, 101, phrases[11]);  // "Введите размер массива"

                            array = new MoneyArr(size);
                            array.Show();
                            break;
                        }
                    case 2:
                        {
                            int size = CheckInteger(0, 101, phrases[11]);  // "Введите размер массива"
                            int[] roubles;
                            int[] kopeks;

                            InputCollection(size, out roubles, out kopeks);
                            array = new MoneyArr(size, roubles, kopeks);
                            array.Show();
                            break;
                        }
                    case 3:
                        {
                            double arithAverage;

                            if (array.Length == 0)
                                Console.WriteLine("Массив не создан! Создайте массив");
                            else 
                            { 
                                arithAverage = GetArithAverage(array);
                                Console.WriteLine($"Среднее арифметическое объектов массива: {arithAverage} руб.");
                            }

                            break;
                        }
                }
            } while (choice != 0);

            if (choice == 0)
                return;
        }

        static void Main(string[] args)
        {
            Money price = new Money();
            MoneyArr array = new MoneyArr();
            string[] phrases = { 
                "Выберите действие:",                           // phrases[0]
                "Введите рубли:",                               // phrases[1]
                "Введите копейки:",                             // phrases[2]
                "Введенная денежная сумма: ",                   // phrases[3]
                "Введите значение:",                            // phrases[4]
                "Денежная сумма равна нулю",                    // phrases[5]
                "Денежная сумма не равна нулю",                 // phrases[6]
                "Стартовая денежная сумма: 0 рублей 0 копеек",  // phrases[7]
                "Вычитание произведено",                        // phrases[8]
                "Результат:  ",                                 // phrases[9]
                "Сложение произведено",                         // phrases[10]
                "Введите размер массива"};
            int choice = MainMenu();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine(phrases[7]);  // "Стартовая денежная сумма: 0 рублей 0 копеек"
                        Decision(price, phrases);
                        break;
                    }
                case 2:
                    {
                        Decision(array, phrases);
                        break;
                    }
                case 0:
                    {
                        return;
                    }
            }           
        }
    }
}
