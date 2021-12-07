using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueZone : MonoBehaviour
{
    [SerializeField]
    private DialogueTrigger dialogue;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1") && collision.CompareTag("Player"))
        {
            Debug.Log("Zone clicked");
            dialogue.TriggerDialogue();
        }
    }
}
