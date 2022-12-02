using System;
using System.Text.RegularExpressions;

namespace Laba6
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
        static bool ExistArray(ref char[] array)
        {
            if (array == null || array.Length == 0)
                return false;
            else return true;
        }
        static bool ExistWordsInString(string sentence)
        {
            int i = 0;
            bool condition;
            bool flag = false;
            for (i = 0; i < sentence.Length; i++)
            {
                condition = (sentence[i] >= '0' && sentence[i] <= '9') || (sentence[i] >= 'А' && sentence[i] <= 'я') || (sentence[i] >= 'A' && sentence[i] <= 'Z') || (sentence[i] >= 'a' && sentence[i] <= 'z');
                if (condition)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
                return false;
            else return true;
        }
        static char[] MakeArray()
        {
            Random rand = new Random();
            int size = CheckInput(0, 100, "Введите размер массива");
            char[] array = new char[size];

            for (int i = 0; i < size; i++)
                array[i] = (char)rand.Next(32, 123);

            return array;
        }
        static char[] InputArray()
        {
            bool flag;
            int size = CheckInput(0, 100, "Введите размер массива");
            char[] array = new char[size];
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < size; i++)
            {
                do
                {
                    flag = true;
                    try { array[i] = char.Parse(Console.ReadLine()); }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный ввод данных. Вводите символы по одному");
                        flag = false;
                    }

                } while (!flag);
            }

            return array;
        }
        static string MakeString(string[] sentences)
        {
            string sentence;
            Random rand = new Random();

            int i = rand.Next(0, sentences.Length);
            sentence = sentences[i];

            return sentence;
        }
        static string InputString()
        {
            bool flag;
            string sentence;
            Console.WriteLine("Введите строку, оканчивающуюся либо точкой, либо восклицательным, либо вопросительным знаком");
            do
            {
                Regex pattern = new Regex(@".*[.?!]$");
                sentence = Console.ReadLine();
                flag = true;
                if (!pattern.IsMatch(sentence))
                {
                    flag = false;
                    Console.WriteLine("Строка введена неверно!");
                }
            } while (!flag);

            return sentence;
        }
        static void PrintString(string sentence, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine(sentence);
        }
        static void PrintArray(ref char[] array, string message)
        {
            Console.WriteLine(message);
            if (!ExistArray(ref array))
                Console.WriteLine("Массив пустой! Создайте непустой массив");
            else
            {

                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array[i]} ");

                Console.WriteLine();
            }

        }
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Создать массив из случайных символов");
            Console.WriteLine("2 - Создать символьный массив вручную");
            Console.WriteLine("3 - Удалить все цифры из массива");
            Console.WriteLine("4 - Сгенерировать случайную строку");
            Console.WriteLine("5 - Ввести строку вручную");
            Console.WriteLine("6 - Перевернуть все слова и числа в предложении");
            Console.WriteLine("7 - Отсортировать слова по алфавиту");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }
        static void RemoveDigits(ref char[] array)
        {
            int sizeDifference = 0;
            int counter = 0;
            string message = "Все цифры были удалены";

            for (int i = 0; i < array.Length; i++)
                if (Char.IsDigit(array[i]))
                    sizeDifference++;

            if (sizeDifference == 0)
            {
                Console.WriteLine("Массив не содержит цифр");
                return;
            }

            char[] newArray = new char[array.Length - sizeDifference];

            for (int i = 0; i < array.Length; i++)
                if (!Char.IsDigit(array[i]))
                {
                    Array.Copy(array, i, newArray, counter, 1);
                    counter++;
                }

            array = newArray;
            PrintArray(ref newArray, message);
        }
        static string ReverseWords(string sentence, char[] separators)
        {
             int startPos = 0;
             char[] array = sentence.ToCharArray();
             int firstIndex;

             do
             {
                 firstIndex = array.Length - 1;
                 for (int i = 0; i < separators.Length; i++)
                 {
                     int value = Array.IndexOf(array, separators[i], startPos);
                     if (firstIndex > value && value != -1)
                         firstIndex = value;
                 }

                 Array.Reverse(array, startPos, firstIndex - startPos);
                 startPos = firstIndex + 1;

             } while (firstIndex != array.Length - 1);

             sentence = String.Concat(array);

             return sentence;
        }
        static void SortWords(string sentence, char[] separators, out string[] words)
        {
            words = sentence.Split(separators);
           // words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries); для удаления пустых слов
            Array.Sort(words);
            Array.Reverse(words);

        }
        static void Decision(char[] array, string sentence)
        {
            int choice;
            char[] separators = { ' ', ',', ';', ':', '.', '!', '?', '@', '"', '#', '$', '%', '^', '&',
                                '*', '(', ')', '_', '-', '=', '+', '[', ']', '{', '}', '\'', '<', '>',
                                '/', '|', '\\', '`', '~'};
            string[] sentences = { "абырвалг.", "Массив вывести на печать.", "Съешь ещё этих мягких французских булок, да выпей чаю.",
                "Сказка ложь, да в ней намёк!", "Выдь на Волгу: чей стон раздаётся над великою русской рекой?",
                "Поэтом можешь ты не быть, но гражданином быть обязан.", "Опять жизнь, опять надежды!",
                "Да, страсть надо ограничить, задушить и утопить в женитьбе.", "Перевернуть все слова в предложении и отсортировать слова по убыванию.",
                "Моё богатство, очевидно, в том, что мне оно не нужно.", "Жизнь бьёт ключом по голове!", "Петербург прихожая, Москва девичья, деревня же наш кабинет.",
                "Не приведи бог видеть русский бунт, бессмысленный и беспощадный!", "Марья Гавриловна была воспитана на французских романах, и, следовательно, была влюблена.",
                "Восемьдесят три процента всех дней в году начинаются одинаково: звенит будильник.", "Я люблю людей, с которыми всё может случиться.",
                "С таким рылом следует запретить неожиданно появляться из-за угла.", "Любовь — творчество, у бездарных она — нудная драма с утюгом в валенке.",
                "На какой бы улице ни открылась пивная — это праздник на нашей улице.", "Не хочу учиться, хочу жениться."};

            do
            {
                PrintMenu();
                choice = CheckInput(0, 7, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            array = MakeArray();
                            PrintArray(ref array, "Массив создан");
                            break;
                        }
                    case 2:
                        {
                            array = InputArray();
                            PrintArray(ref array, "Массив создан");
                            break;
                        }
                    case 3:
                        {
                            if (!ExistArray(ref array))
                                Console.WriteLine("Массив не существует или пустой. Создайте непустой массив");
                            else RemoveDigits(ref array);
                            break;
                        }
                    case 4:
                        {
                            sentence = MakeString(sentences);
                            PrintString(sentence, "Строка создана!");
                            break;
                        }
                    case 5:
                        {
                            sentence = InputString();
                            break;
                        }
                    case 6:
                        {
                            if (!ExistWordsInString(sentence))
                                Console.WriteLine("В строке нет слов или чисел");
                            else
                            {
                                string newSentence = ReverseWords(sentence, separators);
                                PrintString(newSentence, "Слова перевернуты!");
                            }
                            break;
                        }
                    case 7:
                        {
                            if (!ExistWordsInString(sentence))
                                Console.WriteLine("В строке нет слов или чисел");
                            else
                            {
                                SortWords(sentence, separators, out string[] words);
                                SortedStringOutput(ref words);
                            }
                            break;
                        }
                }
            } while (choice != 0);

            if (choice == 0)
                return;
        }
        static void SortedStringOutput(ref string[] words)
        {
            Regex pattern = new Regex(@"\w\D+");
            bool flag = false;

            Console.WriteLine();

            for(int i = 0; i < words.Length; i++)
                if (pattern.IsMatch(words[i]))
                {
                    Console.WriteLine(words[i]);
                    flag = true;
                }
            if (!flag)
                Console.WriteLine("В строке нет слов");
        }
        static void Main(string[] args)
        {
            char[] array = null;
            string sentence = "";
            Decision(array, sentence);
        }
    }
}