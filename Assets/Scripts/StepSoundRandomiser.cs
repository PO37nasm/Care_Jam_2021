using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSoundRandomiser : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> steps;

    public AudioClip GetStep()
    {
        return steps[Random.Range(0, steps.Count)];
    }

}
