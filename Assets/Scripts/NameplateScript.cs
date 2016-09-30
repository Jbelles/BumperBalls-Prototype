using UnityEngine;
using System.Collections;

public class NameplateScript : MonoBehaviour {


	// Update is called once per frame
	void FixedUpdate () {
		if (GameObject.Find ("Player") != null) {
			transform.position = new Vector3 (GameObject.Find ("Player").transform.position.x + .07f, GameObject.Find ("Player").transform.position.y + 1.5f, GameObject.Find ("Player").transform.position.z);
			Invoke ("DestroySelf", 3f);
		}
		else
			DestroySelf ();

	}

	void DestroySelf(){
		Destroy (transform.gameObject);
	}
}
