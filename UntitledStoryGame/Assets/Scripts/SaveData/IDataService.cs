using UnityEngine;

namespace RobbieWagnerGames.Common
{
    public interface IDataService
    {
        bool SaveData<T>(string RelativePath, T Data, bool Encrypt = false);
        T LoadData<T>(string RelativePath, T DefaultData, bool isEncrypted);
        bool PurgeData();
    }
}