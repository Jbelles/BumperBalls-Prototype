using UnityEngine;
using System.Collections;

public class SmallerBallCollector : MonoBehaviour {

	// Use this for initialization
	void FixedUpdate(){
		if (transform.position.y < -3)
			Destroy (transform.gameObject);
	}
}
