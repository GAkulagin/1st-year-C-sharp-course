using System;

namespace Laba5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = null;
            int[,] matrix = null;
            int[][] jagArray = null;
            Decision(array, matrix, jagArray);
        }
        static int CheckInput(int leftBorder, int rightBorder, string message)
        {
            int value;
            bool checkValue;
            do
            {
                Console.WriteLine(message);
                checkValue = int.TryParse(Console.ReadLine(), out value);

                if (!checkValue)
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                else if ((value > rightBorder) || (value < leftBorder))
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                    checkValue = false;
                }

            } while (!checkValue);

            return value;
        }
        static void PrintMenu()
        {
            Console.WriteLine("1 - Создать одномерный массив");
            Console.WriteLine("2 - Создать двумерный массив");
            Console.WriteLine("3 - Создать рваный массив");
            Console.WriteLine("4 - Добавить элементы в начало одномерного массива");
            Console.WriteLine("5 - Удалить строки из двумерного массива");
            Console.WriteLine("6 - Добавить строку в рваный массив");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();

        }
        static int ArrayInputType()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Автоматический");
            Console.WriteLine("2 - Ручной");
            Console.WriteLine();
            int inputType = CheckInput(1, 2, "Выберите тип ввода массива");
            return inputType;
        }
        static int[] MakeArray()
        {
            Random rand = new Random();
            int size = CheckInput(0, 100, "Введите размер массива");
            string message = "Массив создан";
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = rand.Next(-99, 100);
            PrintArray(ref array, message);

            return array;
        }
        static int[] InputArray()
        {
            int size = CheckInput(0, 100, "Введите размер массива");
            int[] array = new int[size];
            string message = "Массив создан";
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < size; i++)
                array[i] = CheckInput(-99, 99, " ");
            PrintArray(ref array, message);

            return array;
        }
        static void PrintArray(ref int[] array, string message)
        {
            if (array.Length == 0)
                Console.WriteLine("Массив пустой! Создайте непустой массив");
            else
            {
                Console.WriteLine(message);

                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array[i]} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        static int[,] MakeMatrix()
        {
            string message = "Массив создан";
            Random rand = new Random();
            int verticalSize = CheckInput(0, 100, "Введите число строк массива");
            int horizontalSize = CheckInput(0, 100, "Введите число столбцов массива");
            int[,] matrix = new int[verticalSize, horizontalSize];

            for (int i = 0; i < verticalSize; i++)
                for (int j = 0; j < horizontalSize; j++)
                    matrix[i, j] = rand.Next(-99, 100);

            PrintMatrix(ref matrix, message);

            return matrix;
        }
        static int[,] InputMatrix()
        {
            string message = "Массив создан";
            int verticalSize = CheckInput(0, 100, "Введите число строк массива");
            int horizontalSize = CheckInput(0, 100, "Введите число столбцов массива");
            int[,] matrix = new int[verticalSize, horizontalSize];

            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < verticalSize; i++)
                for (int j = 0; j < horizontalSize; j++)
                    matrix[i, j] = CheckInput(-99, 100, " ");
            PrintMatrix(ref matrix, message);

            return matrix;
        }
        static void PrintMatrix(ref int[,] matrix, string message)
        {
            if (matrix.Length == 0)
                Console.WriteLine("Массив пустой! Создайте непустой массив");
            else
            {
                Console.WriteLine(message);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        static int[][] MakeJaggedArray()
        {
            string message = "Массив создан";
            int stringLength;
            Random rand = new Random();
            int size = CheckInput(0, 100, "Введите число строк массива");
            int[][] jagArray = new int[size][];

            if (jagArray.Length != 0)
            {
                Console.WriteLine("Введите длину каждой строки");
                for (int i = 0; i < size; i++)
                {
                    stringLength = CheckInput(0, 100, " ");
                    jagArray[i] = new int[stringLength];
                }

                for (int i = 0; i < size; i++)
                    for (int j = 0; j < jagArray[i].Length; j++)
                        jagArray[i][j] = rand.Next(-99, 100);
            }

            PrintJaggedArray(ref jagArray, message);

            return jagArray;
        }
        static int[][] InputJaggedArray()
        {
            string message = "Массив создан";
            int stringLength;
            int size = CheckInput(0, 100, "Введите число строк массива");
            int[][] jagArray = new int[size][];

            if (jagArray.Length != 0)
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Введите длину строки № {i + 1}");
                    stringLength = CheckInput(0, 100, " ");
                    jagArray[i] = new int[stringLength];
                    Console.WriteLine("Введите элементы строки");
                    for (int j = 0; j < jagArray[i].Length; j++)
                        jagArray[i][j] = CheckInput(-99, 100, " ");
                }

            PrintJaggedArray(ref jagArray, message);

            return jagArray;
        }
        static void PrintJaggedArray(ref int[][] jagArray, string message)
        {
            if (jagArray.Length == 0)
                Console.WriteLine("Массив пустой! Создайте непустой массив");
            else
            {
                Console.WriteLine(message);
                for (int i = 0; i < jagArray.GetLength(0); i++)
                {
                    if (jagArray[i].Length == 0)
                        Console.Write($"Строка № {i + 1} пуста");
                    else
                        for (int j = 0; j < jagArray[i].Length; j++)
                            Console.Write(jagArray[i][j] + " ");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        static void AddElements(ref int[] array)
        {
            int addToArray = CheckInput(0, 100, "Введите количество добавляемых элементов");
            int[] mas = new int[addToArray + array.Length];
            Random rand = new Random();
            string message = "Элементы добавлены";

            for (int i = 0; i < addToArray; i++)
                mas[i] = rand.Next(-99, 100);

            Array.Copy(array, 0, mas, addToArray, array.Length);
            array = mas;
            PrintArray(ref mas, message);
        }
        static void DeleteStrings(ref int[,] matrix)
        {
            string message = "Строки удалены";
            int firstString = CheckInput(1, matrix.GetLength(0), "Введите номер начальной строки");
            int lastString = CheckInput(1, matrix.GetLength(0), "Введите номер конечной строки");
            int copyPos;
            int pastePos;
            int count = 0;

            firstString--;
            lastString--;

            if (firstString > lastString)
            {
                int storage = firstString;
                firstString = lastString;
                lastString = storage;
            }

            int[,] newMatrix = new int[matrix.GetLength(0) - (lastString - firstString + 1), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < firstString || i > lastString)
                {
                    copyPos = i * matrix.GetLength(1);
                    pastePos = count * newMatrix.GetLength(1);
                    Array.Copy(matrix, copyPos, newMatrix, pastePos, matrix.GetLength(1));
                    count++;
                }
            }

            matrix = newMatrix;
            PrintMatrix(ref newMatrix, message);
        }
        static void AddString(ref int[][] jagArray)
        {
            string message = "Строка добавлена";
            int count = 0;
            int stringNumber = CheckInput(1, jagArray.GetLength(0) + 1, "Введите номер строки. Номер не должен превышать число строк массива больше, чем на 1");
            int stringSize = CheckInput(0, 100, "Введите размер добавляемой строки");
            int[][] newArray = new int[jagArray.GetLength(0) + 1][];
            Random rand = new Random();

            stringNumber--;
            newArray[stringNumber] = new int[stringSize];
            for (int j = 0; j < stringSize; j++)
                newArray[stringNumber][j] = rand.Next(-99, 100);


            for (int i = 0; i < newArray.GetLength(0); i++)
            {

                if (i != stringNumber)
                {
                    newArray[i] = new int[jagArray[count].Length];
                    Array.Copy(jagArray[count], newArray[i], jagArray[count].Length);
                    count++;

                }
                else
                {
                    newArray[stringNumber] = new int[stringSize];
                    for (int j = 0; j < stringSize; j++)
                        newArray[stringNumber][j] = rand.Next(-99, 100);
                }
            }

            jagArray = newArray;
            PrintJaggedArray(ref newArray, message);
        }
        static void Decision(int[] array, int[,] matrix, int[][] jagArray)
        {
            int choice;

            do
            {
                PrintMenu();
                choice = CheckInput(0, 6, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            int inputType = ArrayInputType();
                            if (inputType == 1)
                                array = MakeArray();
                            else array = InputArray();
                            break;
                        }
                    case 2:
                        {
                            int inputType = ArrayInputType();
                            if (inputType == 1)
                                matrix = MakeMatrix();
                            else matrix = InputMatrix();
                            break;
                        }
                    case 3:
                        {
                            int inputType = ArrayInputType();
                            if (inputType == 1)
                                jagArray = MakeJaggedArray();
                            else jagArray = InputJaggedArray();
                            break;
                        }
                    case 4:
                        {
                            if (array == null)
                                Console.WriteLine("Массив не создан! Создайте массив" + '\n');
                            else AddElements(ref array);
                            break;
                        }
                    case 5:
                        {
                            if (matrix == null || matrix.Length == 0)
                                Console.WriteLine("Массив пустой или не создан! Создайте непустой массив" + '\n');
                            else DeleteStrings(ref matrix);
                            break;
                        }
                    case 6:
                        {
                            if (jagArray == null || jagArray.Length == 0)
                                Console.WriteLine("Массив пустой или не создан! Создайте непустой массив" + '\n');
                            else AddString(ref jagArray);
                            break;
                        }

                }
            } while (choice != 0);

            if (choice == 0)
                return;
        }
    }
}
