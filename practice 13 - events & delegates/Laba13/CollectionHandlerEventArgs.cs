using System;

namespace Laba13
{
    public class CollectionHandlerEventArgs : EventArgs
    {
        string name;       // Имя измененной коллекции
        string typeOfChange;       // Тип изменения
        object reference;  // Ссылка на измененный объект

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

        public object Reference
        {
            get { return reference; }
            set { reference = value; }
        }


        public CollectionHandlerEventArgs(object r, string n, string t)
        {
            Name = n;
            TypeOfChange = t;
            Reference = r;
        }


        public override string ToString()
        {
            return String.Format("Object {0} has been changed. {1}: {2}", name, typeOfChange, reference);
        }
    }
}
