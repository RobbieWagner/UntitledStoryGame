using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ink.Runtime;
using RobbieWagnerGames.Dialogue;

namespace RobbieWagnerGames.Common
{
    public class DialogueInteractable : IInteractable
    {
        [SerializeField] private string npcName;
        private string saveDataName;
        [SerializeField] protected TextAsset dialogueText;
        private int interactions;

        protected override void Awake()
        {
            base.Awake();
            interactions = JsonDataService.Instance.LoadData(StaticGameStats.dialogueSavePath + npcName + gameObject.scene.name, 0, false);
        }

        private Story ConfigureStory()
        {
            Story configuredStory = new Story(dialogueText.text);
            //configuredStory.variablesState["interactions"] = interactions;

            return configuredStory;
        }

        protected override IEnumerator Interact()
        {
            Story story = ConfigureStory();
            yield return StartCoroutine(DialogueManager.Instance.EnterDialogueModeCo(story));

            yield return base.Interact();

            StopCoroutine(Interact());
        }

        protected override void OnUninteract()
        {
            base.OnUninteract();

            interactions++;

            SaveInteractionData();
        }

        protected void SaveInteractionData()
        {
            //SaveInt saveInt = new SaveInt(saveDataName, interactions);
            //GameManager.Instance.sessionSaveData.AddToSaveList(saveInt);
        }
    }
}