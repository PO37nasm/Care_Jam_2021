using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour

{
    [SerializeField]
    public Slider slider;
    [SerializeField]
    private AudioMixer mixer;
    [SerializeField]
    private string PlayerPrefName;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(PlayerPrefName, 0.75f);
    }

    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(PlayerPrefName, sliderValue);        
    }
}
