using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStepSound : StateMachineBehaviour
{
    [SerializeField]
    private float stepRate = 0.1f;
    private StepSoundRandomiser randomiser;
    private float lastStep = 0;

    private void OnEnable()
    {
        randomiser = FindObjectOfType<StepSoundRandomiser>();
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if ( Time.fixedTime - lastStep > stepRate)
        {
            randomiser.GetComponent<AudioSource>().PlayOneShot(randomiser.GetStep());
            lastStep = Time.fixedTime;
            //Debug.Log("Step");
        }
    }

    //IEnumerator StepWait()
    //{
        //yield return new WaitForSeconds(stepRate);
        //step = true;
    //
}
