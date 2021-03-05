using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public class FileStorage
    {
        private readonly string _path = @"store.xml";

        public void WriteToXML<T>(List<T> data) where T : class
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                serializer.Serialize(writer, data);
            }
        }

        public IEnumerable<T> ReadFromXML<T>() where T : class
        {
            using (StreamReader reader = new StreamReader(_path))
            {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            return serializer.Deserialize(reader) as IEnumerable<T>;
            }
        }
        public void ReadFromXML()
        {

        }
    }
}