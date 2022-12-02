using System;
using MyLibrary;

namespace Laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] collection = new Person[30];
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
            #endregion

            MyCollection<Person> firstColl = new MyCollection<Person>("Первая коллекция", collection);
            MyCollection<Person> secondColl = new MyCollection<Person>("Вторая коллекция", collection);

            Journal firstJournal = new Journal();
            Journal secondJournal = new Journal();

            // Подписка на события
            firstColl.CollectionCountChanged += new CollectionHandler(firstJournal.CollectionCountChanged);
            firstColl.CollectionReferenceChanged += new CollectionHandler(firstJournal.CollectionReferenceChanged);

            firstColl.CollectionReferenceChanged += new CollectionHandler(secondJournal.CollectionReferenceChanged);
            secondColl.CollectionReferenceChanged += new CollectionHandler(secondJournal.CollectionReferenceChanged);

            Console.WriteLine("Первый журнал учитывает все изменения первой коллекции");
            Console.WriteLine("Второй журнал учитывает изменение элементов обоих коллекций");

            Decision(firstColl, secondColl, firstJournal, secondJournal);
        }


        static Person CreatePerson()
        {
            PrintPersonMenu();

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

        static void Decision(MyCollection<Person> firstColl, MyCollection<Person> secondColl, Journal firstJournal, Journal secondJournal)
        {
            int choice;

            do
            {
                PrintMenu();
                choice = InputInteger(0, 8, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine(firstColl.Name);
                            foreach (Person p in firstColl)
                                Console.WriteLine(p);

                            Console.WriteLine();
                            Console.WriteLine("=============================================================");
                            Console.WriteLine();

                            Console.WriteLine(secondColl.Name);
                            foreach (Person r in secondColl)
                                Console.WriteLine(r);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Журнал первой коллекции");
                            Console.WriteLine(firstJournal);
                            Console.WriteLine();
                            Console.WriteLine("Журнал второй коллекции");
                            Console.WriteLine(secondJournal);

                            break;
                        }
                    case 3:
                        {
                            Person p = CreatePerson();
                            firstColl.AddToEnd(p);
                            Console.WriteLine("Элемент добавлен");

                            break;
                        }
                    case 4:
                        {
                            Person p = CreatePerson();
                            secondColl.AddToEnd(p);
                            Console.WriteLine("Элемент добавлен");

                            break;
                        }
                    case 5:
                        {
                            int position = InputInteger(1, firstColl.Count, "Введите позицию удаляемого элемента");
                            firstColl.Remove(position - 1);
                            Console.WriteLine("Элемент удален");

                            break;
                        }
                    case 6:
                        {
                            int position = InputInteger(1, secondColl.Count, "Введите позицию удаляемого элемента");
                            secondColl.Remove(position - 1);
                            Console.WriteLine("Элемент удален");

                            break;
                        }
                    case 7:
                        {
                            int position = InputInteger(1, firstColl.Count, "Введите позицию ищменяемого элемента");
                            Console.WriteLine("Создание нового элемента");
                            Person p = CreatePerson();
                            BDPoint<Person> point = new BDPoint<Person>(p);
                            firstColl[position - 1] = point;
                            Console.WriteLine($"Элемент № {position} изменен");

                            break;
                        }
                    case 8:
                        {
                            int position = InputInteger(1, secondColl.Count, "Введите позицию ищменяемого элемента");
                            Console.WriteLine("Создание нового элемента");
                            Person p = CreatePerson();
                            BDPoint<Person> point = new BDPoint<Person>(p);
                            secondColl[position - 1] = point;
                            Console.WriteLine($"Элемент № {position} изменен");

                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            } while (choice != 0);
        }

        static int InputInteger(int minBorder, int maxBorder, string message)
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

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Вывод коллекций");
            Console.WriteLine("2 - Вывод журналов");
            Console.WriteLine("3 - Добавить элемент в первую коллекцию");
            Console.WriteLine("4 - Добавить элемент во вторую коллекцию");
            Console.WriteLine("5 - Удалить элемент из первой коллекции");
            Console.WriteLine("6 - Удалить элемент из второй коллекции");
            Console.WriteLine("7 - Изменить элемент первой коллеции");
            Console.WriteLine("8 - Изменить элемент второй коллекции");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintPersonMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Персона");
            Console.WriteLine("2 - Студент");
            Console.WriteLine("3 - Работник");
            Console.WriteLine("4 - Преподаватель");
            Console.WriteLine();

        }
    }
}
