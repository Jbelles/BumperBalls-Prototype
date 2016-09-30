using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	public Transform SmallBall;
	// Use this for initialization
	void Start () {
		//transform.GetComponent<Renderer>().material.color = Color.red;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y < 0) {
			Color color = transform.GetComponent<Renderer>().material.color;
			for (int i = -1; i < 2; i++)
				for (int j = -1; j < 2; j++) {
					if (i != 0 && j != 0) {
						Transform temp = (Transform)Instantiate (SmallBall, new Vector3 (transform.position.x + i*.5f, transform.position.y, transform.position.z + j*.5f), Quaternion.identity);
						temp.GetComponent<Renderer> ().material.color = color;
						temp.GetComponent<Rigidbody> ().AddForce (((transform.position - Vector3.zero)+Vector3.up) * 30f);
					}
				}
			Destroy (transform.gameObject);
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name != "Field" && col.gameObject.name != "Bumper") {
			ContactPoint contact = col.contacts [0];
			Vector3 pos = contact.point;
			Vector3 dir = Vector3.Normalize (pos - transform.position);
			col.gameObject.GetComponent<Rigidbody> ().AddForce (dir * 75f);
		}
	}


}
