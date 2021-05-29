using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text scoreText;

    public int points;

    public GameObject playerRef;
        
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>() as Text;
        
    }
	
	// Update is called once per frame
	void Update () {
        points = playerRef.GetComponent<PlayerController>().scoreCount;
        scoreText.text = points.ToString("00");
    }
}
