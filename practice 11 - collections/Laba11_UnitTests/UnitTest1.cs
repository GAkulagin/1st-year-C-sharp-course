using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System.Collections;
using System.Collections.Generic;
using Laba11;

namespace Laba11_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Первое задание 
        #region
        [TestMethod]
        public void InitializeSortedList_Test()
        {
            // arrange
            Person[] collection = new Person[3];
            collection[0] = new Student("Иванов Иван Иванович", 19, 1, 10);
            collection[1] = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            collection[2] = new Person("Сидоров Сидор Сидорович", 40);
            
            // act
            SortedList list = Program.InitializeSortedList(collection);
            // assert
            collection[0].Equals(list[collection[0].BasePerson]);
            collection[1].Equals(list[collection[1].BasePerson]);
            collection[2].Equals(list[collection[2].BasePerson]);
        }

        [TestMethod]
        public void FindInSortedList_Test()
        {
            // arrange
            SortedList list = new SortedList(4);
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            list.Add(s.BasePerson, s);
            list.Add(t.BasePerson, t);
            list.Add(e.BasePerson, e);
            list.Add(p, p);
            // act
            Person person = Program.Find(list, list.Keys, "Иванов Иван Иванович");
            // assert
            person.Equals(t);
        }

        [TestMethod]
        public void CreateStudentListFromSortedList_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedList list = new SortedList(4);
            list.Add(s.BasePerson, s);
            list.Add(t.BasePerson, t);
            list.Add(e.BasePerson, e);
            list.Add(p, p);

            Student[] studentList = new Student[1];
            studentList[0] = s;
            // act
            Student[] expectedList = Program.CreateStudentList(list, list.Keys);

            // assert
            expectedList[0].Equals(s);
        }

        [TestMethod]
        public void CreateStudentListFromSortedList2_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Student s1 = new Student("Иванов Сергей Иванович", 22, 4, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedList list = new SortedList(5);
            list.Add(s.BasePerson, s);
            list.Add(t.BasePerson, t);
            list.Add(e.BasePerson, e);
            list.Add(p, p);
            list.Add(s1.BasePerson, s1);

            SortedList studentList = new SortedList(1);
            studentList.Add(s.BasePerson, s);
            // act
            SortedList expectedList = Program.CreateStudentList(list, list.Keys, 1);
            // assert
            Assert.AreEqual(studentList.Count, expectedList.Count);
            studentList[s.BasePerson].Equals(expectedList[s.BasePerson]);
        }

        [TestMethod]
        public void AverageIncome_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 20000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 30000);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedList list = new SortedList(4);
            list.Add(s.BasePerson, s);
            list.Add(t.BasePerson, t);
            list.Add(e.BasePerson, e);
            list.Add(p, p);

            double expected = 25000;
            // act
            double actual = Program.AverageIncome(list, list.Keys);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CopySortedList_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 20000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 30000);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedList expected = new SortedList(4);
            expected.Add(s.BasePerson, s);
            expected.Add(t.BasePerson, t);
            expected.Add(e.BasePerson, e);
            expected.Add(p, p);
            // act
            SortedList actual = Program.Copy(expected, expected.Keys);
            // assert
            expected[s.BasePerson].Equals(actual[s.BasePerson]);
            expected[t.BasePerson].Equals(actual[t.BasePerson]);
            expected[e.BasePerson].Equals(actual[e.BasePerson]);
            expected[p.BasePerson].Equals(actual[p.BasePerson]);
        }
        #endregion

        // Bтopое задание 
        #region
        [TestMethod]
        public void InitializeSortedDictionary_Test()
        {
            // arrange
            Person[] collection = new Person[3];
            collection[0] = new Student("Иванов Иван Иванович", 19, 1, 10);
            collection[1] = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            collection[2] = new Person("Сидоров Сидор Сидорович", 40);

            SortedDictionary<Person, Person> expected = new SortedDictionary<Person, Person>();
            foreach (Person p in collection)
                expected.Add(p, p);
            // act
            SortedDictionary<Person, Person> actual = Program.InitializeSortedDictionary(collection);
            // assert
            expected[collection[0]].Equals(actual[collection[0]]);
            expected[collection[1]].Equals(actual[collection[1]]);
            expected[collection[2]].Equals(actual[collection[2]]);
        }

        [TestMethod]
        public void FindInSortedDictionary_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedDictionary<Person, Person> dictionary = new SortedDictionary<Person, Person>();
            dictionary.Add(s.BasePerson, s);
            dictionary.Add(t.BasePerson, t);
            dictionary.Add(e.BasePerson, e);
            dictionary.Add(p, p);
            // act
            Person person = Program.Find(dictionary, "Сидоров Сидор Сидорович");
            // assert.
            person.Equals(p);
        }

        [TestMethod]
        public void CreateTeacherList_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Teacher t1 = new Teacher("Петров Сергей Петрович", 30, "преподаватель", 35000, "русский язык", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedDictionary<Person, Person> dictionary = new SortedDictionary<Person, Person>();
            dictionary.Add(s.BasePerson, s);
            dictionary.Add(t.BasePerson, t);
            dictionary.Add(e.BasePerson, e);
            dictionary.Add(p, p);

            SortedDictionary<Person, Person> expected = new SortedDictionary<Person, Person>();
            expected.Add(t.BasePerson, t);
            // act
            SortedDictionary<Person, Person> actual = Program.CreateTeacherList(dictionary, "алгебра");
            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            expected[t.BasePerson].Equals(actual[t.BasePerson]);
        }

        [TestMethod]
        public void CreateEmployeeList_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedDictionary<Person, Person> dictionary = new SortedDictionary<Person, Person>();
            dictionary.Add(s.BasePerson, s);
            dictionary.Add(t.BasePerson, t);
            dictionary.Add(e.BasePerson, e);
            dictionary.Add(p, p);

            SortedDictionary<Person, Person> expected = new SortedDictionary<Person, Person>();
            expected.Add(t.BasePerson, t);
            // act
            SortedDictionary<Person, Person> actual = Program.CreateEmployeeList(dictionary, 33000);
            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            expected[t.BasePerson].Equals(actual[t.BasePerson]);
        }

        [TestMethod]
        public void AverageSeniority_Test()
        {
            // arrange
            Teacher t1 = new Teacher("Петров Игорь Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Teacher t2 = new Teacher("Петров Егор Петрович", 30, "преподаватель", 35000, "алгебра", 20);
            Teacher t3 = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 30);

            SortedDictionary<Person, Person> dictionary = new SortedDictionary<Person, Person>();
            dictionary.Add(t1.BasePerson, t1);
            dictionary.Add(t2.BasePerson, t2);
            dictionary.Add(t3.BasePerson, t3);

            double expected = 20;
            // act
            double actual = Program.AverageSeniority(dictionary);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CopyOfSortedDictionary_Test()
        {
            // arrange
            Student s = new Student("Иванов Иван Иванович", 19, 1, 10);
            Teacher t = new Teacher("Петров Петр Петрович", 30, "преподаватель", 35000, "алгебра", 10);
            Employee e = new Employee("Николаев Николай Николаевич", 45, "сваршик", 32550);
            Person p = new Person("Сидоров Сидор Сидорович", 40);

            SortedDictionary<Person, Person> expected = new SortedDictionary<Person, Person>();
            expected.Add(s.BasePerson, s);
            expected.Add(t.BasePerson, t);
            expected.Add(e.BasePerson, e);
            expected.Add(p, p);
            // act
            SortedDictionary<Person, Person> actual = Program.Copy(expected);
            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            expected[s.BasePerson].Equals(actual[s.BasePerson]);
            expected[t.BasePerson].Equals(actual[t.BasePerson]);
            expected[e.BasePerson].Equals(actual[e.BasePerson]);
            expected[p.BasePerson].Equals(actual[p.BasePerson]);
        }
        #endregion

        // Третье задание
        [TestMethod]
        public void GetMiddleIndex1_Test()
        {
            // arrange
            int length = 10;
            int expected = 4;
            // act
            int actual = Program.GetMiddleIndex(length);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMiddleIndex2_Test()
        {
            // arrange
            int length = 15;
            int expected = 7;
            // act
            int actual = Program.GetMiddleIndex(length);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void TestCollectionsCOnstructor_Test()
        {
            // arrange
            int expectedLength = 10;
            // act
            TestCollections collection = new TestCollections(10);
            // assert
            Assert.AreEqual(collection.PersonList.Capacity, expectedLength);
            Assert.AreEqual(collection.StringList.Capacity, expectedLength);
        }
    }
}
