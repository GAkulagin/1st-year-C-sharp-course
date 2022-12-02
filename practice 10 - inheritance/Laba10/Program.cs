using System;
using System.Text.RegularExpressions;

namespace Laba10
{
    public class Program
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
        static string InputKeyWord(string message)
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
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Отсортировать список студентов курса по рейтингу");  // RTTI
            Console.WriteLine("2 - Средняя зарплата работника");
            Console.WriteLine("3 - Вывести список преподавателей");
            Console.WriteLine("4 - Отсортировать список студентов по имени");  // IComparable
            Console.WriteLine("5 - Найти работника");
            Console.WriteLine("0 - Завершить работу");
            Console.WriteLine();
        }
        static void Decision(Person[] collection)
        {
            int choice;

            do
            {
                PrintMenu();
                choice = CheckInput(0, 5, "Выберите действие");

                switch (choice)
                {
                    case 1:
                        {
                            int kurs = CheckInput(1, 4, "Введите номер курса");

                            Student[] kursArray = GetKursArray(ref collection, kurs);
                            SortKursArray(kursArray);
                            PrintKursArray(ref kursArray);
                            
                            break;
                        }
                    case 2:
                        {
                            Employee[] employeeList = GetEmployeeList(ref collection);
                            double averageIncome = GetAverageIncome(ref employeeList);
                            Console.WriteLine($"Средняя зарплата работника составляет {averageIncome} руб.");

                            break;
                        }
                    case 3:
                        {
                            PrintTeacherList(ref collection);

                            break;
                        }
                    case 4:
                        {
                            Student[] studentList = GetStudentList(ref collection);
                            Array.Sort(studentList, new SortByName());
                            PrintStudentList(ref studentList);

                            break;
                        }
                    case 5:
                        {
                            string key = InputKeyWord("Введите фамилию и имя работника");
                            Employee[] employeeList = GetEmployeeList(ref collection);
                            Employee employee = FindEmployee(employeeList, key);

                            if (employee == null)
                                Console.WriteLine("Ничего не найдено");
                            else Console.WriteLine($"{employee.Name}:   {employee.Job}");

                            break;
                        }
                }

            } while (choice != 0);

            if (choice == 0)
                return;
        }

        public static Student[] GetKursArray(ref Person[] collection, int kurs)
        {
            int count = 0;
            Student s = new Student();

            foreach (Person p in collection)
            {
                s = p as Student;
                if (s != null && s.Kurs == kurs)
                    count++;
            }

            Student[] kursArray = new Student[count];
            count = 0;

            for(int i = 0; i < collection.Length; i++)
            {
                s = collection[i] as Student;
                if(s != null && s.Kurs == kurs)
                {
                    kursArray[count] = (Student)s.Clone();
                    count++;
                }
            }

            return kursArray;
        }
        public static Student[] GetStudentList(ref Person[] collection)
        {
            int count = 0;

            foreach (Person p in collection)
                if (p is Student)
                    count++;

            Student[] array = new Student[count];
            Student s = new Student();
            count = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                s = collection[i] as Student;
                if (s != null)
                {
                    array[count] = (Student)s.Clone();
                    count++;
                }
            }

            return array;
        }
        public static Employee[] GetEmployeeList(ref Person[] collection)
        {
            int count = 0;

            foreach (Person p in collection)
                if (p is Employee)
                    count++;

            Employee[] array = new Employee[count];
            Employee e = new Employee();
            count = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                e = collection[i] as Employee;
                if (e != null)
                {
                    array[count] = (Employee)e.Clone();
                    count++;
                }
            }

            return array;
        }
        public static double GetAverageIncome(ref Employee[] array)
        {
            double result = 0.0;

            foreach (Employee e in array)
                result += e.Salary;

            result = Math.Round(result / array.Length, 2, MidpointRounding.AwayFromZero);

            return result;
        }

        static void PrintKursArray(ref Student[] kursArray)
        {
            for (int i = 0; i < kursArray.Length; i++)
                Console.WriteLine($"{kursArray[i].Name}:   {kursArray[i].Rating}");
        }   
        static void PrintTeacherList(ref Person[] collection)
        {
            Teacher teacher = new Teacher();

            foreach (Person p in collection)
                if (p is Teacher)
                {
                    teacher = p as Teacher;
                    Console.WriteLine(teacher.Name + "   " + teacher.Science);
                }
        }     
        static void PrintStudentList(ref Student[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i].Name);
        }

        public static void SortKursArray(Student[] kursArray)
        {
            int[] ratingArray = new int[kursArray.Length];

            for (int i = 0; i < ratingArray.Length; i++)
                ratingArray[i] = kursArray[i].Rating;

            Array.Sort(ratingArray, kursArray);
        }
        public static Employee FindEmployee(Employee[] array, string key)
        {
            Employee employee = null;

            foreach (Employee e in array)
                if (e.Name.CompareTo(key) == 0)
                {
                    employee = (Employee)e.Clone();
                    break;
                }

            return employee;
        }

        static void Main(string[] args)
        {

                // иниц. готовой коллекции
                #region 
                Person[] collection = new Person[41];
                collection[0] = new Employee("Гончаров Дмитрий", "охранник", 24000);
                collection[1] = new Student("Ворхлик Александр", 1, 60);
                collection[2] = new Student("Кулагин Григорий", 1, 24);
                collection[3] = new Teacher("Мельникова Ольга", "преподаватель", 52000, "английский язык", 10);
                collection[4] = new Employee("Василевич Илья", "охранник", 24000);
                collection[5] = new Student("Агамалиев Рустам", 1, 13);
                collection[6] = new Student("Казарина Екатерина", 1, 18);
                collection[7] = new Employee("Костина Елизавета", "повар", 20000);
                collection[8] = new Employee("Смирнов Всеволод", "системный админ.", 48000);
                collection[9] = new Employee("Стариков Алексей", "тех. специалист", 42000);
                collection[10] = new Student("Охота Борис", 1, 1);
                collection[11] = new Teacher("Захаров Дмитрий", "преподаватель", 51000, "программирование", 8);
                collection[12] = new Teacher("Чекалкин Захар", "преподаватель", 39000, "физическая культура", 15);
                collection[13] = new Teacher("Пентина Полина", "преподаватель", 52500, "право", 12);
                collection[14] = new Employee("Веретенников Артем", "дворник", 21000);
                collection[15] = new Student("Дмитриев Арсений", 1, 4);
                collection[16] = new Employee("Гынгазов Дмитрий", "начальник по пожарной безопасности", 55000);
                collection[17] = new Employee("Пясецкая Анастасия", "повар", 20000);
                collection[18] = new Teacher("Иванов Иван", "преподаватель", 49000, "английский язык", 13);
                collection[19] = new Teacher("Кочурова Ольга", "преподаватель", 56000, "экономика", 20);
                collection[20] = new Student("Никитин Андрей", 2, 7);
                collection[21] = new Student("Божко Максим", 2, 43);
                collection[22] = new Student("Селина Анна", 2, 32);
                collection[23] = new Student("Иванов Виктор", 2, 3);
                collection[24] = new Student("Максимов Иван", 2, 40);
                collection[25] = new Student("Костин Виктор", 2, 37);
                collection[26] = new Student("Панин Александр", 3, 28);
                collection[27] = new Student("Пахомов Герман", 3, 43);
                collection[28] = new Student("Бреничев Никита", 3, 51);
                collection[29] = new Student("Илькаев Артур", 3, 29);
                collection[30] = new Student("Шиляев Илья", 3, 15);
                collection[31] = new Student("Филатова Валерия", 3, 18);
                collection[32] = new Student("Колеватов Владислав", 4, 31);
                collection[33] = new Student("Зубенко Михаил", 4, 20);
                collection[34] = new Student("Сагидуллин Рамиль", 4, 39);
                collection[35] = new Student("Маслов Александр", 4, 52);
                collection[36] = new Student("Сеген Елизавета", 4, 56);
                collection[37] = new Student("Элькинд Марина", 4, 5);
                collection[38] = new Teacher("Ганихин Ярослав", "преподаватель", 57000, "алгебра и мат. анализ", 19);
                collection[39] = new Teacher("Кучкин Алексей", "преподаватель", 39000, "физическая культура", 10);
                collection[40] = new Teacher("Замилов Руслан", "преподаватель", 47750, "история", 21);
            #endregion

            for (int i = 0; i < 41; i++)
            {
                collection[i].Show();
                Console.WriteLine();
            }
            Decision(collection);
        }
    }
}
