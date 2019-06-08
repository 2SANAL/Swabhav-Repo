using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactApplication
{
    class SerializaedDeserialized
    {
        private ArrayList _list;
        private string _path;
        public SerializaedDeserialized()
        {
            _list = new ArrayList();
            _path = @"E:\\Contacts.txt";
        }
        public void Serialization(ArrayList contactlist)
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream fileout = new FileStream(_path, FileMode.Create, FileAccess.Write);
            using (fileout)
            {
                binaryformatter.Serialize(fileout, contactlist);
            }
        }
        public ArrayList Deserialization()
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filein = new FileStream(_path, FileMode.Open, FileAccess.Read);
            using (filein)
            {
                _list = (ArrayList)binaryformatter.Deserialize(filein);
            }
            return _list;
        }
    }
}
