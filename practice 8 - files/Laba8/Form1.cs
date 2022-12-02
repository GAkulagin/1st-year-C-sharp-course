using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void GroupListOutput(Student[] groupList)
        {
            OutputTextBox.Clear();

            if (groupList.Length == 0)
                OutputTextBox.Text = "Список студентов группы пуст";
            else
                for (int i = 0; i < groupList.Length; i++)
                    OutputTextBox.Text += i + 1 + "   " + groupList[i].name + "\r\n"; 
        }
        void MainListOutput(Student[] mainList)
        {
            OutputTextBox.Clear();

            if (mainList.Length == 0)
                OutputTextBox.Text = "Список студентов первого курса пуст";
            else
                for (int i = 0; i < mainList.Length; i++)
                    if (mainList[i] != null)
                        OutputTextBox.Text += i + 1 + ".  группа  " + mainList[i].group + "   " + mainList[i].name + "\r\n";
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm newForm = new AddStudentForm();
            newForm.Show();
        }
        private void ShowGroupListBtn_Click(object sender, EventArgs e)
        {
            int group = (int)GroupNumberNUD.Value;

            string fileName = Student.GetFileName(group);
            Student[] list = Student.Unpacking(fileName);

            GroupListOutput(list);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchAndChangeForm newForm = new SearchAndChangeForm();
            newForm.Show();
        }
        private void ShowMainListBtn_Click(object sender, EventArgs e)
        {
            Student[] mainList = Student.MakeMainList();
            Student.SortArray(mainList);
            MainListOutput(mainList);
        }
    }
    [Serializable]
    class Student
    {
        public string name;
        static Student[] firstGroupList = Unpacking("group_1.bin");
        static Student[] secondGroupList = Unpacking("group_2.bin");
        static Student[] thirdGroupList = Unpacking("group_3.bin");
        static Student[] mainList = MakeMainList();
        public int group;

        public Student(string N, int G)
        {
            name = N;
            group = G;
        }

        public static void AddToEnd(Student newStudent)
        {

            switch (newStudent.group)
            {
                case 1:
                    {
                        Student[] mas = new Student[firstGroupList.Length + 1];
                        Array.Copy(firstGroupList, 0, mas, 0, firstGroupList.Length);
                        mas[mas.Length - 1] = newStudent;
                        firstGroupList = mas;
                        break;
                    }
                case 2:
                    {
                        Student[] mas = new Student[secondGroupList.Length + 1];
                        Array.Copy(secondGroupList, 0, mas, 0, secondGroupList.Length);
                        mas[mas.Length - 1] = newStudent;
                        secondGroupList = mas;
                        break;
                    }
                case 3:
                    {
                        Student[] mas = new Student[thirdGroupList.Length + 1];
                        Array.Copy(thirdGroupList, 0, mas, 0, thirdGroupList.Length);
                        mas[mas.Length - 1] = newStudent;
                        thirdGroupList = mas;
                        break;
                    }
            }

            mainList = MakeMainList();
        }
        public static void AddToBeginning(Student newStudent)
        {
            switch (newStudent.group)
            {
                case 1:
                    {
                        Student[] mas = new Student[firstGroupList.Length + 1];
                        mas[0] = newStudent;
                        Array.Copy(firstGroupList, 0, mas, 1, firstGroupList.Length);
                        firstGroupList = mas;
                        break;
                    }
                case 2:
                    {
                        Student[] mas = new Student[secondGroupList.Length + 1];
                        mas[0] = newStudent;
                        Array.Copy(secondGroupList, 0, mas, 1, secondGroupList.Length);
                        secondGroupList = mas;
                        break;
                    }
                case 3:
                    {
                        Student[] mas = new Student[thirdGroupList.Length + 1];
                        mas[0] = newStudent;
                        Array.Copy(thirdGroupList, 0, mas, 1, thirdGroupList.Length);
                        thirdGroupList = mas;
                        break;
                    }
            }

            mainList = MakeMainList();
        }
        public static void AddToPosition(Student newStudent, int position)
        {
            switch (newStudent.group)
            {
                case 1:
                    {
                        int firstPart = position;
                        int secondPart = firstGroupList.Length - position;

                        if (position > firstGroupList.Length + 1)
                            AddToEnd(newStudent);
                        else
                        {
                            Student[] mas = new Student[firstGroupList.Length + 1];
                            Array.Copy(firstGroupList, 0, mas, 0, firstPart);
                            mas[position] = newStudent;
                            Array.Copy(firstGroupList, position, mas, position + 1, secondPart);
                            firstGroupList = mas;
                        }
                        break;
                    }
                case 2:
                    {

                        int firstPart = position;
                        int secondPart = secondGroupList.Length - position + 1;

                        if (position > secondGroupList.Length + 1)
                            AddToEnd(newStudent);
                        else
                        {
                            Student[] mas = new Student[secondGroupList.Length + 1];
                            Array.Copy(secondGroupList, 0, mas, 0, firstPart);
                            mas[position] = newStudent;
                            Array.Copy(secondGroupList, position, mas, position + 1, secondPart);
                            secondGroupList = mas;
                        }
                        break;
                    }
                case 3:
                    {
                        int firstPart = position;
                        int secondPart = thirdGroupList.Length - position + 1;

                        if (position > thirdGroupList.Length + 1)
                            AddToEnd(newStudent);
                        else
                        {
                            Student[] mas = new Student[thirdGroupList.Length + 1];
                            Array.Copy(thirdGroupList, 0, mas, 0, firstPart);
                            mas[position] = newStudent;
                            Array.Copy(thirdGroupList, position, mas, position + 1, secondPart);
                            thirdGroupList = mas;
                        }
                        break;
                    }
            }

            mainList = MakeMainList();
        }
        public static void Packing()
        {
            FileStream firstStream = new FileStream("group_1.bin", FileMode.Create);
            BinaryFormatter firstFormatter = new BinaryFormatter();
            firstFormatter.Serialize(firstStream, firstGroupList);
            firstStream.Close();

            FileStream secondStream = new FileStream("group_2.bin", FileMode.Create);
            BinaryFormatter secondFormatter = new BinaryFormatter();
            secondFormatter.Serialize(secondStream, secondGroupList);
            secondStream.Close();

            FileStream thirdStream = new FileStream("group_3.bin", FileMode.Create);
            BinaryFormatter thirdFormatter = new BinaryFormatter();
            thirdFormatter.Serialize(thirdStream, thirdGroupList);
            thirdStream.Close();
        }
        public static Student[] Unpacking(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student[] list = (Student[])formatter.Deserialize(stream);
            stream.Close();

            return list;
        }
        public static string GetFileName(int group)
        {
            string fileName = "";
            switch (group)
            {
                case 1:
                    {
                        fileName = "group_1.bin";
                        break;
                    }
                case 2:
                    {
                        fileName = "group_2.bin";
                        break;
                    }
                case 3:
                    {
                        fileName = "group_3.bin";
                        break;
                    }
            }

            return fileName;
        }
        public static Student[] MakeMainList()
        {
            Student[] mainList = new Student[firstGroupList.Length + secondGroupList.Length + thirdGroupList.Length];
            int point = 0;

            Array.Copy(firstGroupList, mainList, firstGroupList.Length);
            point += firstGroupList.Length;
            Array.Copy(secondGroupList, 0, mainList, point, secondGroupList.Length);
            point += secondGroupList.Length;
            Array.Copy(thirdGroupList, 0, mainList, point, thirdGroupList.Length);

            return mainList;
        }
        public static object KeySearch(string key)
        {
            object person = null;

            for (int i = 0; i < mainList.Length; i++)
            {
                if (mainList[i].name.Contains(key))
                {
                    person = mainList[i];
                    break;
                }
            }

            return person;
        }
        public static object NumberSearch(int number)
        {
            object person = null;

            Student.SortArray(mainList);

            for (int i = 0; i < mainList.Length; i++)
                if (i == number)
                {
                    person = mainList[i];
                    break;
                }

            return person;
        }
        public static void DeleteStudent(Student student)
        {
            Student[] mas;

             switch (student.group)
             {

                 case 1:
                     {
                         mas = new Student[firstGroupList.Length - 1];
                         int count = 0;

                         for(int i = 0; i < firstGroupList.Length; i++)
                         {
                            if (student.name != firstGroupList[i].name)
                            {
                                mas[count] = firstGroupList[i];
                                count++;
                            }
                         }
                         firstGroupList = mas;
                         break;
                     }
                 case 2:
                     {
                         mas = new Student[secondGroupList.Length - 1];
                         int count = 0;

                         for (int i = 0; i < secondGroupList.Length; i++)
                         {
                            if (student.name != secondGroupList[i].name)
                            {
                                mas[count] = secondGroupList[i];
                                count++;
                            }
                         }
                         secondGroupList = mas;
                         break;
                     }
                 case 3:
                     {
                         mas = new Student[thirdGroupList.Length - 1];
                         int count = 0;

                         for (int i = 0; i < thirdGroupList.Length; i++)
                         {
                            if (student.name != thirdGroupList[i].name)
                            {
                                mas[count] = thirdGroupList[i];
                                count++;
                            }
                         }
                         thirdGroupList = mas;
                         break;
                     }
             }
        } 
        public static void SortArray(Student[] mainList)
        {
            string[] names = new string[mainList.Length];

            for (int i = 0; i < names.Length; i++)
                names[i] = mainList[i].name;

            Array.Sort(names, mainList);  //  сортировка по ключам(names)
        }
        public static void CorrectInfo(Student student)
        {
            switch (student.group)
            {
                case 1:
                    {
                        foreach(Student x in firstGroupList)
                            if(x.name == student.name)
                                x.name = student.name;
                        break;
                    }
                case 2:
                    {
                        foreach (Student x in secondGroupList)
                            if (x.name == student.name)
                                x.name = student.name;
                        break;
                    }
                case 3:
                    {
                        foreach (Student x in thirdGroupList)
                            if (x.name == student.name)
                                x.name = student.name;
                        break;
                    }
            }
        }
    }
}