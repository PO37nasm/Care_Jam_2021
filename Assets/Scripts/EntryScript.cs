using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryScript : MonoBehaviour
{
    public DialogueTrigger openingDialogue;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<DialogueTrigger>().TriggerDialogue();
        openingDialogue.TriggerDialogue();
    }


}
