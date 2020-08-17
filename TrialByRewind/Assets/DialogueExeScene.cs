using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueExeScene : MonoBehaviour
{
    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<DiaManagerExeScene>().StartDialogue(dialogue);
    }

}
