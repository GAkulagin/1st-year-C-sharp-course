using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // class Money
        [TestMethod]
        public void MoneyNoParams() // ����������� Money ��� ����������
        {
            // arrange
            int expectedRub = 0;
            int expectedKop = 0;
            // act
            Money m = new Money();
            // assert
            Assert.AreEqual(expectedRub, m.Roubles);
            Assert.AreEqual(expectedKop, m.Kopeks);
        }
        [TestMethod]
        public void MoneyWithParams()  //  ����������� Money � �����������
        {
            //  arrange
            int expectedRub = 10;
            int expectedKop = 30;
            // act
            Money m = new Money(9, 130);
            // assert
            //Assert.AreEqual(expectedRub, m.Roubles);
            Assert.AreEqual(expectedKop, m.Kopeks);
        }
        [TestMethod]
        public void MoneyZero()  //  ����������� Money � �����������
        {
            // arrange
            Money m = new Money();
            // act
            Money expected = new Money(-3, 40);
            // assert
            expected.Equals(m);
        }
        [TestMethod]
        public void MoneySubtractKopeksLessThan99()  // ����� SubtractKopeks
        {
            // arrange
            Money m = new Money(5, 15);
            Money expected = new Money(5, 5);
            // act
            m.SubtractKopeks(10);
            // assert
            m.Equals(expected);
        }
        [TestMethod]
        public void MoneySubtractKopeksMoreThan99()  // ����� SubtractKopeks
        {
            // arrange
            Money m = new Money(6, 30);
            Money expected = new Money(5, 10);
            // act
            m.SubtractKopeks(120);
            //accept
            m.Equals(expected);
        }
        [TestMethod]
        public void AddOneKopek() // �������� ++
        {
            // arrange
            Money m = new Money(4, 10);
            Money expected = new Money(4, 11);
            //act
            m++;
            // assert
            m.Equals(expected);
        }
        [TestMethod]
        public void SubtractOneKopek()  // �������� --
        {
            // arrange
            Money m = new Money(3, 33);
            Money expected = new Money(3, 32);
            // act
            m--;
            // assert
            m.Equals(expected);
        }
        [TestMethod]
        public void MoneyMinusMoney1()  // �������� Money - Money
        {
            // arrange
            Money m1 = new Money(15, 30);
            Money m2 = new Money(0, 42);
            Money expected = new Money(14, 88);
            // act
            Money m3 = m1 - m2;
            // assert
            m3.Equals(expected);
        }
        [TestMethod]
        public void MoneyMinusMoney2()  // �������� Money - Money
        {
            // arrange
            Money m1 = new Money(15, 90);
            Money m2 = new Money(16, 0);
            Money expected = new Money();
            // act
            Money m3 = m1 - m2;
            // assert
            m3.Equals(expected);
        }
        [TestMethod]
        public void MoneyMinusMoney3()  // �������� Money - Money
        {
            // arrange
            Money m1 = new Money(9, 54);
            Money m2 = new Money(1, 63);
            Money expected = new Money(7, 89);
            // act
            Money m3 = m1 - m2;
            // assert
            m3.Equals(expected);
        }
        [TestMethod]
        public void MoneyMinusInteger()  // �������� Money - int
        {
            // arrange
            Money m = new Money(3, 30);
            int x = 120;
            Money expected = new Money(2, 10);
            // act
            Money actual = m - x;
            // assert
            actual.Equals(expected);
        }
        [TestMethod]
        public void MoneyPlusInteger()  // �������� Money + int
        {
            // arrange
            Money m = new Money();
            int x = 150;
            Money expected = new Money(1, 50);
            // act
            Money money = m + x;
            // assert
            money.Equals(expected);
        }
        [TestMethod]
        public void IntegerPlusMoney()  // �������� int + Money
        {
            // arrange
            Money m = new Money(4, 20);
            int x = 111;
            Money expected = new Money(5, 31);
            // act
            Money money = x + m;
            // assert
            money.Equals(expected);
        }
        [TestMethod]
        public void MoneyToInteger()  // ����� ���������� �����
        {
            // arrange
            Money m = new Money(6, 99);
            int expected = 6;
            // act
            int x = (int)m;
            // assert
            x.Equals(expected);
        }
        [TestMethod]
        public void MoneyToBoolFalse()  // ������� ���������� �����
        {
            // arrange
            Money m = new Money(1, 1);
            bool expected = false;
            bool b;
            // act
            if (m) b = true;
            else b = false;
            // assert
            b.Equals(expected);
        }
        [TestMethod]
        public void MoneyToBoolTrue()  // ������� ���������� �����
        {
            // arrange
            Money m = new Money();
            bool expected = true;
            bool b;
            // act
            if (m) b = true;
            else b = false;
            // assert
            b.Equals(expected);
        }

        // class MoneyArr
        [TestMethod]
        public void MoneyArrNoParams()  // ����������� MoneyArr ��� ����������
        {
            // arrange
            int expectedLength = 0;
            // act
            MoneyArr m = new MoneyArr();
            // assert
            Assert.AreEqual(expectedLength, m.Length);
        }
        [TestMethod]
        public void MoneyArrRandom()  // ����������� MoneyArr � ����������, ��������� �����. �������� ����� �������
        {
            // arrange
            int expectedLength = 8;
            // act
            MoneyArr m = new MoneyArr(8);
            // assert
            Assert.AreEqual(expectedLength, m.Length);
        }
        [TestMethod]
        public void MoneyArrUserInput()  // ����������� MoneyArr � ����������, ���������������� ����
        {
            // arrange
            int[] roubles = { 12, 13, 14, 15, 16 };
            int[] kopeks = { 99, 98, 97, 96, 95 };
            int size = 5;
            //MoneyArr expectedArr = new MoneyArr(5, roubles, kopeks);
            // act
            MoneyArr array = new MoneyArr(size, roubles, kopeks);
            // assert
            Assert.AreEqual(size, array.Length);
            for(int i = 0; i < size; i++)
            {
                Assert.AreEqual(roubles[i], array[i].Roubles);
                Assert.AreEqual(kopeks[i], array[i].Kopeks);
            }
        }
        [TestMethod]
        public void ArithAverage()  // ������� �������������� ���������
        {
            // arrange
            int[] roubles = { 10, 20, 30 };
            int[] kopeks = { 10, 20, 30 };
            MoneyArr money = new MoneyArr(3, roubles, kopeks);
            double expected = 20.20;
            // act
            double average = MoneyArr.ArithAverage(money);
            // assert
            Assert.AreEqual(expected, average);
        }

        // class Program
        [TestMethod]
        public void Subtraction()  // ����� SubstractKopeks, ����� �������� Money - int
        {
            // arrange
            Money m = new Money(4, 30);
            int kopeks = 215;
            Money expected = new Money(2, 15);
            // act
            Money actual = Program.SubstractKopeks(m, kopeks);
            // assert
            actual.Equals(expected);
        }

        [TestMethod]
        public void EqualsNullReference()  // ����� Equals ������ Money, ������ - ������� ������
        {
            // arrange
            Money m1 = null;
            Money m2 = new Money();
            bool expected = false;
            // act
            bool actual = m2.Equals(m1);
            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}
