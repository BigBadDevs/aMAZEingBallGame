using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScript : MonoBehaviour {

    public Vector3 currentRot;

	// Use this for initialization
	void Start () {
        currentRot = new Vector3(0.0f, 0.0f, 0.0f);
        transform.Rotate(0, 0, 0.2f);
    }
	
	// Update is called once per frame
	void Update () {

        currentRot = GetComponent<Transform>().eulerAngles;
        transform.rotation = Quaternion.Euler(currentRot.x, 0.0f, currentRot.z);

        if ((Input.GetAxis("TiltHorizontal") < 0 ) && (currentRot.z <= 4  || currentRot.z >= 355))
        {
            transform.Rotate(0 , 0 , 0.05f );
        }

        if ((Input.GetAxis("TiltHorizontal") > 0 ) && (currentRot.z >= 356  || currentRot.z <= 5 ))
        {
            transform.Rotate(0 , 0 , -0.05f);
        }

        if ((Input.GetAxis("TiltVertical") > 0) && (currentRot.x <= 4 || currentRot.x >= 355))
        {
            transform.Rotate(0.05f , 0, 0);
        }

        if ((Input.GetAxis("TiltVertical") < 0) && (currentRot.x >= 356 || currentRot.x <= 5))
        {
            transform.Rotate(-0.05f, 0, 0);
        }
     
    }
}
