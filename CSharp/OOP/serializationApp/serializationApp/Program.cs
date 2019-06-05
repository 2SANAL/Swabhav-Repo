using System;
using System.Xml.Serialization;
using System.IO;


namespace ConsoleTester
{
    [Serializable]
    public class SerializerTest
    {
        public SerializerTest(string data)
        {
            this.data = data;
        }
        public SerializerTest() { }

        public string data;

    }

    class ConsoleMain
    {
        [STAThread]
        static void Main(string[] args)
        {
            ConsoleMain console = new ConsoleMain();
            console.DeserializeObject("E:\\Test.xml");
            SerializerTest testInstance = new SerializerTest("Hello World!");

            XmlSerializer ser = new XmlSerializer(typeof(SerializerTest));

            TextWriter writer = new StreamWriter("E:\\Test.xml");
            ser.Serialize(writer, testInstance);
            writer.Close();


        }
        private void DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with Stream");

            XmlSerializer serializer = new XmlSerializer(typeof(SerializerTest));
            
            SerializerTest i;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                
                i = (SerializerTest)serializer.Deserialize(reader);
            }
            Console.WriteLine(i.data);
        }
        

    }

}

