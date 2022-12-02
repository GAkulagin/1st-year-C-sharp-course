using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba12;
using MyLibrary;

namespace Laba12_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // class UDPoint
        #region
        [TestMethod]
        public void UDPoint_ConstructorBezParametrov()
        {
            // arrange
            // act
            UDPoint point = new UDPoint();
            // assert
            Assert.IsTrue(point.data == null && point.next == null);
        }

        [TestMethod]
        public void UDPoint_ConstructorSParametrami()
        {
            // arrange
            Person person = new Person("ААА ААА ААА", 10);
            // act
            UDPoint point = new UDPoint(person);
            // assert
            Assert.AreEqual(point.data, person);
            Assert.IsTrue(point.next == null);
        }

        [TestMethod]
        public void UDPoint_ToString()
        {
            // arrange
            Person person = new Person("ААА ААА ААА", 10);
            UDPoint point = new UDPoint(person);
            string expected = person.ToString() + "\n";
            // act
            string actual = point.ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        // class UDlist
        #region
        [TestMethod]
        public void UDList_Constructor_NoParams()
        {
            // act
            UDList list = new UDList();
            // arrange
            Assert.IsTrue(list.Beg == null);
        }

        [TestMethod]
        public void UDList_Property_Beg()
        {
            // arrange
            UDList list = new UDList();
            Person person = new Person("ААА ААА ААА", 11);
            // act
            list.Beg = new UDPoint(person);
            // assert
            Assert.AreEqual(list.Beg.data, person);
        }

        [TestMethod]
        public void UDList_Constructor_WithParams()
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
            UDList list = new UDList(people);
            // assert
            UDPoint temp = list.Beg;
            for(int i = 0; i < 6; i++)
            {
                Assert.AreEqual(temp.data, people[i]);
                temp = temp.next;
            }
        }

        [TestMethod]
        public void UDList_Property_Length()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            UDList emptyList = new UDList();
            UDList list = new UDList(people);
            // act
            int emptyListLength = emptyList.Length;
            int listLength = list.Length;
            // assert
            Assert.AreEqual(emptyListLength, 0);
            Assert.AreEqual(listLength, 3);
        }

        [TestMethod]
        public void UDList_AddAfter_EmptyList()
        {
            // arrange
            UDList list = new UDList();
            Person person = new Person("ААА ААА ААА", 10);
            // act
            bool added = list.AddAfter(person, person.Name);
            // assert
            Assert.IsTrue(added);
            Assert.AreEqual(list.Beg.data, person);
        }

        [TestMethod]
        public void UDList_AddAfter_Length1()
        {
            // arrange
            Person p = new Person("ААА ААА ААА", 10);
            Person person = new Person("БББ БББ БББ", 11);
            UDList list = new UDList(p);
            // act
            bool a = list.AddAfter(person, "123");
            bool b = list.AddAfter(person, p.Name);
            // assert
            Assert.IsTrue(!a && b);
            Assert.AreEqual(list.Beg.next.data, person);
        }

        [TestMethod]
        public void UDList_AddAfter_AfterFirst()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            UDList list = new UDList(people);
            Person person = new Person("ГГГ ГГГ ГГГ", 33);
            // act
            bool added = list.AddAfter(person, people[0].Name);
            // assert
            Assert.IsTrue(list.Length == 4 && added);
            Assert.AreEqual(list.Beg.next.data, person);
        }

        [TestMethod]
        public void UDList_AddAfter()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            UDList list = new UDList(people);
            Person person = new Person("ГГГ ГГГ ГГГ", 33);
            // act
            bool added = list.AddAfter(person, people[1].Name);
            // assert
            Assert.IsTrue(added && list.Length == 4);
            Assert.AreEqual(list.Beg.next.next.data, person);
        }

        [TestMethod]
        public void UDList_AddAfter_NoKey()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            UDList list = new UDList(people);
            Person person = new Person("ГГГ ГГГ ГГГ", 33);
            // act
            bool added = list.AddAfter(person, "ДДД ДДД ДДД");
            // assert
            Assert.IsTrue(!added && list.Length == 3);
        }

        [TestMethod]
        public void UDList_Delete()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            UDList list = new UDList(people);
            // act
            list.Delete();
            // assert
            Assert.IsTrue(list.Length == 0 && list.Beg == null);
        }
        #endregion

        // class BDPoint
        #region
        [TestMethod]
        public void BDPoint_Constructor_NoParams()
        {
            // act
            BDPoint point = new BDPoint();
            // assert
            Assert.IsTrue(point.data == null && point.next == null && point.previous == null);
        }

        [TestMethod]
        public void BDPoint_Constructor_WithParams()
        {
            // arrange
            Person person = new Person("ААА ААА ААА", 10);
            // act
            BDPoint point = new BDPoint(person);
            // assert
            Assert.IsTrue(point.next == null && point.previous == null);
            Assert.AreEqual(point.data, person);
        }
        #endregion

        // class BDList
        #region
        [TestMethod]
        public void BDList_Constructor_NoParams()
        {
            // act
            BDList list = new BDList();
            // assert
            Assert.IsTrue(list.Beg == null);
        }

        [TestMethod]
        public void BDList_Constructor_WithParams()
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
            BDList list = new BDList(people);
            // assert
            BDPoint temp = list.Beg;
            for(int i = 0; i < 6; i++)
            {
                Assert.AreEqual(temp.data, people[i]);
                temp = temp.next;
            }
        }

        [TestMethod]
        public void BDList_Property_Beg()
        {
            // arrange
            BDList list = new BDList();
            Person person = new Person("ААА ААА ААА", 11);
            // act
            list.Beg = new BDPoint(person);
            // assert
            Assert.AreEqual(list.Beg.data, person);
        }

        [TestMethod]
        public void BDList_Property_Length()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            BDList emptyList = new BDList();
            BDList list = new BDList(people);
            // act
            int emptyListLength = emptyList.Length;
            int listLength = list.Length;
            // assert
            Assert.AreEqual(emptyListLength, 0);
            Assert.AreEqual(listLength, 3);
        }

        [TestMethod]
        public void BDList_Delete()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            BDList list = new BDList(people);
            // act
            list.Delete();
            // assert
            Assert.IsTrue(list.Length == 0 && list.Beg == null);
        }

        [TestMethod]
        public void BDList_DeleteByKurs_Length1()
        {
            // arrange
            Student student = new Student("ААА ААА ААА", 21, 1, 12);
            BDList list = new BDList(student);
            // act
            list.DeleteByKurs(1);
            // assert
            Assert.IsTrue(list.Beg == null);
        }

        [TestMethod]
        public void BDList_DeleteByKurs()
        {
            Person[] people = new Person[4];
            people[0] = new Student("ААА ААА ААА", 21, 1, 1);
            people[1] = new Student("ААА ААА ААА", 21, 2, 1);
            people[2] = new Student("ААА ААА ААА", 21, 3, 1);
            people[3] = new Student("ААА ААА ААА", 21, 4, 1);
            BDList list = new BDList(people);
            // act
            list.DeleteByKurs(3);
            // assert
            Assert.IsTrue(list.Length == 3);
            BDPoint point = list.Beg.next;
            Assert.AreEqual(point.previous.data, people[0]);
            Assert.AreEqual(point.data, people[1]);
            Assert.AreEqual(point.next.data, people[3]);
        }

        [TestMethod]
        public void BDList_DeleteByKurs_LastElem()
        {
            Person[] people = new Person[4];
            people[0] = new Student("ААА ААА ААА", 21, 1, 1);
            people[1] = new Student("ААА ААА ААА", 21, 2, 1);
            people[2] = new Student("ААА ААА ААА", 21, 3, 1);
            people[3] = new Student("ААА ААА ААА", 21, 4, 1);
            BDList list = new BDList(people);
            // act
            list.DeleteByKurs(4);
            // assert
            Assert.IsTrue(list.Length == 3 && list.Beg.next.next.next == null);
        }
        #endregion

        // class TreePoint
        #region
        [TestMethod]
        public void TreePoint_Constructor_NoParams()
        {
            // act
            TreePoint point = new TreePoint();
            // assert
            Assert.IsTrue(point.data == null && point.left == null && point.right == null);
        }

        [TestMethod]
        public void TreePoint_Constructor_WithParams()
        {
            // arrange
            Person person = new Person("ААА ААА ААА", 11);
            // act
            TreePoint point = new TreePoint(person);
            // arrange
            Assert.AreEqual(point.data, person);
        }
        #endregion

        // class BinaryTree
        #region
        [TestMethod]
        public void BinaryTree_Constructor_NoParams()
        {
            // act
            BinaryTree tree = new BinaryTree();
            // assert
            Assert.IsTrue(tree.Root == null);
        }

        [TestMethod]
        public void BinaryTree_Constructor_WithParams()
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
            BinaryTree tree = new BinaryTree(people);
            // assert
            int count = 0;
            CheckTree(tree.Root, people, ref count);
            Assert.IsTrue(count == 6);
        }

        void CheckTree(TreePoint point, Person[] array, ref int count)
        {
            if (point != null)
            {
                for(int i = 0; i < array.Length; i++)
                    if (array[i].Equals(point.data))
                    {
                        count++;
                        break;
                    }
                CheckTree(point.left, array, ref count);
                CheckTree(point.right, array, ref count);
            }
        }

        [TestMethod]
        public void BinaryTree_Property_Root()
        {
            // arrange
            Person p = new Person("ААА ААА ААА", 10);
            TreePoint point = new TreePoint(p);
            BinaryTree tree = new BinaryTree();
            // act
            tree.Root = point;
            // assert
            Assert.AreEqual(tree.Root.data, p);
        }

        [TestMethod]
        public void BinaryTree_Property_Count()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            BinaryTree tree = new BinaryTree(people);
            BinaryTree t = new BinaryTree();
            // act
            int treeCount = tree.Count;
            int tCount = t.Count;
            // assert
            Assert.IsTrue(tCount == 0 && treeCount == 3);
        }

        [TestMethod]
        public void BinaryTree_IdealTree()
        {
            // arrange
            BinaryTree tree = new BinaryTree();
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            int pos = 0;
            foreach (Person p in people)
                tree.list.Add(p);
            // act
            tree.Root = tree.IdealTree(6, tree.Root, ref pos);
            // assert
            int count = 0;
            CheckTree(tree.Root, people, ref count);
            Assert.IsTrue(count == 6);
        }

        [TestMethod]
        public void BinaryTree_SearchTree()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            BinaryTree tree = new BinaryTree(people);
            // act
            BinaryTree searchTree = tree.SearchTree();
            // assert
            int count = 0;
            CheckTree(searchTree.Root, people, ref count);
            Assert.IsTrue(count == 6);
        }

        [TestMethod]
        public void BinaryTree_Add()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            BinaryTree tree = new BinaryTree(people);
            BinaryTree searchTree = tree.SearchTree();

            Person[] mas = new Person[7];
            Array.Copy(people, 0, mas, 0, people.Length);
            Person p = new Person("ЖЖЖ ЖЖЖ ЖЖЖ", 16);
            mas[6] = p;
            // act
            searchTree.Add(searchTree.Root, p);
            // assert
            int count = 0;
            CheckTree(searchTree.Root, mas, ref count);
            Assert.IsTrue(count == 7);
        }

        [TestMethod]
        public void BinaryTree_Delete()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            people[3] = new Person("ГГГ ГГГ ГГГ", 13);
            people[4] = new Person("ДДД ДДД ДДД", 14);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 15);
            BinaryTree tree = new BinaryTree(people);
            // act
            tree.Delete(tree.Root);
            // assert
            Assert.IsTrue(tree.Root == null);
        }

        [TestMethod]
        public void BinaryTree_GetAgeSum()
        {
            // arrange
            Person[] people = new Person[6];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 10);
            people[2] = new Person("ВВВ ВВВ ВВВ", 10);
            people[3] = new Person("ГГГ ГГГ ГГГ", 10);
            people[4] = new Person("ДДД ДДД ДДД", 10);
            people[5] = new Person("ЕЕЕ ЕЕЕ ЕЕЕ", 10);
            BinaryTree tree = new BinaryTree(people);

            double expected = 60;
            // act
            double actual = 0;
            tree.GetAgeSum(tree.Root, ref actual);
            // assert
            Assert.IsTrue(expected == actual);
        }
        #endregion

        // class MyColPoint<T>
        #region
        [TestMethod]
        public void MyColPoint_Constructor_NoParams()
        {
            // act
            MyColPoint<int> point = new MyColPoint<int>();
            // assert
            Assert.IsTrue(point.data == 0 && point.next == null && point.previous == null);
        }

        [TestMethod]
        public void MyColPoint_Constructor_WithParams()
        {
            // arrange
            string str = "hello";
            // act
            MyColPoint<string> point = new MyColPoint<string>(str);
            // assert
            Assert.AreEqual(point.data, str);
            Assert.IsTrue(point.next == null && point.previous == null);
        }
        #endregion

        // class MyCollection<T>
        #region
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
            MyCollection<int> coll = new MyCollection<int>(cap);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyColPoint<int> p = new MyColPoint<int>(7);
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
            MyCollection<Person> collection = new MyCollection<Person>(people);
            // act
            MyColPoint<Person> collEnd = coll.End;
            MyColPoint<Person> collectionEnd = collection.End;
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
            MyCollection<Person> collection = new MyCollection<Person>(people);
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
            MyCollection<Person> collection = new MyCollection<Person>(people);
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
            MyCollection<Person> collection = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(p);
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
            MyCollection<Person> coll = new MyCollection<Person>(p);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(person);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
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
            MyCollection<Person> coll = new MyCollection<Person>(people);
            // act
            bool deleted = coll.DeleteElement(people[2]);
            // assert
            Assert.IsTrue(deleted);
            Assert.AreEqual(coll.End.data, people[1]);
        }

        [TestMethod]
        public void MyCollection_Clone()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>(people);
            // act
            MyCollection<Person> list = coll.Clone();
            // assert
            MyColPoint<Person> c = coll.Beg;
            MyColPoint<Person> l = list.Beg;
            for(int i = 0; i < 3; i++)
            {
                Assert.AreEqual(c.data, l.data);
                c = c.next;
                l = l.next;
            }
        }

        [TestMethod]
        public void MyCollection_Copy()
        {
            // arrange
            Person[] people = new Person[3];
            people[0] = new Person("ААА ААА ААА", 10);
            people[1] = new Person("БББ БББ БББ", 11);
            people[2] = new Person("ВВВ ВВВ ВВВ", 12);
            MyCollection<Person> coll = new MyCollection<Person>(people);
            // act
            MyCollection<Person> list = coll.Clone();
            // assert
            MyColPoint<Person> c = coll.Beg;
            MyColPoint<Person> l = list.Beg;
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(c.data, l.data);
                c = c.next;
                l = l.next;
            }
        }

        [TestMethod]
        public void MyCollection_CloneAndCopy_EmptyColl()
        {
            // arrange
            MyCollection<Person> coll = new MyCollection<Person>();
            // act
            MyCollection<Person> clone = coll.Clone();
            MyCollection<Person> copy = coll.Copy();
            // assert
            Assert.IsTrue(clone == null & copy == null);
        }

        [TestMethod]
        public void MyCollection_Find_EmptyColl()
        {
            // arrange
            MyCollection<int> coll = new MyCollection<int>();
            // act
            MyColPoint<int> point = coll.Find(0);
            // assert
            Assert.IsNull(point);
        }

        [TestMethod]
        public void MyCollection_Find()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5 };
            MyCollection<int> coll = new MyCollection<int>(array);
            // act
            MyColPoint<int> p1 = coll.Find(3);
            MyColPoint<int> p2 = coll.Find(10);
            // assert
            Assert.IsTrue(p1.data == 3);
            Assert.IsNull(p2);
        }
        #endregion
    }
}
