using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControllerNew : MonoBehaviour
{
    public Transform cam;

    private float speed = 1f;
    private float asdef;

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
        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            //calculate input direction using camera angle
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            
            //create a direction variable
            Vector3 moveTarget = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            //add force in direction of new variable
            Ball_rigidbody.AddForce(moveTarget.normalized * speed, ForceMode.Force);
        }
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
