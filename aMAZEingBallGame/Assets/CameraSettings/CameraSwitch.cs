using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{
    private InputMaster inputMaster;

    private Animator animator;
    private string currentState;


    const string THIRDCAMERA_BACK = "3rdPersonBackState";
    const string THIRDCAMERA_FRONT = "3rdPersonFrontState";
    const string THIRDCAMERA_LEFT = "3rdPersonLeftState";
    const string THIRDCAMERA_RIGHT = "3rdPersonRightState";
    const string THIRDCAMERA_UP = "3rdPersonUpState";

    //Defining the direction and reset variables for looping (if reset 0 set to west ie)
    enum Direction {Reset0, North, East, South, West, Reset5};
    private Direction currentDirection = Direction.North;


    private void Awake()
    {
        inputMaster = new InputMaster();
        inputMaster.Camera.Enable();
        inputMaster.Camera.turnLeft.performed += left;
        inputMaster.Camera.turnRight.performed += right;

        animator = GetComponent<Animator>();
    }

    
    void Update()
    {   



    }

    void ChangeAnimationState(string newState)
    {
        //stop the same animation from interrupting itself
        if (currentState == newState) return;

        //play the animation
        animator.Play(newState);

        //reassign the current state
        currentState = newState;
    }

    public void left(InputAction.CallbackContext context)
    {
        //Debug.Log("Left performed");
        if(context.performed)
        {
            currentDirection = turnLeft(currentDirection);
            setAnimation();
        }
        
    }
    public void right(InputAction.CallbackContext context)
    {
        //Debug.Log("Right performed");
        if (context.performed)
        {
            currentDirection = turnRight(currentDirection);
            setAnimation();
        }
    }

    Direction turnLeft(Direction dir)
    {

        dir += 1;
        if (dir == Direction.Reset5)
        {
            dir = Direction.North;
        }

        return dir;
    }

    Direction turnRight(Direction dir)
    {
        dir -= 1;
        if (dir == Direction.Reset0)
        {
            dir = Direction.West;
        }
        
        return dir;
    }

    void setAnimation()
    {
        // after turn function, set the corresponding animation state
        if (currentDirection == Direction.North)
        { ChangeAnimationState(THIRDCAMERA_BACK); }
        else if (currentDirection == Direction.East)
        { ChangeAnimationState(THIRDCAMERA_RIGHT); }
        else if (currentDirection == Direction.South)
        { ChangeAnimationState(THIRDCAMERA_FRONT); }
        else if (currentDirection == Direction.West)
        { ChangeAnimationState(THIRDCAMERA_LEFT); }
    }


}
