using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using MyLibrary;

namespace Laba11
{
    public class Program
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
            collection[17] = new Employee("Пясецкая Анастасия Леонидовна", 27,"повар", 20000);
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
            collection[31] = new Student("Филатова Валерия Михайловна",23, 3, 18);
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
            ShowCollection(collection);

            Decision(collection);          
        }


        static void AddObject(ref SortedList sortedList)
        {
            PrintInputMenu();

            int choice = InputInteger(1, 4, "Выберите тип записи");

            switch (choice)
            {
                case 1:  // Type Person
                    {
                        Person p = new Person();
                        p.Input();
                        sortedList.Add(p, p);
                        break;
                    }
                case 2:  // Type Student
                    {
                        Student s = new Student();
                        s.Input();
                        sortedList.Add(s.BasePerson, s);
                        break;
                    }
                case 3:  // Type Employee
                    {
                        Employee e = new Employee();
                        e.Input();
                        sortedList.Add(e.BasePerson, e);
                        break;
                    }
                case 4:  // Type Teacher
                    {
                        Teacher t = new Teacher();
                        t.Input();
                        sortedList.Add(t.BasePerson, t);
                        break;
                    }
            }
        }

        static void AddObject(ref SortedDictionary<Person, Person> dictionary)
        {
            PrintInputMenu();

            int choice = InputInteger(1, 4, "Выберите тип записи");

            switch (choice)
            {
                case 1:  // Type Person
                    {
                        Person p = new Person();
                        p.Input();
                        dictionary.Add(p, p);
                        break;
                    }
                case 2:  // Type Student
                    {
                        Student s = new Student();
                        s.Input();
                        dictionary.Add(s.BasePerson, s);
                        break;
                    }
                case 3:  // Type Employee
                    {
                        Employee e = new Employee();
                        e.Input();
                        dictionary.Add(e.BasePerson, e);
                        break;
                    }
                case 4:  // Type Teacher
                    {
                        Teacher t = new Teacher();
                        t.Input();
                        dictionary.Add(t.BasePerson, t);
                        break;
                    }
            }
        }

        public static double AverageIncome(SortedList sortedList, ICollection keyList)
        {
            double sum = 0;
            int count = 0;

            foreach (Person p in keyList)
            {
                Employee employee = sortedList[p] as Employee;
                if (employee != null)
                {
                    sum += employee.Salary;
                    count++;
                }
            }

            double averageIncome = sum / count;

            return Math.Round(averageIncome, 2, MidpointRounding.AwayFromZero);
        }

        public static double AverageSeniority(SortedDictionary<Person, Person> dictionary)
        {
            double sum = 0;
            int count = 0;

            foreach(KeyValuePair<Person, Person> pair in dictionary)
            {
                Teacher teacher = pair.Value as Teacher;
                if(teacher != null)
                {
                    sum += teacher.Seniority;
                    count++;
                }
            }

            double averageSeniority = sum / count;

            return Math.Round(averageSeniority, 1, MidpointRounding.AwayFromZero);
        }

        public static SortedList Copy(SortedList sortedList, ICollection keyList)
        {
            SortedList newList = new SortedList();

            foreach (Person p in keyList)
                newList.Add(p.BasePerson, sortedList[p]);

            return newList;
        }

        public static SortedDictionary<Person, Person> Copy(SortedDictionary<Person, Person> dictionary)
        {
            SortedDictionary<Person, Person> newDictionary = new SortedDictionary<Person, Person>();

            foreach (KeyValuePair<Person, Person> pair in dictionary)
                newDictionary.Add(pair.Key, pair.Value);

            return newDictionary;
        }

        public static SortedDictionary<Person, Person> CreateEmployeeList(SortedDictionary<Person, Person> dictionary, int minimal)
        {
            SortedDictionary<Person, Person> employeeList = new SortedDictionary<Person, Person>();

            foreach(KeyValuePair<Person, Person> pair in dictionary)
            {
                Employee employee = pair.Value as Employee;
                if (employee != null && employee.Salary >= minimal)
                    employeeList.Add(employee.BasePerson, employee);
            }

            return employeeList;
        }

        public static Student[] CreateStudentList(SortedList sortedList, ICollection keyList)
        {
            int length = 0;

            foreach (Person person in keyList)
                if (sortedList[person] is Student)
                    length++;

            Student[] studentList = new Student[length];
            int count = 0;

            foreach (Person person in keyList)
                if (sortedList[person] is Student) 
                {
                    studentList[count] = (Student)sortedList[person];
                    count++;
                }
            return studentList;
        }

        public static SortedList CreateStudentList(SortedList sortedList, ICollection keyList, int kurs)
        {
            SortedList kursList = new SortedList();

            foreach (Person p in keyList)
            {
                Student student = sortedList[p] as Student;
                if (student != null && student.Kurs == kurs)
                    kursList.Add(student.BasePerson, student);
            }

            return kursList;
        }

        public static SortedDictionary<Person, Person> CreateTeacherList(SortedDictionary<Person, Person> dictionary, string subject)
        {
            SortedDictionary<Person, Person> teacherList = new SortedDictionary<Person, Person>();

            foreach(KeyValuePair<Person, Person> pair in dictionary)
            {
                Teacher teacher = pair.Value as Teacher;
                if (teacher != null && teacher.Science == subject)
                    teacherList.Add(teacher.BasePerson, teacher);
            }

            return teacherList;
        }

        // Выбор задания
        static void Decision(Person[] collection)       
        {
            PrintMainMenu();

            int choice = InputInteger(0, 3, "Выберите номер задания");

            switch (choice)
            {
                case 1:
                    {
                        SortedList sortedList = InitializeSortedList(collection);
                        Decision(sortedList);
                        break;
                    }
                case 2:
                    {
                        SortedDictionary<Person, Person> dictionary = InitializeSortedDictionary(collection);
                        Decision(dictionary);
                        break;
                    }
                case 3:
                    {
                        int length = InputInteger(3, 1000, "Введите размер коллекции (от 3 до 1000 включительно)");
                        TestCollections testCollection = new TestCollections(length);
                        testCollection = testCollection.RandomInit(length);
                        Decision(testCollection);
                        break;
                    }
            }
        }

        // Первое задание
        static void Decision(SortedList sortedList)
        {
            int choice;
            ICollection keyList = sortedList.Keys;
            SortedList copy = new SortedList();  // Для хранении копии коллекции
            bool copied = false;

            do
            {
                PrintFirstTaskMenu();

                choice = InputInteger(0, 9, "Выберите действие");

               switch (choice)
                {
                    case 1:  // Добавление объекта
                        {
                            AddObject(ref sortedList);
                            Console.WriteLine("Запись успешно добавлена");
                            break;
                        }
                    case 2:  // Удаление объекта
                        {
                            string name = InputString("Введите ФИО человека");
                            Person person = Find(sortedList, keyList, name);

                            if (!sortedList.ContainsKey(person)) Console.WriteLine("Запись не найдена");
                            else
                            {
                                sortedList.Remove(person);
                                Console.WriteLine("Запись успешно удалена");
                            }

                            break;
                        }
                    case 3:  // Вывод коллекции
                        {
                            PrintSortedList(sortedList, keyList);
                            break;
                        }
                    case 4:  // Сортировка всех студентов по рейтингу
                        {
                            Student[] studentList = CreateStudentList(sortedList, keyList);
                            Array.Sort(studentList, new SortByRating());
                            PrintStudentList(studentList);
                            break;
                        }
                    case 5:  // Сортировка студентов курса по имени
                        {
                            int kurs = InputInteger(1, 4, "Введите курс обучения");
                            SortedList kursList = CreateStudentList(sortedList, keyList, kurs);
                            PrintSortedList(kursList, keyList);
                            break;
                        }
                    case 6:  // Средняя зарплата работника
                        {
                            double averageIncome = AverageIncome(sortedList, keyList);
                            Console.WriteLine($"Средняя зарплата работника: {averageIncome} рублей");
                            break;
                        }
                    case 7:  // Поиск объекта
                        {
                            string name = InputString("Введите ФИО человека");
                            Person person = Find(sortedList, keyList, name);

                            if (!sortedList.ContainsKey(person)) Console.WriteLine("Запись не найденa");
                            else
                            {
                                Person p = sortedList[person] as Person;
                                if (p != null)
                                {
                                    p.Show();
                                    Console.WriteLine();
                                }
                            }
                            break;
                        }
                    case 8:  // Клонирование коллекции
                        {
                            copy = Copy(sortedList, keyList);
                            copied = true;
                            Console.WriteLine("Создана новая копия");
                            break;
                        }
                    case 9:  // Вывод последней копии
                        {
                            if (copied)
                            {
                                ICollection copiedListKeys = copy.Keys;
                                PrintSortedList(copy, copiedListKeys);
                            }
                            else Console.WriteLine("Копия не создана");
                            break;
                        }
                }

            } while (choice != 0);

            if (choice == 0) return;
        }

        // Второе задание
        static void Decision(SortedDictionary<Person, Person> dictionary)
        {
            int choice;
            SortedDictionary<Person, Person> copiedDictionary = new SortedDictionary<Person, Person>();  // Для хранении копии коллекции
            bool copied = false;

            do
            {
                PrintSecondTaskMenu();

                choice = InputInteger(0, 9, "Выберите действие");

                switch (choice)
                {
                    case 1:  // Добавить объект
                        {
                            AddObject(ref dictionary);
                            Console.WriteLine("Запись успешно добавлена");
                            break;
                        }
                    case 2:  // Удалить объект
                        {
                            string name = InputString("Введите ФИО человека");
                            Person person = Find(dictionary, name);

                            if (person != null)
                            {
                                dictionary.Remove(person);
                                Console.WriteLine("Запись успешно удалена");
                            }
                            else Console.WriteLine("Запись не найдена");

                            break;
                        }
                    case 3:  // Вывести коллекцию
                        {
                            PrintDictionary(dictionary);
                            break;
                        }
                    case 4:  // Список преподавателей английского
                        {
                            SortedDictionary<Person, Person> teacherList = CreateTeacherList(dictionary, "английский язык");
                            PrintDictionary(teacherList);
                            break;
                        }
                    case 5:  // Работники с з/п не менее введенного значения
                        {
                            int salary = InputInteger(0, 1000000000, "Введите нижнюю границу зарплаты");

                            SortedDictionary<Person, Person> employeeList = CreateEmployeeList(dictionary, salary);
                            PrintDictionary(employeeList);
                            break;
                        }
                    case 6:  // Cредний стаж преподавателя
                        {
                            double averageSeniority = AverageSeniority(dictionary);
                            Console.WriteLine($"Средний стаж преподавателя составляет {averageSeniority} лет");
                            break;
                        }
                    case 7:  // Поиск объекта
                        {
                            string name = InputString("Введите ФИО человека");
                            Person person = Find(dictionary, name);

                            if (person != null)
                            {
                                dictionary[person].Show();
                                Console.WriteLine();
                            }
                            else Console.WriteLine("Запись не найдена");

                            break;
                        }
                    case 8:  // Клонирование коллекции
                        {
                            copiedDictionary = Copy(dictionary);
                            copied = true;
                            Console.WriteLine("Копия успешно создана");
                            break;
                        }
                    case 9:  // Вывод последнего клона
                        {
                            if (copied) PrintDictionary(copiedDictionary);
                            else Console.WriteLine("Копия не создана");
                            break;
                        }
                }

            } while (choice != 0);

            if (choice == 0) return;
        }

        // Третье задание
        static void Decision(TestCollections collection)
        {
            int choice;
            Stopwatch watch = new Stopwatch();

            do
            {
                PrintThirdTaskMenu();

                choice = InputInteger(0, 7, "Выберите действие");

                switch (choice)
                {
                    case 1:  // Вывод
                        {
                            collection.Show();
                            break;
                        }
                    case 2:  // Добавление объекта
                        {
                            Student s = new Student();
                            s.Input();

                            collection.PersonList.Add(s.BasePerson);
                            collection.StringList.Add(s.Name);
                            collection.PersonDictionary.Add(s.BasePerson, s);
                            collection.StringDictionary.Add(s.Name, s);
                            Console.WriteLine("Запись успешно добавлена");

                            break;
                        }
                    case 3:  // Удаление объекта
                        {
                            string name = InputString("Введите имя студента");

                            bool check = collection.StringList.Remove(name);
                            if (!check) Console.WriteLine("Запись не найдена");
                            else
                            {
                                Person p = collection.StringDictionary[name];

                                collection.PersonList.Remove(p);
                                collection.PersonDictionary.Remove(p);
                                collection.StringDictionary.Remove(name);
                                Console.WriteLine("Запись успешно удалена");
                            }
                            break;
                        }
                    case 4:  // Сравнение скорости поиска первого элемента
                        {
                            string key = collection.StringList[0];
                            Student student = (Student)collection.StringDictionary[key].Clone();
                            Console.WriteLine("Сравнение скорости поиска первого элемента");

                            watch.Start();
                            bool result = collection.PersonList.Contains(student);
                            watch.Stop();
                            TimeSpan time = watch.Elapsed;
                            ShowTime("List<Person>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.StringList.Contains(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("List<string>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsKey(student.BasePerson);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.StringDictionary.ContainsKey(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<string, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsValue(student);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsValue", result, time);

                            break;
                        }
                    case 5:  // Сравнение скорости поиска последнего элемента
                        {
                            int last = collection.Length - 1;
                            string key = collection.StringList[last];
                            Student student = (Student)collection.StringDictionary[key].Clone();

                            Console.WriteLine("Сравнение скорости поиска последнего элемента");

                            watch.Start();
                            bool result = collection.PersonList.Contains(student);
                            watch.Stop();
                            TimeSpan time = watch.Elapsed;
                            ShowTime("List<Person>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.StringList.Contains(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("List<string>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsKey(student.BasePerson);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.StringDictionary.ContainsKey(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<string, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsValue(student);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsValue", result, time);

                            break;
                        }
                    case 6:  // Сравнение скорости поиска центрального элемента
                        {
                            int middle = GetMiddleIndex(collection.Length);
                            string key = collection.StringList[middle];
                            Student student = (Student)collection.StringDictionary[key].Clone();

                            Console.WriteLine("Сравнение скорости поиска центрального элемента");

                            watch.Start();
                            bool result = collection.PersonList.Contains(student);
                            watch.Stop();
                            TimeSpan time = watch.Elapsed;
                            ShowTime("List<Person>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.StringList.Contains(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("List<string>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsKey(student.BasePerson);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.StringDictionary.ContainsKey(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<string, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsValue(student);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsValue", result, time);

                            break;
                        }
                    case 7:  // Сравнение скорости поиска несуществующего элемента
                        {
                            Student student = new Student("Абв Где Жзи", 0, 0, 0);
                            string key = "Абв Где Жзи";
                            Console.WriteLine("Сравнение скорости поиска несуществующего элемента");

                            watch.Start();
                            bool result = collection.PersonList.Contains(student);
                            watch.Stop();
                            TimeSpan time = watch.Elapsed;
                            ShowTime("List<Person>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.StringList.Contains(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("List<string>, метод Contains", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsKey(student.BasePerson);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.StringDictionary.ContainsKey(key);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<string, Student>, метод ContainsKey", result, time);

                            watch.Restart();
                            result = collection.PersonDictionary.ContainsValue(student);
                            watch.Stop();
                            time = watch.Elapsed;
                            ShowTime("Dictionary<Person, Student>, метод ContainsValue", result, time);

                            break;
                        }
                }

            } while (choice != 0);

            if (choice == 0) return;
        }

        public static Person Find(SortedList sortedList, ICollection keyList, string name)
        {
            Person person = null;

            foreach(Person p in keyList)
                if(p.Name == name)
                {
                    person = (Person)p.Clone();
                    break;
                }

            return person;
        }

        public static Person Find(SortedDictionary<Person, Person> dictionary, string name)
        {
            Person person = null;

            foreach(KeyValuePair<Person,Person> pair in dictionary)
                if(pair.Key.Name == name)
                {
                    person = (Person)pair.Key.Clone();
                    break;
                }
            return person;
        }

        public static int GetMiddleIndex(int length)
        {
            if (length % 2 == 0) return length / 2 - 1;
            else return length / 2;
        }

        public static SortedDictionary<Person, Person> InitializeSortedDictionary(Person[] collection)
        {
            SortedDictionary<Person, Person> dictionary = new SortedDictionary<Person, Person>();

            foreach (Person person in collection)
                dictionary.Add(person, person);

            return dictionary;
        }

        public static SortedList InitializeSortedList(Person[] collection)
        {
            SortedList sortedList = new SortedList(41);

            foreach (Person person in collection)
                sortedList.Add(person.BasePerson, person);

            return sortedList;
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

        static void PrintDictionary(SortedDictionary<Person, Person> dictionary)
        {
            foreach (KeyValuePair<Person, Person> pair in dictionary)
            {
                pair.Value.Show();
                Console.WriteLine();
            }
        }

        static void PrintFirstTaskMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Добавить запись");
            Console.WriteLine("2 - Удалить запись");
            Console.WriteLine("3 - Вывести все записи");
            Console.WriteLine("4 - Отсортировать список всех студентов по рейтингу");
            Console.WriteLine("5 - Отсортировать список студентов курса по имени");
            Console.WriteLine("6 - Средняя зарплата работника");
            Console.WriteLine("7 - Поиск записи");
            Console.WriteLine("8 - Создание копии записей");
            Console.WriteLine("9 - Вывести последнюю копию");
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

        static void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Задание № 1: коллекции");
            Console.WriteLine("2 - Задание № 2: обобщенные коллекции");
            Console.WriteLine("3 - Задание № 3: сравнение скорости работы обобщенных коллекций");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintSecondTaskMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Добавить запись");
            Console.WriteLine("2 - Удалить запись");
            Console.WriteLine("3 - Вывести все записи");
            Console.WriteLine("4 - Вывести список преподавателей английского языка");
            Console.WriteLine("5 - Вывести список работников с зарплатой не менее указанной суммы");
            Console.WriteLine("6 - Средний стаж преподавателя");
            Console.WriteLine("7 - Поиск записи");
            Console.WriteLine("8 - Создание копии записей");
            Console.WriteLine("9 - Вывести последнюю копию");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintSortedList(SortedList sortedList, ICollection keyList)
        {
            foreach (Person person in keyList)
            {
                Person p = (Person)sortedList[person];
                if (p != null)
                {
                    p.Show();
                    Console.WriteLine();
                }
            }
        }

        static void PrintStudentList(Student[] studentList)
        {
            foreach (Student student in studentList)
            {
                student.Show();
                Console.WriteLine();
            }
        }

        static void PrintThirdTaskMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Вывести коллекцию");
            Console.WriteLine("2 - Добавить запись");
            Console.WriteLine("3 - Удалить запись");
            Console.WriteLine("4 - Провести сравнение для первого элемента");
            Console.WriteLine("5 - Провести сравнение для последнего элемента");
            Console.WriteLine("6 - Провести сравнение для центрального элемента");
            Console.WriteLine("7 - Провести сравнение для несуществующего элемента");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void ShowCollection(Person[] collection)
        {
            foreach (Person person in collection)
            {
                person.Show();
                Console.WriteLine();
            }
        }

        static void ShowTime(string collection, bool found, TimeSpan time)
        {
            if (found) Console.WriteLine($"{collection}: элемент найден. Затрачено времени: {time.Ticks} тиков");
            else Console.WriteLine($"{collection}: элемент не найден. Затрачено времени: {time.Ticks} тиков");
        }
    }
}
