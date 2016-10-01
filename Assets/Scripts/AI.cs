using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	GameObject target;
	GameObject[] enemies;
	Vector3 heading;
	float fieldRadius;
	// Use this for initialization
	void Start () {
		fieldRadius = GameObject.Find ("Field").transform.localScale.x;//GetComponent<MeshFilter> ().mesh.bounds.size.x;
		print (fieldRadius);
	}
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Ball");
		if (Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.z, 2)) > (fieldRadius*.43f)) { //if this ball is near edge of the arena
			target = GameObject.Find ("Field");
		} 
		else {
			target = FindClosestBall (enemies);
		}
		heading = Vector3.Normalize (target.transform.position - transform.position); //determine direction for next movement
		transform.GetComponent<Rigidbody> ().AddForce(heading * 5f);
	}

	GameObject FindClosestBall(GameObject[] enemies){
		float min = Mathf.Infinity;
		GameObject tar = null;
		foreach (GameObject enemy in enemies) { //determine closest enemy
			if (enemy.name != transform.gameObject.name) {
				float dist = Vector3.Distance (enemy.transform.position, transform.position);
				if (dist < min) {
					tar = enemy;
					min = dist;
				}
			}
		}
		if (tar == null) { //if no nearby enemy AKA game end have ball return to center
			tar = GameObject.Find ("Field");
		}
		return tar;
	}
}
