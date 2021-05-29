using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttemptScript : MonoBehaviour
{

    public Text attemptText;

    public int attempts;

    public GameObject playerRef;

    // Use this for initialization
    void Start()
    {
        attemptText = GetComponent<Text>() as Text;

    }

    // Update is called once per frame
    void Update()
    {
        attempts = playerRef.GetComponent<PlayerController>().retryCount;
        attemptText.text = attempts.ToString("00");
    }
}
