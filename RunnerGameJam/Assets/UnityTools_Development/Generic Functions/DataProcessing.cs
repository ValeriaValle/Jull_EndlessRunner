using Exception = System.Exception;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace UnityTools.GenericFunctions
{
    public static class DataProcessing
    {
        public static void LoadData<T>(string fileName, ref T data) where T : class
        {

            string fullPath = Application.persistentDataPath + fileName;
            //Debug.Log(fullPath);
            if (File.Exists(fullPath))
            {
                //Debug.Log("Se cargo datos");
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = null;
                try
                {
                    file = File.Open(fullPath, FileMode.Open);
                    data = (T)bf.Deserialize(file);
                    file.Close();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                    file.Close();
                    File.Delete(fullPath);
                }
            }
            else
            {
                //Debug.Log("Se crearon datos");
                SaveToDisk(fileName, data);
            }
        }

        public static void SaveToDisk<T>(string fileName, T data) where T : class
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(Application.persistentDataPath + fileName);
                bf.Serialize(file, data);
                file.Close();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        public static void DeleteFile(string fileName)
        {
            string fullPath = Application.persistentDataPath + fileName;
            File.Delete(fullPath);
        }
    }
}
