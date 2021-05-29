using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public Text timerText;

    public float seconds, minutes;

    public bool counting = true;

    private float startTime;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>() as Text;
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if (counting == true)
        {
            minutes = ((int)(Time.time - startTime) / 60f);
            seconds = (int)((Time.time - startTime) % 60f);

        }
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public void setTime(float min, float sec)
    {
        seconds = sec;
        minutes = min;
    }
}
