using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public TMP_Text response1;
    public TMP_Text response2;
    public TMP_Text response3;
    public Animator animator;

    private Queue<Line> sentences;
    private Response[] responses;
    // Start is called before the first frame update
    void Awake()
    {
        sentences = new Queue<Line>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        GameManager.inputEnabled = false;
        FindObjectOfType<Movement>().freeze();
        ClearResponses();
        responses = dialogue.responses;
        animator.SetBool("isOpen", true);
        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        sentences.Clear();

        if(dialogue.name == "Moving On")
        {
            EndDialogue();
            return;
        }
   

        foreach (Line sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            if (responses.Length == 1)
            {
                Pick1();
                return;
            }
            else
            {
                DisplayResponses();
                return;
            }
        }
            

        Line line = sentences.Dequeue();
        string sentence = line.text;
        //int expression = line.expression;
        Debug.Log(sentence);

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void DisplayResponses()
    {
        response1.text = responses[0].text;
        response2.text = responses[1].text;
        response3.text = responses[2].text;
    }
    
    public void Pick1()
    {
        StartDialogue(responses[0].link.dialogue);
    }
    public void Pick2()
    {
        StartDialogue(responses[1].link.dialogue);
    }
    public void Pick3()
    {
        StartDialogue(responses[2].link.dialogue);
    }

    public void ClearResponses()
    {
        response1.text = "";
        response2.text = "";
        response3.text = "";
    }

    void EndDialogue()
    {
        GameManager.inputEnabled = true;
        FindObjectOfType<Movement>().unFreeze();
        animator.SetBool("isOpen", false);
        Debug.Log("End of conversation");
    }

}
