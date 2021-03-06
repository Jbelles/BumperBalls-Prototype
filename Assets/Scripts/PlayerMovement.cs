using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (SystemInfo.deviceType == DeviceType.Desktop) 
		{ 
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			// Building of force vector 
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			// Adding force to rigidbody
			transform.GetComponent<Rigidbody>().AddForce(movement * 10);
		}
		else
		{
			// Player movement on mobile devices (hopefully)
			// Building of force vector 
			Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, Input.acceleration.y);
			// Adding force to rigidbody
			transform.GetComponent<Rigidbody>().AddForce(movement * 10);
		}
	}



}