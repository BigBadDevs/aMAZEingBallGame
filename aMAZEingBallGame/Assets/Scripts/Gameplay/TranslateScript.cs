using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateScript : MonoBehaviour
{
    public float speed;
    public Transform[] destinationArray = new Transform[4];

    private float step;
    private int index;
    private bool destinationConfirmed;

    // has the target destination been reached?
    private void destinationCheck()
    {
        if (transform.position - destinationArray[index].position == new Vector3(0, 0, 0))
        {
            // select next destination or reset to the first
            index++;
            if (index == destinationArray.Length)
            { index = 0; }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // delta time speed
        step = speed * Time.deltaTime;

        // check if the given location has a position. FAIL SAFE - will not cause a crash but will prevent the object moving
        if (destinationArray[index] == null)
        {
            Debug.Log("no destination given. remove empty destination members!");
            destinationConfirmed = false;
        }
        else destinationConfirmed = true;

        // if a position has been given move towards and check if the destination has been reached
        if (destinationConfirmed)
        {
            transform.position = Vector3.MoveTowards(transform.position, destinationArray[index].position, step);
            destinationCheck();
        }
    }
}
