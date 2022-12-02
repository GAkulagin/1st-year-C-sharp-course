using System;
using System.Threading;
using System.Collections.Generic;
using MyLibrary;

namespace Laba11
{
    public class TestCollections
    {
        List<Person> personList;
        List<string> stringList;
        Dictionary<Person, Student> personDictionary;
        Dictionary<string, Student> stringDictionary;

        public List<Person> PersonList
        {
            get { return personList; }
        }
        public List<string> StringList
        {
            get { return stringList; }
        }
        public Dictionary<Person, Student> PersonDictionary
        {
            get { return personDictionary; }
        }
        public Dictionary<string, Student> StringDictionary
        {
            get { return stringDictionary; }
        }
        public int Length
        {
            get { return personList.Count; }
        }

        public TestCollections(int l)
        {
            personList = new List<Person>(l);
            stringList = new List<string>(l);
            personDictionary = new Dictionary<Person, Student>(l);
            stringDictionary = new Dictionary<string, Student>(l);
        }

        static string GetFullName()
        {
            string name;
            string lastName;
            string patronym;
            Random rand = new Random();
            string[] namesList = new string[30];
            #region
            namesList[0] = "Андрей";
            namesList[1] = "Артем";
            namesList[2] = "Алексей";
            namesList[3] = "Александр";
            namesList[4] = "Борис";
            namesList[5] = "Богдан";
            namesList[6] = "Денис";
            namesList[7] = "Данил";
            namesList[8] = "Дмитрий";
            namesList[9] = "Владимир";
            namesList[10] = "Владислав";
            namesList[11] = "Григорий";
            namesList[12] = "Михаил";
            namesList[13] = "Максим";
            namesList[14] = "Илья";
            namesList[15] = "Аделина";
            namesList[16] = "Елизавета";
            namesList[17] = "Полина";
            namesList[18] = "Мария";
            namesList[19] = "Ольга";
            namesList[20] = "Елена";
            namesList[21] = "Евгения";
            namesList[22] = "Анастасия";
            namesList[23] = "Алена";
            namesList[24] = "Олеся";
            namesList[25] = "Карина";
            namesList[26] = "Юлия";
            namesList[27] = "Екатерина";
            namesList[28] = "Светлана";
            namesList[29] = "Людмила";
            #endregion
            string[] lastnamesList = new string[30];
            #region
            lastnamesList[0] = "Илькаев";
            lastnamesList[1] = "Никитин";
            lastnamesList[2] = "Кулагин";
            lastnamesList[3] = "Шиляев";
            lastnamesList[4] = "Панин";
            lastnamesList[5] = "Пепеляев";
            lastnamesList[6] = "Ворхлик";
            lastnamesList[7] = "Казаков";
            lastnamesList[8] = "Максимов";
            lastnamesList[9] = "Василевич";
            lastnamesList[10] = "Зубенко";
            lastnamesList[11] = "Пахомов";
            lastnamesList[12] = "Охота";
            lastnamesList[13] = "Василюк";
            lastnamesList[14] = "Варенцов";
            lastnamesList[15] = "Сеген";
            lastnamesList[16] = "Элькинд";
            lastnamesList[17] = "Теплоухова";
            lastnamesList[18] = "Кочурова";
            lastnamesList[19] = "Иванова";
            lastnamesList[20] = "Шадрина";
            lastnamesList[21] = "Суханова";
            lastnamesList[22] = "Лаптева";
            lastnamesList[23] = "Пентина";
            lastnamesList[24] = "Пясецкая";
            lastnamesList[25] = "Запарова";
            lastnamesList[26] = "Сапаева";
            lastnamesList[27] = "Быстрых";
            lastnamesList[28] = "Фефилова";
            lastnamesList[29] = "Трофимова";
            #endregion
            string[] patronymicList = new string[30];
            #region
            patronymicList[0] = "Михайлович";
            patronymicList[1] = "Петрович";
            patronymicList[2] = "Сергеевич";
            patronymicList[3] = "Георгиевич";
            patronymicList[4] = "Дмитриевич";
            patronymicList[5] = "Александрович";
            patronymicList[6] = "Алексеевич";
            patronymicList[7] = "Владимирович";
            patronymicList[8] = "Всеволодович";
            patronymicList[9] = "Владиславович";
            patronymicList[10] = "Кириллович";
            patronymicList[11] = "Денисович";
            patronymicList[12] = "Олегович";
            patronymicList[13] = "Игоревич";
            patronymicList[14] = "Юрьевич";
            patronymicList[15] = "Михайловна";
            patronymicList[16] = "Петровна";
            patronymicList[17] = "Сергеевна";
            patronymicList[18] = "Георгиевна";
            patronymicList[19] = "Дмитриевна";
            patronymicList[20] = "Егоровна";
            patronymicList[21] = "Александровна";
            patronymicList[22] = "Алексеевна";
            patronymicList[23] = "Владимировна";
            patronymicList[24] = "Всеволодовна";
            patronymicList[25] = "Владиславовна";
            patronymicList[26] = "Кирилловна";
            patronymicList[27] = "Игоревна";
            patronymicList[28] = "Юрьевна";
            patronymicList[29] = "Олеговна";
            #endregion

            int value = rand.Next(0, 30);
            name = namesList[value];
            if(value > 14)
            {
                lastName = lastnamesList[rand.Next(15, 30)];
                Thread.Sleep(200);
                patronym = patronymicList[rand.Next(15, 30)];
            }
            else
            {
                lastName = lastnamesList[rand.Next(0, 15)];
                Thread.Sleep(200);
                patronym = patronymicList[rand.Next(0, 15)];
            }

            return lastName + " " + name + " " + patronym;
        }

        public TestCollections RandomInit(int length)
        {
            TestCollections collection = new TestCollections(length);

            Random rand = new Random();

            for(int i = 0; i < length; i++)
            {
                int kurs = rand.Next(1, 5);
                int rating = rand.Next(1, 61);
                int age = 18 + kurs;
                string fullName = GetFullName();
                Student s = new Student(fullName, age, kurs, rating);
                Person p = s.BasePerson;

                if (collection.stringDictionary.ContainsKey(fullName))
                {
                    i--;
                    continue;
                }
                collection.stringDictionary.Add(fullName, s);
                collection.personDictionary.Add(p, s);
                collection.personList.Add(p);
                collection.stringList.Add(fullName);
            }

            return collection;
        }

        public void Show()
        {
            foreach (KeyValuePair<Person, Student> pair in personDictionary)
            {
                pair.Value.Show();
                Console.WriteLine();
            }
        }
    }
}
