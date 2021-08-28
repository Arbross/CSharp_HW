using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace OwnSerializationLibrary
{
    public class Serialization
    {
        public static void BinarySerialization(ref object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("serialization.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static void BinaryDeserialization(ref object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("serialization.dat", FileMode.OpenOrCreate))
            {
                obj = formatter.Deserialize(fs);
            }
        }

        public static void JsonSerialization(ref object obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            File.WriteAllText("serialization.txt", output);
        }

        public static void JsonDeserialization(ref object obj)
        {
            obj = JsonConvert.DeserializeObject(File.ReadAllText("serialization.txt"));
        }

        
        public static T XmlSerialization<T>(object obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream("serialization.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                return default(T);
            }
        }

        public static void XmlDeserialization(ref object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("serialization.xml", FileMode.OpenOrCreate))
            {
                obj = formatter.Deserialize(fs);
            }
        }
    }
}