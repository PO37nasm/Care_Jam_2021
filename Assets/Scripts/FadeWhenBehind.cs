using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeWhenBehind : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Debug.Log("Inside");
            GetComponent<Animator>().Play("Fadeout");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Debug.Log("Outside");
            GetComponent<Animator>().Play("FadeIn");
        }
    }
}
