using System;
using MyLibrary;
using System.Text.RegularExpressions;

namespace Laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] collection = new Person[41];
            #region 
            collection[0] = new Employee("Гончаров Дмитрий Андреевич", 41, "охранник", 24000);
            collection[1] = new Student("Ворхлик Александр Егорович", 19, 1, 60);
            collection[2] = new Student("Кулагин Григорий Андреевич", 19, 1, 24);
            collection[3] = new Teacher("Мельникова Ольга Сергеевна", 35, "преподаватель", 52000, "английский язык", 10);
            collection[4] = new Employee("Василевич Илья Константинович", 27, "охранник", 24000);
            collection[5] = new Student("Агамалиев Рустам Рагим-оглы", 18, 1, 13);
            collection[6] = new Student("Казарина Екатерина Васильевна", 19, 1, 18);
            collection[7] = new Employee("Костина Елизавета Петровна", 28, "повар", 20000);
            collection[8] = new Employee("Смирнов Всеволод Юрьевич", 30, "системный админ.", 48000);
            collection[9] = new Employee("Стариков Алексей Алексеевич", 26, "тех. специалист", 42000);
            collection[10] = new Student("Охота Борис Николаевич", 20, 1, 1);
            collection[11] = new Teacher("Захаров Дмитрий Алексеевич", 32, "преподаватель", 51000, "программирование", 8);
            collection[12] = new Teacher("Чекалкин Захар Павлович", 40, "преподаватель", 39000, "физическая культура", 15);
            collection[13] = new Teacher("Пентина Полина Олеговна", 37, "преподаватель", 52500, "право", 12);
            collection[14] = new Employee("Веретенников Артем Сергеевич", 50, "дворник", 21000);
            collection[15] = new Student("Дмитриев Арсений Алексеевич", 19, 1, 4);
            collection[16] = new Employee("Гынгазов Дмитрий Олегович", 32, "заведующий кафедрой ИТБ", 55000);
            collection[17] = new Employee("Пясецкая Анастасия Леонидовна", 27, "повар", 20000);
            collection[18] = new Teacher("Иванов Иван Иванович", 38, "преподаватель", 49000, "английский язык", 13);
            collection[19] = new Teacher("Кочурова Ольга Владимировна", 45, "преподаватель", 56000, "экономика", 20);
            collection[20] = new Student("Никитин Андрей Владимирович", 21, 2, 7);
            collection[21] = new Student("Божко Максим Александрович", 20, 2, 43);
            collection[22] = new Student("Селина Анна Дмитриевна", 20, 2, 32);
            collection[23] = new Student("Иванов Виктор Юрьевич", 21, 2, 3);
            collection[24] = new Student("Максимов Иван Максимович", 21, 2, 40);
            collection[25] = new Student("Костин Виктор Сергеевич", 20, 2, 37);
            collection[26] = new Student("Панин Александр Олегович", 22, 3, 28);
            collection[27] = new Student("Пахомов Герман Сергеевич", 22, 3, 43);
            collection[28] = new Student("Бреничев Никита Анатольевич", 23, 3, 51);
            collection[29] = new Student("Илькаев Артур Ринатович", 21, 3, 29);
            collection[30] = new Student("Шиляев Илья Григорьевич", 22, 3, 15);
            collection[31] = new Student("Филатова Валерия Михайловна", 23, 3, 18);
            collection[32] = new Student("Колеватов Владислав Николаевич", 24, 4, 31);
            collection[33] = new Student("Зубенко Михаил Петрович", 24, 4, 20);
            collection[34] = new Student("Сагидуллин Рамиль Альбертович", 23, 4, 39);
            collection[35] = new Student("Маслов Александр Владимирович", 25, 4, 52);
            collection[36] = new Student("Сеген Елизавета Максимовна", 24, 4, 56);
            collection[37] = new Student("Элькинд Марина Михайловна", 25, 4, 5);
            collection[38] = new Teacher("Ганихин Ярослав Алексеевич", 44, "преподаватель", 57000, "алгебра и мат. анализ", 19);
            collection[39] = new Teacher("Кучкин Алексей Николаевич", 35, "преподаватель", 39000, "физическая культура", 10);
            collection[40] = new Teacher("Замилов Руслан Сергеевич", 46, "преподаватель", 47750, "история", 21);
            #endregion

            PrintTaskMenu();

            int choice = InputInteger(0, 4, "Выберите задание");

            switch (choice)
            {
                case 1:
                    {
                        UDList list = new UDList(collection);
                        Decision(list);

                        break;
                    }
                case 2:
                    {
                        BDList list = new BDList(collection);
                        Decision(list);

                        break;
                    }
                case 3:
                    {
                        BinaryTree tree = new BinaryTree(collection);
                        Decision(tree);

                        break;
                    }
                case 4:
                    {
                        MyCollection<Person> list = new MyCollection<Person>(collection);
                        Decision(list);

                        break;
                    }
                case 0:
                    {
                        return;
                    }
            }

        }


        static Person CreateObject()
        {
            PrintInputMenu();

            int choice = InputInteger(1, 4, "Выберите тип записи");

            switch (choice)
            {
                case 1:  // Type Person
                    {
                        Person p = new Person();
                        p.Input();
                        return p;
                    }
                case 2:  // Type Student
                    {
                        Student s = new Student();
                        s.Input();
                        return s;
                    }
                case 3:  // Type Employee
                    {
                        Employee e = new Employee();
                        e.Input();
                        return e;
                    }
                case 4:  // Type Teacher
                    {
                        Teacher t = new Teacher();
                        t.Input();
                        return t;
                    }
                default: return null;
            }
        }

        // Однонаправленный список
        static void Decision(UDList list)
        {
            int choice;

            do
            {
                PrintUndirListMenu();
                choice = InputInteger(0, 3, "Выберите действие");

                switch (choice)
                {
                    case 1:  // Печать
                        {
                            list.Print();
                            break;
                        }
                    case 2:  // Добавление эл-та
                        {
                            Person p = CreateObject();
                            string name = InputString("Введите имя записи, после которой будет добавлен новый объект");

                            bool added = list.AddAfter(p, name);
                            if (added) Console.WriteLine("Элемент успешно добавлен");
                            else Console.WriteLine("Предшествующая запись не найдена. Элемент не может быть добавлен");

                            break;
                        }
                    case 3:  // Удаление списка
                        {
                            list.Delete();
                            Console.WriteLine("Список успешно удален");
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }
            } while (choice != 0);
        }

        // Двунаправленный список
        static void Decision(BDList list)
        {
            int choice;

            do
            {
                PrintBidirListMenu();
                choice = InputInteger(0, 3, "Выберите действие");

                switch (choice)
                {
                    case 1:  // Печать
                        {
                            list.Print();

                            break;
                        }
                    case 2:  // Удаление студентов указанного курса
                        {
                            int kurs = InputInteger(1, 4, "Введите курс");

                            list.DeleteByKurs(kurs);
                            Console.WriteLine("Удаление произведено");
                            break;
                        }
                    case 3:  // Удаление списка
                        {
                            list.Delete();
                            Console.WriteLine("Список успешно удален");
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            } while (choice != 0);
        }

        // Бинарное дерево
        static void Decision(BinaryTree tree)
        {
            int choice;

            do
            {
                PrintTreeMenu();
                choice = InputInteger(0, 4, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            if (tree.Root == null) Console.WriteLine("Дерево пустое");
                            else  tree.Print(tree.Root);

                            break;
                        }
                    case 2:
                        {
                            double sum = 0;
                            tree.GetAgeSum(tree.Root, ref sum);
                            double averageAge = sum / tree.Count;
                            averageAge = Math.Round(averageAge, 1, MidpointRounding.AwayFromZero);
                            Console.WriteLine($"Средний возраст: {averageAge} лет");

                            break;
                        }
                    case 3:
                        {
                            BinaryTree searchTree = tree.SearchTree();
                            Console.WriteLine("Дерево поиска сформировано");
                            Console.WriteLine();
                            searchTree.Print(searchTree.Root);

                            break;
                        }
                    case 4:
                        {
                            //Person[] people = new Person[6];
                            //people[0] = new Person("ААА ААА ААА", 1);
                            //people[1] = new Person("БББ БББ БББ", 2);
                            //people[2] = new Person("ВВВ ВВВ ВВВ", 3);
                            //people[3] = new Person("ГГГ ГГГ ГГГ", 4);
                            //people[4] = new Person("ДДД ДДД ДДД", 5);
                            //people[5] = new Person("FFF FFF FFF", 6);
                            //BinaryTree test = new BinaryTree(people);
                            //test.Delete(test.Root);
                            tree.Delete(tree.Root);
                            Console.WriteLine("Дерево удалено");

                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            } while (choice != 0);
        }

        // Обобщенный двунаправленный список
        static void Decision(MyCollection<Person> list)
        {
            int choice;
            MyCollection<Person> clonedList = new MyCollection<Person>();  // Глубокое копирование
            MyCollection<Person> copiedList = new MyCollection<Person>();  // Поверхностное копирование

            do
            {
                PrintMyColMenu();
                choice = InputInteger(0, 11, "Выберите действие");

                switch (choice)
                {
                    case 1: // Вывод списка
                        {
                            if (list.Count == 0) Console.WriteLine("Список пуст");
                            // MyNumerator
                            foreach (Person p in list)
                                Console.WriteLine(p);

                            break;
                        }
                    case 2: // Добавить элемент в начало списка
                        {
                            Person p = CreateObject();
                            list.AddToBegin(p);
                            Console.WriteLine("Элемент успешно добавлен");

                            break;
                        }
                    case 3: // Добавить элемент в конец списка
                        {
                            Person p = CreateObject();
                            list.AddToEnd(p);
                            Console.WriteLine("Элемент успешно добавлен");

                            break;
                        }
                    case 4: // Добавить элемент на указанную позицию
                        {
                            Person p = CreateObject();
                            int position = InputInteger(1, 1000, "Введите позицию вставки");
                            list.Add(position, p);
                            Console.WriteLine("Элемент успешно добавлен");

                            break;
                        }
                    case 5: // Удалить элемент по значению
                        {
                            if(list.Beg == null)
                            {
                                Console.WriteLine("Список пуст");
                                break;
                            }
                            string name = InputString("Введите имя записи");
                            bool deleted = false;

                            foreach(Person p in list)
                            {
                                if(p.Name == name)
                                {
                                    list.DeleteElement(p);
                                    deleted = true;
                                    Console.WriteLine("Запись удалена");
                                    break;
                                }
                            }
                            if (!deleted) Console.WriteLine("Запись не найдена");

                            break;
                        }
                    case 6: // Найти элемент
                        {
                            if (list.Beg == null)
                            {
                                Console.WriteLine("Список пуст");
                                break;
                            }
                            string name = InputString("Введите имя записи");
                            bool found = false;

                            foreach(Person p in list)
                            {
                                if(p.Name == name)
                                {
                                    Console.WriteLine("Запись найдена");
                                    found = true;
                                    Console.WriteLine(p);
                                    break;
                                }
                            }
                            if(!found) Console.WriteLine("Запись не найдена");

                            break;
                        }
                    case 7: // Глубокое копирование списка
                        {
                            clonedList = list.Clone();
                            Console.WriteLine("Список клонирован");

                            break;
                        }
                    case 8: // Поверхностное копирование списка
                        {
                            copiedList = list.Copy();
                            Console.WriteLine("Список скопирован");

                            break;
                        }
                    case 9: // Удаление списка
                        {
                            list.Delete();
                            Console.WriteLine("Список удален");

                            break;
                        }
                    case 10: // Вывод последней глубокой копии
                        {
                            if (clonedList.Count == 0) Console.WriteLine("Копия не создана");
                            else
                            {
                                foreach (Person p in clonedList)
                                    Console.WriteLine(p);
                            }
                            break;
                        }
                    case 11: // Вывод последней поверхностной копии
                        {
                            if (copiedList.Count == 0) Console.WriteLine("Копия не создана");
                            else
                            {
                                foreach (Person p in copiedList)
                                    Console.WriteLine(p);
                            }
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }


            } while (choice != 0);
        }

        static int InputInteger(int leftBorder, int rightBorder, string message)
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

        static string InputString(string message)
        {
            Regex pattern = new Regex(@"(?i)[а-я]+");
            string input;
            bool check;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                check = pattern.IsMatch(input);
                if (!check)
                    Console.WriteLine("Неверный ввод данных");
            } while (!check);

            return input;
        }

        static void PrintBidirListMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Вывести список");
            Console.WriteLine("2 - Удалить всех студентов указанного курса");
            Console.WriteLine("3 - Удалить список");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintInputMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Персона");
            Console.WriteLine("2 - Студент");
            Console.WriteLine("3 - Работник");
            Console.WriteLine("4 - Преподаватель");
            Console.WriteLine();

        }

        static void PrintMyColMenu()
        {
            Console.WriteLine();
            Console.WriteLine(" 1 - Вывод списка");
            Console.WriteLine(" 2 - Добавить элемент в начало списка");
            Console.WriteLine(" 3 - Добавить элемент в конец списка");
            Console.WriteLine(" 4 - Добавить элемент на указанную позицию");
            Console.WriteLine(" 5 - Удалить элемент по значению");
            Console.WriteLine(" 6 - Найти элемент");
            Console.WriteLine(" 7 - Глубокое копирование списка");
            Console.WriteLine(" 8 - Поверхностное копирование списка");
            Console.WriteLine(" 9 - Удаление списка");
            Console.WriteLine("10 - Вывод последней глубокой копии");
            Console.WriteLine("11 - Вывод последней поверхностной копии");
            Console.WriteLine(" 0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintTaskMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Однонаправленный список");
            Console.WriteLine("2 - Двунаправленный список");
            Console.WriteLine("3 - Бинарное дерево");
            Console.WriteLine("4 - Собственная обобщенная коллекция");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintTreeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Вывести дерево");
            Console.WriteLine("2 - Средний возраст");
            Console.WriteLine("3 - Преобразовать в дерево поиска");
            Console.WriteLine("4 - Удалить дерево");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintUndirListMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Вывести список");
            Console.WriteLine("2 - Добавить элемент после элемента с заданным информационным полем.");
            Console.WriteLine("3 - Удалить список");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }
    }
}
