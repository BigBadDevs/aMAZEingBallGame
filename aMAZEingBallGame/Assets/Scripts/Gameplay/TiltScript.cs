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
    void Start () {
        rotationSpeed = 5f;
        currentRot = new Vector3(0.0f, 0.0f, 0.0f);
        transform.Rotate(0, 0, 0);

        inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        inputMaster.Player.TiltXp.performed += TiltXp;
        inputMaster.Player.TiltZp.performed += TiltZp;
        inputMaster.Player.TiltXm.performed += TiltXm;
        inputMaster.Player.TiltZm.performed += TiltZm;
    }

    public void TiltXp(InputAction.CallbackContext context)
    {
        if (context.performed && player.GetComponent<PlayerControllerNew>().canTilt == true
            && (currentRot.x <= maxRotation || currentRot.x >= 359 - maxRotation))
        {
            transform.Rotate(rotationSpeed, 0, 0);
        }
    }
    public void TiltXm(InputAction.CallbackContext context)
    {
        if (context.performed && player.GetComponent<PlayerControllerNew>().canTilt == true
            && (currentRot.x >= 361 - maxRotation || currentRot.x <= maxRotation + 1))
        {
            transform.Rotate(-rotationSpeed, 0, 0);
        }
    }
    public void TiltZp(InputAction.CallbackContext context)
    {
        if (context.performed && player.GetComponent<PlayerControllerNew>().canTilt == true
            && (currentRot.z <= maxRotation || currentRot.z >= 359 - maxRotation))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
    }
    public void TiltZm(InputAction.CallbackContext context)
    {
        if (context.performed && player.GetComponent<PlayerControllerNew>().canTilt == true
            && (currentRot.z >= 361 - maxRotation || currentRot.z <= maxRotation + 1))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
    }
 
    void Update () 
    {

        currentRot = GetComponent<Transform>().eulerAngles;
        transform.rotation = Quaternion.Euler(currentRot.x, 0.0f, currentRot.z);

    }
}
