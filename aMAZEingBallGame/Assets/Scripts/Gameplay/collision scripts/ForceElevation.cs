using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceElevation : MonoBehaviour
{
    public float forcePower = 10f;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 currentVelocity = new Vector3(other.gameObject.GetComponent<PlayerMainScript>().rigidBody.velocity.x,0,
                        other.gameObject.GetComponent<PlayerMainScript>().rigidBody.velocity.z);
            other.gameObject.GetComponent<PlayerMainScript>().rigidBody.velocity = new Vector3(currentVelocity.x, forcePower, currentVelocity.z);


        }
    }
}
