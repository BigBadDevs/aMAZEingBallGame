using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject spawnLocation;
    public GameObject finishLocation;
    public Rigidbody rb;
 
    public float speed;
    public int scoreCount;
    public int retryCount;



 
	void Start()
	{
        scoreCount = 0;
        retryCount = 0;
        rb = gameObject.GetComponent<Rigidbody>();
    }
	
	void Update ()
	{
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed * Time.deltaTime);
    }
	
	void OnTriggerEnter(Collider other) 
	{
        if (other.gameObject.tag == "Finish")               //change to run the score menu
        {
 
            transform.position = finishLocation.transform.position;
        }
        else if (other.gameObject.tag == "PickUp")          //destroy pickup and add to score
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false ;
            other.gameObject.GetComponent<Collider>().enabled = false;
            scoreCount++;
        }
        else if (other.gameObject.tag == "DontPickUp")      //destroy dontpickup and subtract from score
        {

            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = false;
            scoreCount--;
        }

        //

	}

    private void OnMouseDown()      // reset to start
    {

        transform.position = spawnLocation.transform.position;
        retryCount++;
    }
}
