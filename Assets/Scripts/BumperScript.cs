using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision (transform.GetComponent<SphereCollider> (), GameObject.Find ("Field").GetComponent<MeshCollider> ());
	}
	void OnCollisionEnter(Collision col){
		print ("contact");
		ContactPoint contact = col.contacts [0];
		Vector3 pos = contact.point;
		Vector3 dir = Vector3.Normalize (pos - transform.position);
		col.gameObject.GetComponent<Rigidbody> ().AddForce (dir * 300f);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
