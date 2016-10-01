using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//ignore collisions between bumpers and stage
		Physics.IgnoreCollision (transform.GetComponent<SphereCollider> (), GameObject.Find ("Field").GetComponent<MeshCollider> ());
	}
	void OnCollisionEnter(Collision col){
		//get contact point, return a force directed at the colliding object in the direction that contact occured
		ContactPoint contact = col.contacts [0];
		Vector3 pos = contact.point;
		Vector3 dir = Vector3.Normalize (pos - transform.position);
		col.gameObject.GetComponent<Rigidbody> ().AddForce (dir * 300f);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
