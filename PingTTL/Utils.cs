using System;
using System.IO;

namespace PingTTL {
    internal class Utils {



        public static int GetIntFromString(string str) {
            int converted = -1;
            try {
                converted = Convert.ToInt32(str);
            } catch(FormatException e) { 
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return converted;
        }
        public static void WriteToBinaryFile<T>(string filePath,T objectToWrite,bool append = false) {
            Stream stream = null;
            try {
                stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create);
                stream.Seek(0,SeekOrigin.Begin);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream,objectToWrite);
                stream.Flush();
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            } finally {
                if(stream != null) {
                    stream.Close();
                }
            }

        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            T fileContent = default(T);
            Stream stream = null;
            try {
                stream = File.Open(filePath,FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                stream.Seek(0,SeekOrigin.Begin);
                fileContent = (T) binaryFormatter.Deserialize(stream);
                stream.Flush();
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine("ICI " + e.Message);
            } finally {
                if(stream != null) {
                    stream.Close();
                }
            }
            return fileContent;
        }
    }
}