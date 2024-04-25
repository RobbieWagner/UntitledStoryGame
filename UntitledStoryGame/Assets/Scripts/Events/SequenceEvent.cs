using System.Collections;
using UnityEngine;
using RobbieWagnerGames.Dialogue;

namespace RobbieWagnerGames.SimGame
{
    public class SequenceEvent : MonoBehaviour
    {
        public virtual IEnumerator InvokeSequenceEvent()
        {
            yield return null;
        }
    }
}