using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMainScript : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform cam;
    public bool canTilt = false;
    public int scoreCount;
    public int retryCount;
    public float jumpHeight;
    public float speed;

    private InputMaster inputMaster;



    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        // playerInput = GetComponent<PlayerInput>();

        speed = 200f;

        inputMaster = new InputMaster();
        inputMaster.Player.Enable();
        inputMaster.Player.Jump.performed += Jump;
    }

    private void Update()
    {
        Vector2 inputVector = inputMaster.Player.Movement.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            //calculate input direction using camera angle
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            //create a direction variable
            Vector3 moveTarget = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            //add force in direction of new variable
            rigidBody.AddForce(moveTarget.normalized * speed * Time.deltaTime, ForceMode.Force);

        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rigidBody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
    }

    public void Reset()
    {
        rigidBody.velocity = new Vector3(0, 0, 0);
        transform.position = GameObject.Find("/world/Spawn point").transform.position;
        retryCount++;
    }
}

