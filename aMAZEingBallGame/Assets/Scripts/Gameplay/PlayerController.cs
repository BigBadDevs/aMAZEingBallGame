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

    // use this to adjust how much the player can jump and then make it private
    public int jumpHeight;

    private Collider[] ballCollisions;
    private float distToGround;


    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

    void Start()
	{
        scoreCount = 0;
        retryCount = 0;
        rb = gameObject.GetComponent<Rigidbody>();
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }
	
	void Update ()
	{
        // in the input manager you can change these for mobile inputs like touch swipe or tilt
        // basic xz movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        rb.AddForce(movement * speed * Time.deltaTime);

        // jump with button input
        if (Input.GetButton("Jump")&& IsGrounded())
        {
            rb.AddForce(0f, jumpHeight, 0f);
        }

        ballCollisions = Physics.OverlapSphere(gameObject.transform.position, 0.78f);     // search for a player coliding with the ball
        foreach (Collider index in ballCollisions)
        {
            if (index.CompareTag("Bounce"))
            {
                rb.AddForce((index.transform.position - gameObject.transform.position) * -100f);
            }
        }

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

    }

    private void OnMouseDown()      // reset to start
    {

        transform.position = spawnLocation.transform.position;
        retryCount++;
    }
}
