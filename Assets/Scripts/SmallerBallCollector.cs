using UnityEngine;
using System.Collections;

public class SmallerBallCollector : MonoBehaviour {

	// Use this for initialization
	void FixedUpdate(){
		//Again this should be called when a ball is destroyed and not in Fixed Update but I am probably passing my 8 hour limit
		if (transform.position.y < -3)
			//just cleaning up
			Destroy (transform.gameObject);
	}
}
