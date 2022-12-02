using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba13;
using MyLibrary;

namespace Laba13_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Class BDPoint<T>
        #region
        public void BDPoint_ConstructorNoParams()
        {
            // act
            BDPoint<int> point = new BDPoint<int>();
            // assert
            Assert.IsTrue(point.data == 0 && point.next == null && point.previous == null);
        }

        [TestMethod]
        public void BDPoint_Constructor_WithParams()
        {
            // arrange
            string str = "hello";
            // act
            BDPoint<string> point = new BDPoint<string>(str);
            // assert
            Assert.AreEqual(point.data, str);
            Assert.IsTrue(point.next == null && point.previous == null);
        }

        [TestMethod]
        public void BDPoint_ToString()
        {
            // arrange
            BDPoint<int> point = new BDPoint<int>(123);
            string expected = "123";
            // act
            string actual = point.ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        // Class BDList<T>

        [TestMethod]
        public void MyCollection_Constructor_NoParams()
        {
            // act
            MyCollection<int> coll = new MyCollection<int>();
            // assert
            Assert.IsTrue(coll.Beg == null);
        }

        [TestMethod]
        public void MyCollection_Constructor_Capacity()
        {
            // arrange
            int cap = 5;
            // act
            MyCollection<int> coll = new MyCollection<int>("coll" , cap);
            // assert
            int count = 0;
            foreach (int point in coll)
                count++;
            Assert.IsTrue(count == 5);
        }

        [TestMethod]
        public void MyCollection_Constructor_Params()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            // act
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // assert
            int i = 0;
            int count = 0;
            foreach (Person p in coll)
            {
                if (p.Equals(people[i])) count++;
                i++;
            }
            Assert.IsTrue(count == 6);
        }

        [TestMethod]
        public void MyCollection_Property_Beg()
        {
            // arrange
            BDPoint<int> p = new BDPoint<int>(7);
            MyCollection<int> coll = new MyCollection<int>();
            // act
            coll.Beg = p;
            // assert
            Assert.IsTrue(coll.Beg.data == 7);
        }

        [TestMethod]
        public void MyCollection_Property_End()
        {
            // arrange
            MyCollection<Person> coll = new MyCollection<Person>();
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> collection = new MyCollection<Person>("", people);
            // act
            BDPoint<Person> collEnd = coll.End;
            BDPoint<Person> collectionEnd = collection.End;
            // assert
            Assert.IsTrue(collEnd == null);
            Assert.AreEqual(collectionEnd.data, people[2]);
        }

        [TestMethod]
        public void MyCollection_Property_Count()
        {
            // arrange
            MyCollection<Person> coll = new MyCollection<Person>();
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> collection = new MyCollection<Person>("", people);
            // act
            int collCount = coll.Count;
            int collectionCount = collection.Count;
            // assert
            Assert.IsTrue(collCount == 0);
            Assert.IsTrue(collectionCount == 3);
        }

        [TestMethod]
        public void MyCollection_AddToBegin()
        {
            MyCollection<Person> coll = new MyCollection<Person>();
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> collection = new MyCollection<Person>("", people);
            Person p = new Person("ГГГ ГГГ ГГГ", 44);
            // act
            coll.AddToBegin(p);
            collection.AddToBegin(p);
            // assert
            Assert.AreEqual(coll.Beg.data, p);
            Assert.AreEqual(collection.Beg.data, p);
        }

        [TestMethod]
        public void MyCollection_AddToEnd()
        {
            MyCollection<Person> coll = new MyCollection<Person>();
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> collection = new MyCollection<Person>("", people);
            Person p = new Person("ГГГ ГГГ ГГГ", 44);
            // act
            coll.AddToEnd(p);
            collection.AddToEnd(p);
            // assert
            Assert.AreEqual(coll.Beg.data, p);
            Assert.AreEqual(collection.End.data, p);
        }

        [TestMethod]
        public void MyCollection_Add_EmptyCollection()
        {
            // arrange
            MyCollection<Person> coll = new MyCollection<Person>();
            Person p = new Person("ГГГ ГГГ ГГГ", 44);
            // act
            coll.Add(3, p);
            // assert
            Assert.AreEqual(coll.Beg.data, p);
        }

        [TestMethod]
        public void MyCollection_Add_ToFirstPlace()
        {
            // arrange
            Person p = new Person("ААА ААА ААА", 44);
            MyCollection<Person> coll = new MyCollection<Person>("", p);
            Person person = new Person("БББ БББ БББ", 23);
            // act
            coll.Add(1, person);
            // assert
            Assert.AreEqual(coll.Beg.data, person);
        }

        [TestMethod]
        public void MyCollection_Add_PlaceIsOverThanSize()
        {
            // arrange
            Person p = new Person("ААА ААА ААА", 44);
            MyCollection<Person> coll = new MyCollection<Person>("", p);
            Person person = new Person("БББ БББ БББ", 23);
            // act
            coll.Add(12, person);
            // assert
            Assert.AreEqual(coll.End.data, person);
        }

        [TestMethod]
        public void MyCollection_Add()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            Person p = new Person("МММ МММ МММ", 18);
            // act
            coll.Add(6, p);
            // arrange
            Assert.AreEqual(coll.End.previous.data, p);
        }

        [TestMethod]
        public void MyCollection_Delete()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // act
            coll.Delete();
            // assert
            Assert.IsTrue(coll.Beg == null);
        }

        [TestMethod]
        public void MyCollection_DeleteElem_CountIs1()
        {
            // arrange
            Person person = new Person("ААА ААА ААА", 44);
            MyCollection<Person> coll = new MyCollection<Person>("", person);
            Person p1 = new Person("БББ БББ БББ", 23);
            Person p2 = new Person("ААА ААА ААА", 44);
            // act
            bool p1_deleted = coll.DeleteElement(p1);
            bool p2_deleted = coll.DeleteElement(p2);
            // assert
            Assert.IsFalse(p1_deleted);
            Assert.IsTrue(p2_deleted);
            Assert.IsTrue(coll.Beg == null);
        }

        [TestMethod]
        public void MyCollection_DeleteElem_First()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // act
            bool deleted = coll.DeleteElement(people[0]);
            // assert
            Assert.IsTrue(deleted);
            Assert.AreEqual(coll.Beg.data, people[1]);
        }

        [TestMethod]
        public void MyCollection_DeleteElem_Any()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // act
            bool deleted = coll.DeleteElement(people[4]);
            // assert
            Assert.IsTrue(deleted);
            Assert.AreEqual(coll.End.previous.data, people[3]);
        }

        [TestMethod]
        public void MyCollection_DeleteElem_NotInCollection()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // act
            bool deleted = coll.DeleteElement(new Person("ХХХ ХХХ ЪЪЪ", 12));
            // assert
            Assert.IsFalse(deleted);
            Assert.IsTrue(coll.Count == 3);
        }

        [TestMethod]
        public void MyCollection_DeleteElem_Last()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>("", people);
            // act
            bool deleted = coll.DeleteElement(people[2]);
            // assert
            Assert.IsTrue(deleted);
            Assert.AreEqual(coll.End.data, people[1]);
        }

        [TestMethod]
        public void MyCollection_Find_EmptyColl()
        {
            // arrange
            MyCollection<int> coll = new MyCollection<int>();
            // act
            BDPoint<int> point = coll.Find(0);
            // assert
            Assert.IsNull(point);
        }

        [TestMethod]
        public void MyCollection_Find()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5 };
            MyCollection<int> coll = new MyCollection<int>("", array);
            // act
            BDPoint<int> p1 = coll.Find(3);
            BDPoint<int> p2 = coll.Find(10);
            // assert
            Assert.IsTrue(p1.data == 3);
            Assert.IsNull(p2);
        }


        [TestMethod]
        public void MyColection_Indexator()
        {
            // arrange
            MyCollection<int> coll = new MyCollection<int>("Числа", 5, 6, 7, 8, 9, 10, 11, 12);
            // act
            BDPoint<int> zeroElem = coll[0];
            BDPoint<int> lastElem = coll[7];
            BDPoint<int> elem = coll[4];
            // assert
            Assert.AreEqual(zeroElem.data, 5);
            Assert.AreEqual(lastElem.data, 12);
            Assert.AreEqual(elem.data, 9);
        }
    }
}
