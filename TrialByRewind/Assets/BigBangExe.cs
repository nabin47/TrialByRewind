using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBangExe : MonoBehaviour
{
    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<BigBangDiaManager>().StartDialogue(dialogue);
    }

}
