using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanTilt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerControllerNew>().canTilt=true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerControllerNew>().canTilt = false;
        }
    }
}
