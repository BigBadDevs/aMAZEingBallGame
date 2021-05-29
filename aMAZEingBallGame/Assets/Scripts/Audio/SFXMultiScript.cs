using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXMultiScript : MonoBehaviour
{

    public AudioClip soundToPlay;
    public float volume;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {

                audioSource.PlayOneShot(soundToPlay, volume);
                Debug.Log("asdef");
            
        }
    }
}