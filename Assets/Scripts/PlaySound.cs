using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : StateMachineBehaviour
{
    //[SerializeField]
    //public AudioSource playerAudio;
    [SerializeField]
    private AudioClip sound;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindObjectOfType<Movement>().GetComponent<AudioSource>().PlayOneShot(sound);
    }
}
