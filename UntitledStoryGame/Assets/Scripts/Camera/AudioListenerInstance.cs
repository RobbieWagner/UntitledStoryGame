using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using FMODUnity;

namespace RobbieWagnerGames.Common
{
    public class AudioListenerInstance : MonoBehaviour
    {
        //public StudioListener audioListener;
        public static AudioListenerInstance Instance {get; private set;}

        private void Awake()
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(gameObject); 
            } 
            else 
            { 
                Instance = this; 
            } 
        }

        //public Vector3 GetAttenuationObjectPosition() => audioListener.attenuationObject.transform.position;
    }
}