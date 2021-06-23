using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	public int spinSpeed;
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3(0, spinSpeed, 0) * Time.deltaTime);
	}
}
