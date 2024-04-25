using UnityEngine;
using Ink.Runtime;
using System.Collections;
using RobbieWagnerGames.Dialogue;

namespace RobbieWagnerGames.SimGame
{
    public class DialogueSequenceEvent : SequenceEvent
    {
        [SerializeField] private TextAsset dialogue;

        public override IEnumerator InvokeSequenceEvent()
        {
            base.InvokeSequenceEvent();
            yield return StartCoroutine(DialogueManager.Instance.EnterDialogueModeCo(DialogueConfigurer.ConfigureStory(dialogue)));
        }
    }
}