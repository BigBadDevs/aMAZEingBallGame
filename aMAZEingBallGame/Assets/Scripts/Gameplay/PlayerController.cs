using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject spawnLocation;
    public GameObject finishLocation;

    public int scoreCount;
    public int retryCount;

    CharacterController controller;

 
	void Start()
	{
        scoreCount = 0;
        retryCount = 0;

        controller = this.GetComponent<CharacterController>();
	}
	
	void Update ()
	{
       
	}
	
	void OnTriggerEnter(Collider other) 
	{
       // input wasd add force
       // if ((Input.GetAxis("Horizontal") < 0)
       // {
       //     this.transform.
       // }


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
