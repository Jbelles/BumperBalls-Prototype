using UnityEngine;
using System.Collections;

public class SmallBallController : MonoBehaviour {
	public Transform SmallerBall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Again this should be called when a ball is destroyed and not in Fixed Update but I am probably passing my 8 hour limit
		if (transform.position.y < 0) {
			Color color = transform.GetComponent<Renderer>().material.color;
			//splits ball int 4 smaller balls, the upwards Addforce doesnt do much here, but can be used if you want a delay between first and second splits
			for (int i = -1; i < 2; i++)
				for (int j = -1; j < 2; j++) {
					if (i != 0 && j != 0) {
						Transform temp = (Transform)Instantiate (SmallerBall, new Vector3 (transform.position.x + i*.2f, transform.position.y, transform.position.z + j*.2f), Quaternion.identity);
						temp.GetComponent<Renderer> ().material.color = color;
						temp.GetComponent<Rigidbody> ().AddForce (((transform.position - Vector3.zero)+Vector3.up) * 30f);
					}
				}
			Destroy (transform.gameObject);
		}
	}
}
