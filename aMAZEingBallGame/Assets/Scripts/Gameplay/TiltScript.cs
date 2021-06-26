using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScript : MonoBehaviour {

    public Vector3 currentRot;
    public GameObject player;
    private float rotationSpeed = 0.05f;
    private float maxRotation = 12;

	// Use this for initialization
	void Start () {
        currentRot = new Vector3(0.0f, 0.0f, 0.0f);
        transform.Rotate(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {

        currentRot = GetComponent<Transform>().eulerAngles;
        transform.rotation = Quaternion.Euler(currentRot.x, 0.0f, currentRot.z);

        if (player.GetComponent < PlayerController > ().canTilt == true)
        {
            if ((Input.GetAxis("TiltHorizontal") > 0) && (currentRot.z <= maxRotation || currentRot.z >= 359 - maxRotation))
            {
                transform.Rotate(0, 0, rotationSpeed);
            }

            if ((Input.GetAxis("TiltHorizontal") < 0) && (currentRot.z >= 361 - maxRotation || currentRot.z <= maxRotation +1))
            {
                transform.Rotate(0, 0, -rotationSpeed);
            }

            if ((Input.GetAxis("TiltVertical") > 0) && (currentRot.x <= maxRotation || currentRot.x >= 359 - maxRotation))
            {
                transform.Rotate(rotationSpeed, 0, 0);
            }

            if ((Input.GetAxis("TiltVertical") < 0) && (currentRot.x >= 361 - maxRotation || currentRot.x <= maxRotation +1))
            {
                transform.Rotate(-rotationSpeed, 0, 0);
            }
        }
    }
}
