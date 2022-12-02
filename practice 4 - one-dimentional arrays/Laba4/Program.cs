using System;

namespace Laba4
{
    class Program
    {
        static int CheckInput(int leftBorder, int rightBorder, string message)
        {
            int value;
            bool checkValue;

            do
            {
                Console.WriteLine(message);
                checkValue = int.TryParse(Console.ReadLine(), out value);

                if (!checkValue)
                    Console.WriteLine("Неверный ввод данных");

                else if ((value > rightBorder) || (value < leftBorder))
                {
                    Console.WriteLine("Неверный ввод данных");
                    checkValue = false;
                }

            } while (!checkValue);

            return value;
        }
        static void PrintArray(ref int[] array, int size, string message)
        {
            Console.WriteLine(message);

            for (int i = 0; i < size; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();
            Console.WriteLine();
        }
        static void PrintMainMenu()
        {
            Console.WriteLine("1 - Удаление элементов массива");
            Console.WriteLine("2 - Добавление элементов в начало массива");
            Console.WriteLine("3 - Перестановка местами экстремумов массива");
            Console.WriteLine("4 - Поиск первого четного элемента в массиве");
            Console.WriteLine("5 - Сортировка массива простым обменом");
            Console.WriteLine("6 - Поиск элемента в отсортированном массиве");
            Console.WriteLine("0 - Завершение работы" + '\n');
        }
        static void PrintArrInputMenu(string message)
        {
            Console.WriteLine(message + '\n');
            Console.WriteLine("1 - Автоматический");
            Console.WriteLine("2 - Ручной" + '\n');
        }
        static void Decision(int[] array, int size)
        {
            int choice;
            bool sortCheck = false;

            if (array.Length == 0)
            {
                Console.WriteLine("Массив пустой! Добавьте элементы");
                AddElements(ref array, size, out int newSize);
                size = newSize;
            }

            do
            {
                PrintMainMenu();
                choice = CheckInput(0, 6, "Выберите пункт меню");

                switch (choice)
                {
                    case 1:
                        {
                            DeleteElements(ref array, size, out int newSize);
                            size = newSize;
                            sortCheck = false;
                            break;
                        }
                    case 2:
                        {
                            AddElements(ref array, size, out int newSize);
                            sortCheck = false;
                            size = newSize;
                            break;
                        }
                    case 3:
                        {
                            ReplaceElements(ref array, size);
                            sortCheck = false;
                            break;
                        }
                    case 4:
                        {
                            FindFirstEven(ref array, size);
                            break;
                        }
                    case 5:
                        {
                            SortArray(ref array, size);
                            sortCheck = true;
                            break;
                        }
                    case 6:
                        {
                            if(!sortCheck)
                            {
                                Console.WriteLine("Массив был автоматически отсортирован");
                                SortArray(ref array, size);
                                sortCheck = true;
                            }
                            BinarySearch(ref array, size);
                            break;
                        }
                }
            } while (choice != 0);
            if (choice == 0)
                return;

        }
        static void MakeArray(out int[] array, out int size)
        {
            Random rand = new Random();
            size = CheckInput(1, 100, "Введите размер массива");
            array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = rand.Next(-99, 100);

            PrintArray(ref array, size, "Массив создан");
        }
        static void InputArray(out int[] array, out int size)
        {
            size = CheckInput(1, 100, "Введите размер массива");
            array = new int[size];
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < size; i++)
                array[i] = CheckInput(-99, 99, "");

            PrintArray(ref array, size, "Массив создан");
        }
        static void DeleteElements(ref int[] array, int size, out int newSize)
        {
            int delFrom;
            int delThis;
            newSize = -1;

            delFrom = CheckInput(1, size, "Введите номер элемента, с которого начнется удаление");
            delFrom--;
            delThis = CheckInput(0, size - delFrom, "Введите количество удаляемых элементов");

            if (delThis == 0)
                Console.WriteLine("Удаление отменено" + '\n');

            else
            {
                int[] mas = new int[size - delThis];

                // Два счетчика для решения проблемы с разной размерностью массивов
                for (int i = 0, j = 0; i < size; i++, j++)
                {
                    if (j != delFrom)
                        mas[j] = array[i];

                    else
                    {
                        try { mas[j] = array[i + delThis]; }
                        catch (IndexOutOfRangeException) { break; }
                        mas[j] = array[i + delThis];
                        i += delThis;
                    }
                }

                array = mas;
                newSize = size - delThis;
                PrintArray(ref array, newSize, "Элементы удалены");
            }
        }
        static void AddElements(ref int[] array, int size, out int newSize)
        {
            int number = CheckInput(0, 100, "Введите количество добавляемых элементов");
            int input;
            int[] mas = new int[size + number];
            newSize = -1;

            if (number == 0)
                Console.WriteLine("Добавление отменено" + '\n');

            else
            {
                PrintArrInputMenu("Ввод добавляемых элементов");
                input = CheckInput(1, 2, "Выберите тип ввода");
                Random rand = new Random();

                if (input == 1)
                    for (int i = 0; i < size + number; i++)
                    {
                        if (i < number)
                            mas[i] = rand.Next(-99, 100);
                        else
                            mas[i] = array[i - number];
                    }

                else
                {
                    Console.WriteLine("Введите элементы");
                    for (int i = 0; i < size + number; i++)
                    {
                        if (i < number)
                            mas[i] = CheckInput(-99, 99, "");
                        else
                            mas[i] = array[i - number];
                    }
                }

                array = mas;
                newSize = size + number;
                PrintArray(ref array, newSize, "Элементы добавлены");
            }

        }
        static void ReplaceElements(ref int[] array, int size)
        {

            int maxPlace = FindMax(ref array, size);
            int minPlace = FindMin(ref array, size);

            if (maxPlace == minPlace)
                Console.WriteLine("Все элементы массива равны" + '\n');

            else
            {
                int storage = array[minPlace];
                array[minPlace] = array[maxPlace];
                array[maxPlace] = storage;
                PrintArray(ref array, size, "Экстремумы поменялись местами");
            }
        }
        static int FindMax(ref int[] array, int size)
        {
            int max = array[0];
            int maxPlace = 0;

            for (int i = 0; i < size; i++)
                if (array[i] > max)
                {
                    max = array[i];
                    maxPlace = i;
                }

            return maxPlace;
        }
        static int FindMin(ref int[] array, int size)
        {
            int min = array[0];
            int minPlace = 0;

            for (int i = 0; i < size; i++)
                if (array[i] < min)
                {
                    min = array[i];
                    minPlace = i;
                }

            return minPlace;
        }
        static void FindFirstEven(ref int[] array, int size)
        {
            bool check = false;
            int pos;

            for (pos = 0; pos < size; pos++)
                if (array[pos] % 2 == 0)
                {
                    check = true;
                    break;
                }

            if (check)
            {
                Console.WriteLine($"Первый четный элемент в массиве: {array[pos]}");
                Console.WriteLine($"Проведено сравнений для его нахождения: {pos + 1}" + '\n');
            }
            else
                Console.WriteLine("Четных элементов нет" + '\n');
        }
        static void SortArray(ref int[] array, int size)
        {
            for (int i = 0; i < size; i++)
                for (int j = size - 1; j > i; j--)
                    if (array[j] < array[j - 1])
                    {
                        int storage = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = storage;
                    }

            PrintArray(ref array, size, "Массив отсортирован");
        }
        static void BinarySearch(ref int[] array, int size)
        {
            int numberForFind = CheckInput(-99, 100, "Введите число для поиска");
            int left = 0;
            int right = size - 1;
            int sred;
            int compCount = 0;

            do
            {
                sred = (left + right) / 2;
                if (array[sred] < numberForFind) 
                    left = sred + 1;
                else right = sred;
                compCount++;
            } while (left != right);

            if (array[left] == numberForFind)
            {
                Console.WriteLine($"Элемент {numberForFind} стоит на позиции {left + 1}");
                Console.WriteLine($"Произведено сравнений для его нахождения: {compCount}");
            }

            else Console.WriteLine("Искомый элемент не найден");

        }
        static void Main(string[] args)
        {
            int input;
            int[] array;
            int size;

            PrintArrInputMenu("Ввод массива");
            input = CheckInput(1, 2, "Выберите тип ввода");

            if (input == 1)
                MakeArray(out array, out size);

            else
                InputArray(out array, out size);

            Decision(array, size);
        }
    }
}
