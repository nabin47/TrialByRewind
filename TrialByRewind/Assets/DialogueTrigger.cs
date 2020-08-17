using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public Animator animator;

    public void TriggerDialogue ()
    {
        CloseButton();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void CloseButton()
    {
        animator.SetBool("IsClose", true);
    }
}
