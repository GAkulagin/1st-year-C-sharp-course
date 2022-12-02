using System;
using System.Collections.Generic;
using System.Linq;
using MyLibrary;

namespace Laba14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> coll_1 = new List<Person>();
            List<Person> coll_2 = new List<Person>();
            List<Person> coll_3 = new List<Person>();
            List<Person> coll_4 = new List<Person>();

            #region
            coll_1.Add(new Employee("Гончаров Дмитрий Андреевич", 41, "охранник", 24000));
            coll_1.Add(new Student("Ворхлик Александр Егорович", 19, 1, 60));
            coll_1.Add(new Student("Кулагин Григорий Андреевич", 19, 1, 24));
            coll_1.Add(new Teacher("Мельникова Ольга Сергеевна", 35, "преподаватель", 52000, "английский язык", 10));
            coll_1.Add(new Employee("Василевич Илья Константинович", 27, "охранник", 24000));
            coll_1.Add(new Student("Агамалиев Рустам Рагим-оглы", 18, 1, 13));
            coll_1.Add(new Student("Казарина Екатерина Васильевна", 19, 1, 18));
            coll_1.Add(new Employee("Костина Елизавета Петровна", 28, "повар", 20000));
            coll_1.Add(new Employee("Смирнов Всеволод Юрьевич", 30, "системный админ.", 48000));
            coll_1.Add(new Employee("Стариков Алексей Алексеевич", 26, "тех. специалист", 42000));

            coll_2.Add(new Student("Охота Борис Николаевич", 20, 1, 1));
            coll_2.Add(new Teacher("Захаров Дмитрий Алексеевич", 32, "преподаватель", 51000, "программирование", 8));
            coll_2.Add(new Teacher("Чекалкин Захар Павлович", 40, "преподаватель", 39000, "физическая культура", 15));
            coll_2.Add(new Teacher("Пентина Полина Олеговна", 37, "преподаватель", 52500, "право", 12));
            coll_2.Add(new Employee("Веретенников Артем Сергеевич", 50, "дворник", 21000));
            coll_2.Add(new Student("Дмитриев Арсений Алексеевич", 19, 1, 4));
            coll_2.Add(new Employee("Гынгазов Дмитрий Олегович", 32, "заведующий кафедрой ИТБ", 55000));
            coll_2.Add(new Employee("Пясецкая Анастасия Леонидовна", 27, "повар", 20000));
            coll_2.Add(new Teacher("Иванов Иван Иванович", 38, "преподаватель", 49000, "английский язык", 13));
            coll_2.Add(new Teacher("Кочурова Ольга Владимировна", 45, "преподаватель", 56000, "экономика", 20));

            coll_3.Add(new Student("Никитин Андрей Владимирович", 21, 2, 7));
            coll_3.Add(new Student("Божко Максим Александрович", 20, 2, 43));
            coll_3.Add(new Student("Селина Анна Дмитриевна", 20, 2, 32));
            coll_3.Add(new Student("Иванов Виктор Юрьевич", 21, 2, 3));
            coll_3.Add(new Student("Максимов Иван Максимович", 21, 2, 40));
            coll_3.Add(new Student("Костин Виктор Сергеевич", 20, 2, 37));
            coll_3.Add(new Student("Панин Александр Олегович", 22, 3, 28));
            coll_3.Add(new Student("Пахомов Герман Сергеевич", 22, 3, 43));
            coll_3.Add(new Student("Бреничев Никита Анатольевич", 23, 3, 51));
            coll_3.Add(new Student("Илькаев Артур Ринатович", 21, 3, 29));

            coll_4.Add(new Student("Шиляев Илья Григорьевич", 22, 3, 15));
            coll_4.Add(new Student("Филатова Валерия Михайловна", 23, 3, 18));
            coll_4.Add(new Student("Колеватов Владислав Николаевич", 24, 4, 31));
            coll_4.Add(new Student("Зубенко Михаил Петрович", 24, 4, 20));
            coll_4.Add(new Student("Сагидуллин Рамиль Альбертович", 23, 4, 39));
            coll_4.Add(new Student("Маслов Александр Владимирович", 25, 4, 52));
            coll_4.Add(new Student("Сеген Елизавета Максимовна", 24, 4, 56));
            coll_4.Add(new Student("Элькинд Марина Михайловна", 25, 4, 5));
            coll_4.Add(new Teacher("Ганихин Ярослав Алексеевич", 44, "преподаватель", 57000, "алгебра и мат. анализ", 19));
            coll_4.Add(new Teacher("Кучкин Алексей Николаевич", 35, "преподаватель", 39000, "физическая культура", 10));
            #endregion
            List<List<Person>> list = new List<List<Person>>();
            list.Add(coll_1);
            list.Add(coll_2);
            list.Add(coll_3);
            list.Add(coll_4);

            int choice;
            do
            {
                PrintMainMenu();
                choice = InputInteger(0, 2, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            DoWithLINQ(list);
                            break;
                        }
                    case 2:
                        {
                            DoWithExtendedLINQMethods(list);
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            } while (choice != 0);
        }


        static void DoWithExtendedLINQMethods(List<List<Person>> list)
        {
            int choice;

            do
            {
                PrintMenu();
                choice = InputInteger(0, 5, "Выберите действие");

                switch (choice)
                {
                    // Выбрать всех студентов указанного курса
                    case 1:
                        {
                            int kurs = InputInteger(1, 4, "Введите курс обучения");

                            List<Student> students = GetStudentList(list);

                            var kursList = students.Where(s => s.Kurs == kurs);

                            foreach (var kl in kursList) Console.WriteLine(kl);

                            break;
                        }
                    // Получить число работников указанного возраста и старше
                    case 2:
                        {
                            int age = InputInteger(18, 90, "Введите возраст");

                            List<Employee> employees = GetEmployeeList(list);

                            int count = employees.Where(e => e.Age >= age).Count();

                            Console.WriteLine($"Всего работников от {age} лет и старше: {count}");

                            break;
                        }
                    // Объединить студентов двух курсов
                    case 3:
                        {
                            int firstKurs = InputInteger(1, 4, "Введите курс обучения");
                            int secondKurs = InputInteger(1, 4, "Введите курс обучения");

                            List<Student> students = GetStudentList(list);
                            var firstKursList = students.Where(s => s.Kurs == firstKurs);
                            var secondKursList = students.Where(s => s.Kurs == secondKurs);

                            var bothKurses = firstKursList.Union(secondKursList);

                            foreach (var s in bothKurses) Console.WriteLine(s);

                            break;
                        }
                    // Средний стаж преподавателей
                    case 4:
                        {
                            List<Teacher> teachers = GetTeacherList(list);
                            double average = teachers.Average(t => t.Seniority);

                            Console.WriteLine($"Средний препоавательский стаж: {Math.Round(average, 1, MidpointRounding.AwayFromZero)} лет");

                            break;
                        }
                    // Сгруппировать студентов по курсам
                    case 5:
                        {
                            List<Student> students = GetStudentList(list);
                            var groups = students.GroupBy(s => s.Kurs);

                            foreach (IGrouping<int, Student> group in groups)
                            {
                                Console.WriteLine(group.Key);

                                foreach (var item in group) Console.WriteLine(item.Name);
                                Console.WriteLine();
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

        static void DoWithLINQ(List<List<Person>> list)
        {
            int choice;

            do
            {
                PrintMenu();
                choice = InputInteger(0, 5, "Выберите действие");

                switch (choice)
                {
                    // Выбрать всех студентов указанного курса
                    case 1:
                        {
                            int kurs = InputInteger(1, 4, "Введите курс обучения");

                            List<Student> students = GetStudentList(list);
                            List<Student> kursList = GetKursList(students, kurs);
                            PrintList<Student>(kursList); // Почему возможно упрощение?

                            break;
                        }
                    // Получить число работников указанного возраста и старше
                    case 2:
                        {
                            int age = InputInteger(18, 90, "Введите возраст");

                            List<Employee> employees = GetEmployeeList(list);
                            int count = GetEmployeeCountByAge(employees, age);

                            Console.WriteLine($"Всего работников от {age} лет и старше: {count}");

                            break;
                        }

                    // Объединить студентов двух курсов
                    case 3:
                        {
                            int frstKurs = InputInteger(1, 4, "Введите курс обучения");
                            int secndKurs = InputInteger(1, 4, "Введите курс обучения");

                            List<Student> students = GetStudentList(list);
                            List<Student> frstKursList = GetKursList(students, frstKurs);
                            List<Student> secndKursList = GetKursList(students, secndKurs);
                            UnionByKurs(frstKursList, secndKursList);

                            break;
                        }

                    // Средний стаж преподавателей
                    case 4:
                        {
                            List<Teacher> teachers = GetTeacherList(list);
                            double average = GetAverageSeniority(teachers);

                            Console.WriteLine($"Средний препоавательский стаж: {Math.Round(average, 1, MidpointRounding.AwayFromZero)} лет");

                            break;
                        }

                    // Сгруппировать студентов по курсам
                    case 5:
                        {
                            List<Student> students = GetStudentList(list);
                            GroupByKurs(students);

                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            } while (choice != 0);
        }

        static double GetAverageSeniority(List<Teacher> list)
        {
            List<int> seniority = new List<int>();
            foreach (Teacher t in list) seniority.Add(t.Seniority);

            return (from item in seniority select item).Average();
        }

        static int GetEmployeeCountByAge(List<Employee> list, int age)
        {
            // Здесь запрос выполняется немедленно
            int count = (from item in list
                         where item.Age >= age
                         select item).Count();

            return count;
        }

        static List<Employee> GetEmployeeList(List<List<Person>> list)
        {
            var employees = from l in list
                            from item in l
                           where item is Employee
                           select item;

            List<Employee> selected = new List<Employee>();

            foreach (var e in employees) selected.Add((Employee)e);

            return selected;
        }

        static List<Student> GetKursList(List<Student> list, int kurs)
        {
            // Здесь запрос выполняется немедленно
            List<Student> kursList = (from item in list
                           where item.Kurs == kurs
                           select item).ToList();

            return kursList;
        }

        static List<Student> GetStudentList(List<List<Person>> list)
        {
            var students = from l in list
                           from item in l
                           where item is Student
                           select item;

            List<Student> selected = new List<Student>();

            foreach (var s in students) selected.Add((Student)s);

            return selected;
        }

        static List<Teacher> GetTeacherList(List<List<Person>> list)
        {
            var teachers = from l in list
                           from item in l
                           where item is Teacher
                           select item;

            List<Teacher> selected = new List<Teacher>();

            foreach (var t in teachers) selected.Add((Teacher)t);

            return selected;
        }

        static void GroupByKurs(List<Student> list)
        {
            var a = from item in list
                    group item by item.Kurs;

            foreach (IGrouping<int, Student> group in a)
            {
                Console.WriteLine(group.Key);

                foreach (var g in group) Console.WriteLine(g.Name);
                Console.WriteLine();
            }
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

        static void PrintList<T>(List<T> list)
        {
            foreach (var p in list) Console.WriteLine(p);
        }

        static void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - LINQ - запросы");
            Console.WriteLine("2 - Методы расширения LINQ - запросов");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Выбрать всех студентов указанного курса");
            Console.WriteLine("2 - Получить число работников указанного возраста и старше");
            Console.WriteLine("3 - Объединить студентов двух курсов");
            Console.WriteLine("4 - Получить средний стаж преподавателей");
            Console.WriteLine("5 - Сгруппировать студентов по курсам");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }

        static void UnionByKurs(List<Student> kurs1, List<Student> kurs2)
        {
            var union = (from item1 in kurs1 select item1).Union(from item2 in kurs2 select item2);

            foreach (var u in union) Console.WriteLine(u);
        }
    }
}
