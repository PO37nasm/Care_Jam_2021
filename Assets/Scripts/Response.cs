using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Response
{
    [TextArea(1, 10)]
    public string text;
    public DialogueTrigger link;
}
