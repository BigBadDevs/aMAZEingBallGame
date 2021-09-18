using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    //power of the push back
    public float forcePower = 50;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMainScript>().rigidBody.AddForce((gameObject.transform.position - other.transform.position) * -forcePower);
        }
    }
}
