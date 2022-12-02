using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba10;

namespace Laba10UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // class Person
        [TestMethod]
        public void PersonNoParams()  // конструктор класса Person без параметров
        {
            // arrange
            string expected = "";
            // act
            Person p = new Person();
            // assert
            Assert.AreEqual(expected, p.Name);
        }
        [TestMethod]
        public void PersonWithParams()  //  Конструктор Person с параметрами
        {
            // arrange
            string expected = "Вова Вовочкин";
            // act
            Person p = new Person("Вова Вовочкин");
            // assert
            Assert.AreEqual(expected, p.Name);
        }
        [TestMethod]
        public void PersonWithParams1()  //  Конструктор Person с параметрами, строка введена неверно
        {
            // arrange
            string expected = "";
            // act
            Person p = new Person("Вова 123");
            // assert
            Assert.AreEqual(expected, p.Name);
        }


        // class Student
        [TestMethod]
        public void StudentNoParams()  // Конструктор Student без параметров
        {
            // arrange
            string expectedName = "";
            int expectedKurs = 0;
            int expectedRating = 0;
            // act
            Student s = new Student();
            // assert
            Assert.AreEqual(expectedName, s.Name);
            Assert.AreEqual(expectedKurs, s.Kurs);
            Assert.AreEqual(expectedRating, s.Rating);
        }
        [TestMethod]
        public void StudentWithParams()  // Конструктор Student с параметрами
        {
            // arrange
            string expectedName = "Вова Иванов";
            int expectedKurs = 1;
            int expectedRating = 10;
            // act
            Student s = new Student("Вова Иванов", 1, 10);
            // assert
            Assert.AreEqual(expectedName, s.Name);
            Assert.AreEqual(expectedKurs, s.Kurs);
            Assert.AreEqual(expectedRating, s.Rating);
        }
        [TestMethod]
        public void StudentWithParams1()  // Конструктор Student с параметрами, курс и рейтинг заданы неверно
        {
            // arrange
            int expectedKurs = 0;
            int expectedRating = 0;
            // act
            Student s = new Student("Вова Вовочкин", 222, -6);
            // assert
            Assert.AreEqual(expectedKurs, s.Kurs);
            Assert.AreEqual(expectedRating, s.Rating);
        }
        [TestMethod]
        public void StudentWithParams2()  // Конструктор Student с параметрами, курс задан неверно
        {
            // arrange
            int expectedKurs = 0;
            // act
            Student s = new Student("Вова Вовочкин", -11, -6);
            // assert
            Assert.AreEqual(expectedKurs, s.Kurs);
        }
        [TestMethod]
        public void StudentClone()  // определение метода Clone (ICloneable) класса Student
        {
            // arrange
            Student s1 = new Student("Зубенко Михаил", 2, 2);
            // act
            Student s1Clone = (Student)s1.Clone();
            // assert
            s1Clone.Equals(s1);
        }

        // class Employee
        [TestMethod]
        public void EmployeeNoParams()  // Конструктор Employee без параметров
        {
            // arrange
            string expJob = "";
            int expSalary = 0;
            // act
            Employee e = new Employee();
            // Assert
            Assert.AreEqual(expJob, e.Job);
            Assert.AreEqual(expSalary, e.Salary);
        }
        [TestMethod]
        public void EmployeeWithParams()  // Конструктор Employee с параметрами
        {
            // arrange
            string expJob = "физрук";
            int expSalary = 9999;
            // act
            Employee e = new Employee("", "физрук", 9999);
            // Assert
            Assert.AreEqual(expJob, e.Job);
            Assert.AreEqual(expSalary, e.Salary);
        }
        [TestMethod]
        public void EmployeeWitWronghParams()  // Конструктор Employee с параметрами, должность и зарплата заданы неверно
        {
            // arrange
            string expJob = "";
            int expSalary = 0;
            // act
            Employee e = new Employee("", "12345", -1);
            // Assert
            Assert.AreEqual(expJob, e.Job);
            Assert.AreEqual(expSalary, e.Salary);
        }
        [TestMethod]
        public void EmployeeCompareToZero()  // определение метода CompareTo (IComparable) класса Employee, результат = 0
        {
            // arrange
            int expected = 0;
            string name = "Василевич Илья";
            Employee e = new Employee("Василевич Илья", "", 0);
            // act
            int actual = e.CompareTo(name);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmployeeCompareToMinusOne()  // определение метода CompareTo (IComparable) класса Employee, результат = -1
        {
            // arrange
            int expected = -1;
            string name = "Василевич Илья";
            Employee e = new Employee("Ульянов Владимир", "", 0);
            // act
            int actual = e.CompareTo(name);
            // assert
            Assert.AreEqual(expected, actual);
        }

        // class Teacher
        [TestMethod]
        public void TeacherNoParams()  // Конструктор Teacher без параметров
        {
            // arrange
            string expScience = "";
            int expSeniority = 0;
            // act
            Teacher t = new Teacher();
            // assert
            Assert.AreEqual(expScience, t.Science);
            Assert.AreEqual(expSeniority, t.Seniority);
        }
        [TestMethod]
        public void TeacherWithParams()  // Конструктор Teacher с параметрами
        {
            // arrange
            string expScience = "информатика";
            int expSeniority = 5;
            // act
            Teacher t = new Teacher("", "", 0, "информатика", 5);
            // assert
            Assert.AreEqual(expScience, t.Science);
            Assert.AreEqual(expSeniority, t.Seniority);
        }
        [TestMethod]
        public void TeacherWithWrongParams()  // Конструктор Teacher с параметрами, заданными неверно
        {
            // arrange
            string expScience = "";
            int expSeniority = 0;
            // act
            Teacher t = new Teacher("", "", 0, "ghbdtn", -3);
            // assert
            Assert.AreEqual(expScience, t.Science);
            Assert.AreEqual(expSeniority, t.Seniority);
        }

        // class Program
        [TestMethod]
        public void ProgramGetKursArray()  // метод GetKursArray()
        {
            // arrange
            int kurs = 3;
            Person[] array = new Person[5];
            array[0] = new Student("Варенцов Даниил", 3, 10);
            array[1] = new Student("Василюк Василий", 3, 11);
            array[2] = new Student("Маслов Александр", 1, 12);
            array[3] = new Person();
            array[4] = new Person();

            Student[] expectedList = new Student[2];
            expectedList[0] = new Student("Варенцов Даниил", 3, 10);
            expectedList[1] = new Student("Василюк Василий", 3, 11);
            // act
            Student[] actualList = Program.GetKursArray(ref array, kurs);
            // assert
            Assert.AreEqual(expectedList.Length, actualList.Length);
            for (int i = 0; i < 2; i++)
                expectedList[i].Equals(actualList[i]);
        }
        [TestMethod]
        public void ProgramGetStudentList()  // метод GetStudentList()
        {
            // arrange
            Person[] array = new Person[5];
            array[0] = new Student("Варенцов Даниил", 3, 10);
            array[1] = new Student("Василюк Василий", 3, 11);
            array[2] = new Student("Маслов Александр", 1, 12);
            array[3] = new Person();
            array[4] = new Person();

            Student[] expectedList = new Student[3];
            expectedList[0] = new Student("Варенцов Даниил", 3, 10);
            expectedList[1] = new Student("Василюк Василий", 3, 11);
            expectedList[2] = new Student("Маслов Александр", 1, 12);
            // act
            Student[] actualList = Program.GetStudentList(ref array);
            // assert
            Assert.AreEqual(expectedList.Length, actualList.Length);
            for (int i = 0; i < 3; i++)
                expectedList[i].Equals(actualList[i]);
        }
        [TestMethod]
        public void ProgramGetEmployeeList()  // метод GetEmployeeList()
        {
            // arrange
            Person[] array = new Person[5];
            array[0] = new Employee("Варенцов Даниил", "охранник", 10);
            array[1] = new Employee("Василюк Василий", "повар", 11);
            array[2] = new Employee("Маслов Александр", "безработный", 12);
            array[3] = new Person();
            array[4] = new Person();

            Employee[] expectedList = new Employee[3];
            expectedList[0] = new Employee("Варенцов Даниил", "охранник", 10);
            expectedList[1] = new Employee("Василюк Василий", "повар", 11);
            expectedList[2] = new Employee("Маслов Александр", "безработный", 12);
            // act
            Employee[] actualList = Program.GetEmployeeList(ref array);
            // assert
            Assert.AreEqual(expectedList.Length, actualList.Length);
            for (int i = 0; i < 3; i++)
                expectedList[i].Equals(actualList[i]);
        }
        [TestMethod]
        public void ProgramGetAverageIncome()  // метод GetAverageIncome()
        {
            // arrange
            double expected = 15.0;
            Employee[] array = new Employee[2];
            array[0] = new Employee("Варенцов Даниил", "охранник", 10);
            array[1] = new Employee("Василюк Василий", "повар", 20);
            // act
            double actual = Program.GetAverageIncome(ref array);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ProgramFindEmployee()  // метод FindEmployee()
        {
            // arrange
            Employee[] array = new Employee[3];
            array[0] = new Employee("Варенцов Даниил", "охранник", 10);
            array[1] = new Employee("Василюк Василий", "повар", 20);
            array[2] = new Employee("Шпигель Спайк", "уборшик", 0);
            Employee expected = new Employee("Шпигель Спайк", "уборшик", 0);
            string key = "Шпигель Спайк";
            // act
            Employee actual = Program.FindEmployee(array, key);
            // assert
            expected.Equals(actual);
        }
        [TestMethod]
        public void ProgramSortStudentList()
        {
            // arrange
            Student[] array = new Student[4];
            array[0] = new Student("Филатова Валерия", 4, 4);
            array[1] = new Student("Колеватов Владислав", 4, 2);
            array[2] = new Student("Зубенко Михаил", 4, 1);
            array[3] = new Student("Сагидуллин Рамиль", 4, 3);

            Student[] expectedList = new Student[4];
            expectedList[0] = new Student("Зубенко Михаил", 4, 1);
            expectedList[1] = new Student("Колеватов Владислав", 4, 2);
            expectedList[2] = new Student("Сагидуллин Рамиль", 4, 3);
            expectedList[3] = new Student("Филатова Валерия", 4, 4);
            // act
            Program.SortKursArray(array);
            // assert
            for (int i = 0; i < 4; i++)
                expectedList[i].Equals(array[i]);
        }
    }
}
