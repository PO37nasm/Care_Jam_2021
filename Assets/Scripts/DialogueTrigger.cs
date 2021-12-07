using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [Header("Event")]
    [Space]
    public UnityEvent onBeginEvent;
    public void TriggerDialogue()
    {
        Debug.Log("Dialogue Triggered");
        onBeginEvent.Invoke();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
