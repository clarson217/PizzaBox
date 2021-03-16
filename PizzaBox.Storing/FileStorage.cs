using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public class FileStorage
    {
        
        
        

        public void WriteToXML<T>(List<T> data, string _path) where T : class
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                    serializer.Serialize(writer, data);
                }catch(Exception e){

                }
                
            }
        }

        public IEnumerable<T> ReadFromXML<T>(string _path)
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