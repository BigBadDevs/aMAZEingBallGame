using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {
    public AudioClip soundToPlay;
    public float volume;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ReloadScene()
    {
        audioSource.PlayOneShot(soundToPlay, volume);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
