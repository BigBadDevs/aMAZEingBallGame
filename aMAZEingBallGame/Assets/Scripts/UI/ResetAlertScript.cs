using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAlertScript : MonoBehaviour {

    public GameObject spriteRef;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            spriteRef.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            spriteRef.SetActive(false);
        }
    }
}
