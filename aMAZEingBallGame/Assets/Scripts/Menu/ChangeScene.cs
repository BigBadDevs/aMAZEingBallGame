using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    AudioSource audioSource;
    AudioClip soundToPlay; 

    public void sceneSelect(string sceneToChangeTo)
    {
        if (sceneToChangeTo == "MiniGame")
        {

        }
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
