using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TiltScript : MonoBehaviour {

    public Vector3 currentRot;
    public GameObject player;
    public float maxRotation;
    private float rotationSpeed;

    private InputMaster inputMaster;


    // Use this for initialization
    void Start () 
    {
        rotationSpeed = 0.05f;
        currentRot = new Vector3(0.0f, 0.0f, 0.0f);
        transform.Rotate(0, 0, 0);

        inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        inputMaster.Player.TiltXp.performed += TiltXp;
    }

    public void TiltXp(InputAction.CallbackContext context)
    {
        if (context.performed && player.GetComponent<PlayerMainScript>().canTilt == true
            && (currentRot.x <= maxRotation || currentRot.x >= 359 - maxRotation))
        {
            transform.Rotate(rotationSpeed, 0, 0);
        }
    }

    private void rotationCheck()
    {
        if (transform.rotation.x > maxRotation)
        {
            
        }
    }
 
    void Update () 
    {
        if (GameObject.Find("BALLPLAYER/Player").GetComponent<PlayerMainScript>().canTilt)
        {
            currentRot = GetComponent<Transform>().eulerAngles;
            //transform.rotation = Quaternion.Euler(currentRot.x, 0.0f, currentRot.z);

            Vector2 inputVector = inputMaster.Player.Tilt.ReadValue<Vector2>();
            Vector3 tiltDirection = new Vector3(inputVector.x, 0, inputVector.y).normalized;

            if (tiltDirection.magnitude >= 0.1f)
            {

                transform.Rotate(tiltDirection * rotationSpeed);
            }

        }
    }
}
