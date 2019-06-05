using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationBytesApp
{
    class Deserialize
    {
        public  List<string> Deserializing(FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            List<string> LS = null;
            try
            {
                LS = (List<string>)BF.Deserialize(fs);
                Console.WriteLine("Successfully Deserialized");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Deserialize from binary format");
                Console.WriteLine(ex.Message);
            }
            return LS;
        }
    }
}
