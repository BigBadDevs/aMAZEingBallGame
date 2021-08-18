using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private InputAction left;
    [SerializeField]
    private InputAction right;
    [SerializeField]
    private InputAction up;
    [SerializeField]
    private InputAction back;
    [SerializeField]
    private InputAction front;


    private Animator animator;
    private string currentState;


    const string THIRDCAMERA_BACK = "3rdPersonBackState";
    const string THIRDCAMERA_FRONT = "3rdPersonFrontState";
    const string THIRDCAMERA_LEFT = "3rdPersonLeftState";
    const string THIRDCAMERA_RIGHT = "3rdPersonRightState";
    const string THIRDCAMERA_UP = "3rdPersonUpState";





    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        left.Enable();
        right.Enable();
        front.Enable();
        up.Enable();
        back.Enable();

    
    }
    
    private void OnDisable()
    {
        left.Disable();
        right.Disable();
        front.Disable();
        up.Disable();
        back.Disable();

    }
    
    // Start is called before the first frame update
    void Update()
    {    
     left.performed += _ => ChangeAnimationState(THIRDCAMERA_LEFT);
            
     right.performed += _ => ChangeAnimationState(THIRDCAMERA_RIGHT);
            
     up.performed += _ => ChangeAnimationState(THIRDCAMERA_UP);
            
     back.performed += _ => ChangeAnimationState(THIRDCAMERA_BACK);
            
     front.performed += _ => ChangeAnimationState(THIRDCAMERA_FRONT);
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

   
}
