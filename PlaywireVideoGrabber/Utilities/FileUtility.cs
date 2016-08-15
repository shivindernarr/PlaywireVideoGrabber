#region Author Information

// Author: Shivinder Singh Narr
// Project: NagarroResourcePooling
// Created: 15/06/2016
// Modified: 01/07/2016

#endregion

using System.IO;
using System.Xml.Serialization;

namespace PlaywireVideoGrabber.Utilities
{
    public class FileUtility
    {
        private XmlSerializer _xmlSerializer;

        public T XmlDeserialize<T>(string xmlFilePath) where T : class
        {
            var fileReader = new StreamReader(@xmlFilePath);
            _xmlSerializer = new XmlSerializer(typeof (T));
            var objectValue = (T) _xmlSerializer.Deserialize(fileReader);
            fileReader.Close();

            return objectValue;
        }

        public void XmlSerialize<T>(string xmlFilePath, T value) where T : class
        {
            var fileWriter = new StreamWriter(@xmlFilePath);
            _xmlSerializer = new XmlSerializer(typeof (T));
            _xmlSerializer.Serialize(fileWriter, value);
            fileWriter.Close();
        }        
    }
}