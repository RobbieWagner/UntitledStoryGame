using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RobbieWagnerGames.Dialogue;

namespace RobbieWagnerGames.SimGame
{
    public class TutorialSequenceEvent : SequenceEvent
    {
        [SerializeField] private Tutorial tutorial;
        private bool isTutorialPlaying = false;

        public override IEnumerator InvokeSequenceEvent()
        {
            yield return StartCoroutine(base.InvokeSequenceEvent());
            isTutorialPlaying = true;
            tutorial.OpenTutorial();
            tutorial.OnCompleteTutorial += CompleteTutorialEvent;

            while (isTutorialPlaying)
                yield return null;
        }

        private void CompleteTutorialEvent() => isTutorialPlaying = false;
    }
}