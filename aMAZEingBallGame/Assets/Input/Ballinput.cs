using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ballinput : MonoBehaviour
{
    private Rigidbody Ball_rigidbody;
   // private PlayerInput playerInput;
    private InputMaster inputmaster;

    private void Awake()
    {
        Ball_rigidbody = GetComponent<Rigidbody>();
       // playerInput = GetComponent<PlayerInput>();

        inputmaster = new InputMaster();
        inputmaster.Player.Enable();
        inputmaster.Player.Jump.performed += Jump;
    }

    private void Update()
    {
        Vector2 inputVector = inputmaster.Player.Movement.ReadValue<Vector2>();
        float speed = 1f;
        Ball_rigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Jump (InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if(context.performed)
        {
            Debug.Log("jump!" + context.phase);
            Ball_rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }    
    }
}
