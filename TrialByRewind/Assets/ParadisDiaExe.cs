using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParadisDiaExe : MonoBehaviour
{
    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<ParadisDiaManager>().StartDialogue(dialogue);
    }

}
