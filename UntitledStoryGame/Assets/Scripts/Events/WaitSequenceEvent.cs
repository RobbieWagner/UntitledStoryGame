using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RobbieWagnerGames.Dialogue;

namespace RobbieWagnerGames.SimGame
{
    public class WaitSequenceEvent : SequenceEvent
    {
        [SerializeField] private float timeToWait = 1;
        public override IEnumerator InvokeSequenceEvent()
        {
            Debug.Log($"Waiting for {timeToWait} seconds");
            yield return new WaitForSeconds(timeToWait);
        }
    }
}