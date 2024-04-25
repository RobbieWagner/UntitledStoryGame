using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobbieWagnerGames.SimGame
{
    public class SceneEvent : MonoBehaviour
    {
        public virtual IEnumerator RunSceneEvent()
        {
            yield return null;
        }
    }
}