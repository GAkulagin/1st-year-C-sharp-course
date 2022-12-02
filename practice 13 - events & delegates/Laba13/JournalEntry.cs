using System;

namespace Laba13
{
    // Информация об отдельных изменениях в коллекции
    class JournalEntry
    {
        string name;
        string typeOfChange;
        string objData;  // измененный_объект.ToString()

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TypeOfChange
        {
            get { return typeOfChange; }
            set { typeOfChange = value; }
        }

        public string ObjData
        {
            get { return objData; }
            set { objData = value; }
        }


        public JournalEntry()
        {
            Name = "";
            TypeOfChange = "";
            ObjData = "";
        }

        public JournalEntry(string n, string t, string obj)
        {
            Name = n;
            TypeOfChange = t;
            ObjData = obj;
        }


        public override string ToString()
        {
            return String.Format("Object {0} has been changed. {1}: {2}", name, typeOfChange, ObjData);
        }
    }
}
