using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;

namespace InputWindow.Utilities
{
    // Requires reference to System.Runtime.Serialization.Formatters.Soap;
    class Serializer
    {
        public static void SerilizeBinary<T>(string saveFolder, string fileName, T t)
        {
            using (FileStream fs = File.Create(@"..\..\" + saveFolder + @"\" + fileName + ".bin"))
            {
                BinaryFormatter serializer = new BinaryFormatter(); // Create a Binary Serializer

                serializer.Serialize(fs, t);    // Serialize our desired object, t, at our desired Location, fs. 
                fs.Close();                     // Be sure to close the file after we are done
            }
        }

        public static T DeserializeBinary<T>(string saveFolder, string fileName)
        {
            T t;    // Our Temp container for 
            using (FileStream fs = File.OpenRead(@"..\..\" + saveFolder + @"\" + fileName + ".bin"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                t = (T)deserializer.Deserialize(fs); // 
                fs.Close();     // Be sure to close the file after we are done
            }

            return t;
        }

        public static void SerializeSoap<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".xml")) //Creates a FileStream using information from the file we created
            {
                SoapFormatter serializer = new SoapFormatter(); //Creates a new BinaryFormatter to give us access to the Serialize function
                //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                //file it is not human readable with the exception of the variables we declared.
                //To have the file in a human readable form we would use the SoapFormatter method
                serializer.Serialize(fs, t);
                fs.Close(); //Allways close your files when you are done using them
            }
        }

        public static T DeserializeSoap<T>(string s)
        {
            T t; //We will use the as the return value
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + s + ".xml")) //Same process as Serialize but instead of create we use OpenRead
            {
                SoapFormatter deserializer = new SoapFormatter(); //Creates a new binaryFormatter that will give us access to the Deseralize function
                                                                  //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                                                                  //we opened and are reading from.
                                                                  //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                                                                  //value of the Deseaialize method
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //Allways close your files when you are done using them
            }
            return t; //We then return t
        }

        public static void SerializeXML<T>(string fileName, T t) 
        {
            string path = System.Environment.CurrentDirectory + "\\SavedFiles\\";

            if (!System.Environment.CurrentDirectory.Contains("\\SavedFiles\\"))
            {
                Directory.CreateDirectory(path);
            }


            using (FileStream fs = File.Create(path + fileName + ".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(fs, t);
                fs.Close();
            }
        }

        public static T DeserializeXML<T>(string fileName)
        {
            T t;
            string path = System.Environment.CurrentDirectory + "\\SavedFiles\\" + fileName;
            
            using (FileStream fs = File.OpenRead(path))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);
            }

            return t;
        }
    }
}
