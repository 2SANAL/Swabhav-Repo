using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationBytesApp
{
    [Serializable]
    class Serialize
    {
         public void Serializing(List<string> student, FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            try
            {
                BF.Serialize(fs, student);
                Console.WriteLine("Successfully Serialized");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Serialize from binary format");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
