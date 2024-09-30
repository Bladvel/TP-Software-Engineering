using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Services
{
    public static class SerializationManager
    {

        public static void SerializarXml<T>(T obj, string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StreamWriter file = new StreamWriter(path))
            {
                ser.Serialize(file, obj);
            }

        }

        public static T DeserializarXml<T>(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(path))
            {
                return (T)ser.Deserialize(reader);
            }



        }


    }
}
