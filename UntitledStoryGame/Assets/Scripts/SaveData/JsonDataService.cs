using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace RobbieWagnerGames.Common
{
    public class JsonDataService : IDataService
    {
        public static JsonDataService Instance {get; private set;}
        public JsonDataService()
        {
            if (Instance != null && Instance != this) 
            { 
                return;
            } 
            else 
            { 
                Instance = this; 
            } 
        }

        public void ResetInstance() => Instance = null;

        public bool SaveData<T>(string RelativePath, T Data, bool Encrypt = false)
        {
            Debug.Log("saving data");
            string path = CreateValidDataPath(RelativePath);
            bool result = SaveDataInternal(path, Data, Encrypt);
            return result;
        }

        private bool SaveDataInternal<T>(string FullPath, T Data, bool Encrypt)
        {
            Debug.Log("saving internally");
            try
            {
                if (File.Exists(FullPath))
                {
                    Debug.Log($"File exists at path {FullPath}. Overwriting");
                    File.Delete(FullPath);
                }
                Debug.Log($"Creating new file at path {FullPath}");
                Directory.CreateDirectory(Path.GetDirectoryName(FullPath));
                FileStream stream = File.Create(FullPath);
                stream.Close();
                File.WriteAllText(FullPath, JsonConvert.SerializeObject(Data));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> SaveDataAsync<T>(string RelativePath, T Data, bool Encrypt = false)
        {
            string path = CreateValidDataPath(RelativePath);
            bool result = await Task.Run(() => SaveDataInternal(RelativePath, Data, Encrypt));
            return result;
        }

        public T LoadData<T>(string RelativePath, T DefaultData, bool isEncrypted = false)
        {
            string path = CreateValidDataPath(RelativePath);
            return LoadDataInternal(path, DefaultData, isEncrypted);
        }

        public T LoadDataInternal<T>(string RelativePath, T DefaultData, bool isEncrypted = false)
        {
            if(!File.Exists(RelativePath))
            {
                Debug.LogWarning($"File at path {RelativePath} not found, returning default data...");
                return DefaultData;
            }

            try
            {
                T data = JsonConvert.DeserializeObject<T>(File.ReadAllText(RelativePath));
                return data;
            }
            catch(Exception e)
            {
                Debug.LogError($"Error loading data: {e}");
                Debug.LogWarning($"Data at file path {RelativePath} was not of the correct type, returning default data...");
                return DefaultData;
            }
        }

        public async Task<T> LoadDataAsync<T>(string RelativePath, T DefaultData, bool isEncrypted = false)
        {
            string path = CreateValidDataPath(RelativePath);
            T result = await Task.Run(() => LoadDataInternal(RelativePath, DefaultData, isEncrypted));
            return result;
        }

        public bool PurgeData()
        {
            string path = StaticGameStats.persistentDataPath;
            Debug.LogWarning("File purge begun. Deleting all save data...");
            try
            {
                DirectoryInfo pathInfo = new DirectoryInfo(path);
                if(pathInfo != null)
                {
                    foreach (FileInfo file in pathInfo.EnumerateFiles())
                        file.Delete(); 
                    foreach (DirectoryInfo dir in pathInfo.EnumerateDirectories())
                        dir.Delete(true); 
                }

                return true;
            }
            catch(Exception e)
            {
                Debug.LogWarning($"Data could not be purged due to exception\n({e})\n, aborting purge process.");
                return false;
            }
        }

        private string CreateValidDataPath(string relativePath)
        {
            string result = relativePath;
            if(!result.StartsWith('/')) 
                result = '/' + relativePath;
            if(!result.EndsWith(".json"))
                result += ".json";

            return StaticGameStats.persistentDataPath + result;
        }
    }
}