using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject target;
    public LayerMask mylayermask;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, (target.transform.position - camera.transform.position).normalized,
            out hit, Mathf.Infinity, mylayermask))
        {

            if (hit.collider.gameObject.tag == "spheremask")
            {
                Debug.Log("See");
            }

            else
            {
                Debug.Log("NOTSee");
            }
        }
    }
}
