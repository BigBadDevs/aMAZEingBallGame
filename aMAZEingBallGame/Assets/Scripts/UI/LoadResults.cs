using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadResults : MonoBehaviour
{
    public GameObject resultsScreenRef;
    public GameObject resultTimeRef;
    public GameObject UIRef;
    public GameObject UITimeRef;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))               //Enables the Results screen > transfers timer data > disables game HUD
        {
            //change name to what ever the name of the main menu is called
            SceneManager.LoadScene("MenuIvan");


            /*      *when the HUD is done and time + score is reintergrated*
            UITimeRef.GetComponent<TimerScript>().counting = false;
            resultsScreenRef.SetActive(true);
            resultTimeRef.GetComponent<TimerScript>().setTime(UITimeRef.GetComponent<TimerScript>().minutes, UITimeRef.GetComponent<TimerScript>().seconds);
            UIRef.SetActive(false);
            */
        }
    }


}