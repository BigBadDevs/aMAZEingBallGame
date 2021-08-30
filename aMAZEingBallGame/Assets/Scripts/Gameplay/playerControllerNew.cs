using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControllerNew : MonoBehaviour
{
    private Rigidbody Ball_rigidbody;
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
        if(context.performed && IsGrounded())
        {
            Debug.Log("jump!" + context.phase);
            Ball_rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }    
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
    }

    public void Reset()
    {
        Ball_rigidbody.velocity = new Vector3(0, 0, 0);
        transform.position = GameObject.Find("/world/Spawn point").transform.position;
        //retryCount++;
    }
}
