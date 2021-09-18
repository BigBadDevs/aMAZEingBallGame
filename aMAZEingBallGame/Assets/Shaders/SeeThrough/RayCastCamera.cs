using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RayCastCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject target;
    public GameObject mask;
    //public LayerMask mylayermask;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, 
            (target.transform.position - camera.transform.position).normalized,
            out hit, Mathf.Infinity))
        {

            if (hit.collider.gameObject.tag == "spheremask" || hit.collider.gameObject.tag == "Untagged") 
            {
                mask.transform.DOScale(0, 2);
                Debug.Log("See");
            }

            else 
            {
                mask.transform.DOScale(6, 2);
                Debug.Log("NOTSee");
            }
        }
    }
}
