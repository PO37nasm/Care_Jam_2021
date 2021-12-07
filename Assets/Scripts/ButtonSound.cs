using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    //REDUNDANT
    private Button button { get { return GetComponent<Button>(); } }
    [SerializeField]
    private AudioClip hoverSound;
    [SerializeField]
    private AudioClip clickSound;

    private void OnMouseEnter()
    {
        PlaySound(hoverSound);
        Debug.Log("Button Hover");
    }

    private void OnMouseUpAsButton()
    {
        PlaySound(clickSound);
        Debug.Log("Button Click");
    }

    private void PlaySound(AudioClip sound)
    {
        GetComponent<AudioSource>().PlayOneShot(sound);
    }
}
