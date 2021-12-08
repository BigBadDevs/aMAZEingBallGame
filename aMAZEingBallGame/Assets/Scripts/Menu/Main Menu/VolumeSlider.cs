using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;//
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
        //Debug.Log(volume);
    }
}
