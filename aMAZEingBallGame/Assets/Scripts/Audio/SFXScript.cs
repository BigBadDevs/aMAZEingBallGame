using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour {

    public AudioClip soundToPlay;
    public float volume;
    AudioSource audioSource;
    public bool alreadyPlayed = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (!alreadyPlayed)
            {
                audioSource.PlayOneShot(soundToPlay, volume);
                alreadyPlayed = true;
                Debug.Log("asdef");
            }
        }
    }
}
