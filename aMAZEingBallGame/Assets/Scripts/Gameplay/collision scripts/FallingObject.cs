using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    Rigidbody rb;
    public float dropDelay = 0.5f;
    public float respawnDelay = 2.0f;
    public GameObject respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Invoke("PlatformDrop",dropDelay);
        }
    }

    void PlatformDrop()
    {
        rb.isKinematic = false;
        Invoke("Respawn", respawnDelay);
        //Destroy(gameObject, 2f);
    }

    void Respawn()
    {
        rb.isKinematic = true;
        gameObject.transform.position = respawnPoint.transform.position;
    }
}
